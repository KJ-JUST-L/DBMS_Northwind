using System.Data;
using Microsoft.Data.SqlClient;

namespace DBMS_Northwind
{
    public partial class DBMS_NorthwindForm : Form
    {
        public DBMS_NorthwindForm()
        {
            InitializeComponent();
        }

        SqlConnection conn;
        SqlDataAdapter da;
        SqlCommand cmd;

        private void DBMS_NorthwindForm_Load(object sender, EventArgs e)
        {
            conn = ConnectDatabase.ConnectNorthwind();

            //if (conn.State == ConnectionState.Open)
            //{
            //    MessageBox.Show("Connection successful");
            //}
            //else
            //{
            //    MessageBox.Show("Connection failed");
            //}

            ShowData();
        }

        public void ShowData()
        {
            string sql = "SELECT * FROM Shippers";
            cmd = new SqlCommand(sql, conn);
            da = new SqlDataAdapter(cmd);

            DataSet ds = new DataSet();
            da.Fill(ds, "Shippers");
            dgvShippers.DataSource = ds.Tables["Shippers"];
        }

        private void dgvShippers_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            shipperIdInput.Text = dgvShippers.CurrentRow.Cells[0].Value.ToString();
            shipperNameInput.Text = dgvShippers.CurrentRow.Cells[1].Value.ToString();
            shipperPhoneInput.Text = dgvShippers.CurrentRow.Cells[2].Value.ToString();
        }

        private void ClearInputForm()
        {
            shipperIdInput.Clear();
            shipperNameInput.Clear();
            shipperPhoneInput.Clear();

            shipperNameInput.Focus();
        }

        private void clearFormBtn_Click(object sender, EventArgs e)
        {
            ClearInputForm();
        }

        private void insertBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(shipperNameInput.Text))
            {
                MessageBox.Show("Please fill company name fields");
                return;
            }

            string sql = "INSERT INTO Shippers (CompanyName, Phone) VALUES (@CompanyName, @Phone)";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@CompanyName", shipperNameInput.Text.Trim());
            cmd.Parameters.AddWithValue("@Phone", shipperPhoneInput.Text.Trim());
            int result = cmd.ExecuteNonQuery();
            if (result > 0)
            {
                MessageBox.Show("Data has been saved");
                ShowData();
                ClearInputForm();
            }
            else
            {
                MessageBox.Show("Data failed to save");
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(shipperIdInput.Text))
            {
                MessageBox.Show("Please select data to update");
                return;
            }
            else if (string.IsNullOrEmpty(shipperNameInput.Text))
            {
                MessageBox.Show("Please fill company name fields");
                return;
            }

            string sql = "UPDATE Shippers SET CompanyName = @CompanyName, Phone = @Phone WHERE ShipperID = @ShipperID";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@CompanyName", shipperNameInput.Text.Trim());
            cmd.Parameters.AddWithValue("@Phone", shipperPhoneInput.Text.Trim());
            cmd.Parameters.AddWithValue("@ShipperID", shipperIdInput.Text);
            int result = cmd.ExecuteNonQuery();
            if (result > 0)
            {
                MessageBox.Show("Data has been updated");
                ShowData();
                ClearInputForm();
            }
            else
            {
                MessageBox.Show("Data failed to update");
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to delete this data?", "Confirm Delete", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }

            if (string.IsNullOrEmpty(shipperIdInput.Text))
            {
                MessageBox.Show("Please select data to delete");
                return;
            }

            string sql = "DELETE FROM Shippers WHERE ShipperID = @ShipperID";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@ShipperID", shipperIdInput.Text);
            try
            {
                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Data has been deleted");
                    ShowData();
                    ClearInputForm();
                }
                else
                {
                    MessageBox.Show("Data failed to delete");
                }
            } catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
