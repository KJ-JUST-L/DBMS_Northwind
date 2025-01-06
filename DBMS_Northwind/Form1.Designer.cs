namespace DBMS_Northwind
{
    partial class DBMS_NorthwindForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvShippers = new DataGridView();
            shipperIdLabel = new Label();
            shipperName = new Label();
            shipperPhone = new Label();
            shipperIdInput = new TextBox();
            shipperNameInput = new TextBox();
            shipperPhoneInput = new TextBox();
            insertBtn = new Button();
            updateBtn = new Button();
            deleteBtn = new Button();
            clearFormBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvShippers).BeginInit();
            SuspendLayout();
            // 
            // dgvShippers
            // 
            dgvShippers.AllowUserToAddRows = false;
            dgvShippers.AllowUserToDeleteRows = false;
            dgvShippers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvShippers.Location = new Point(12, 12);
            dgvShippers.Name = "dgvShippers";
            dgvShippers.ReadOnly = true;
            dgvShippers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvShippers.Size = new Size(1216, 228);
            dgvShippers.TabIndex = 0;
            dgvShippers.CellMouseUp += dgvShippers_CellMouseUp;
            // 
            // shipperIdLabel
            // 
            shipperIdLabel.AutoSize = true;
            shipperIdLabel.Location = new Point(17, 267);
            shipperIdLabel.Name = "shipperIdLabel";
            shipperIdLabel.Size = new Size(58, 15);
            shipperIdLabel.TabIndex = 1;
            shipperIdLabel.Text = "ShipperID";
            // 
            // shipperName
            // 
            shipperName.AutoSize = true;
            shipperName.Location = new Point(17, 315);
            shipperName.Name = "shipperName";
            shipperName.Size = new Size(94, 15);
            shipperName.TabIndex = 2;
            shipperName.Text = "Company Name";
            // 
            // shipperPhone
            // 
            shipperPhone.AutoSize = true;
            shipperPhone.Location = new Point(17, 359);
            shipperPhone.Name = "shipperPhone";
            shipperPhone.Size = new Size(41, 15);
            shipperPhone.TabIndex = 3;
            shipperPhone.Text = "Phone";
            // 
            // shipperIdInput
            // 
            shipperIdInput.Location = new Point(130, 267);
            shipperIdInput.Name = "shipperIdInput";
            shipperIdInput.ReadOnly = true;
            shipperIdInput.Size = new Size(157, 23);
            shipperIdInput.TabIndex = 4;
            // 
            // shipperNameInput
            // 
            shipperNameInput.Location = new Point(130, 312);
            shipperNameInput.MaxLength = 40;
            shipperNameInput.Name = "shipperNameInput";
            shipperNameInput.Size = new Size(241, 23);
            shipperNameInput.TabIndex = 5;
            // 
            // shipperPhoneInput
            // 
            shipperPhoneInput.Location = new Point(130, 356);
            shipperPhoneInput.MaxLength = 10;
            shipperPhoneInput.Name = "shipperPhoneInput";
            shipperPhoneInput.Size = new Size(133, 23);
            shipperPhoneInput.TabIndex = 6;
            // 
            // insertBtn
            // 
            insertBtn.BackColor = Color.FromArgb(128, 255, 128);
            insertBtn.Location = new Point(17, 403);
            insertBtn.Name = "insertBtn";
            insertBtn.Size = new Size(84, 35);
            insertBtn.TabIndex = 7;
            insertBtn.Text = "Insert";
            insertBtn.UseVisualStyleBackColor = false;
            insertBtn.Click += insertBtn_Click;
            // 
            // updateBtn
            // 
            updateBtn.BackColor = Color.FromArgb(255, 255, 128);
            updateBtn.Location = new Point(107, 403);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(75, 35);
            updateBtn.TabIndex = 8;
            updateBtn.Text = "Update";
            updateBtn.UseVisualStyleBackColor = false;
            updateBtn.Click += updateBtn_Click;
            // 
            // deleteBtn
            // 
            deleteBtn.BackColor = Color.FromArgb(255, 128, 128);
            deleteBtn.Location = new Point(188, 403);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(75, 35);
            deleteBtn.TabIndex = 9;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = false;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // clearFormBtn
            // 
            clearFormBtn.BackColor = Color.FromArgb(224, 224, 224);
            clearFormBtn.Location = new Point(269, 403);
            clearFormBtn.Name = "clearFormBtn";
            clearFormBtn.Size = new Size(78, 35);
            clearFormBtn.TabIndex = 10;
            clearFormBtn.Text = "Clear Form";
            clearFormBtn.UseVisualStyleBackColor = false;
            clearFormBtn.Click += clearFormBtn_Click;
            // 
            // DBMS_NorthwindForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1240, 450);
            Controls.Add(clearFormBtn);
            Controls.Add(deleteBtn);
            Controls.Add(updateBtn);
            Controls.Add(insertBtn);
            Controls.Add(shipperPhoneInput);
            Controls.Add(shipperNameInput);
            Controls.Add(shipperIdInput);
            Controls.Add(shipperPhone);
            Controls.Add(shipperName);
            Controls.Add(shipperIdLabel);
            Controls.Add(dgvShippers);
            Name = "DBMS_NorthwindForm";
            Text = "Shipper Management System";
            Load += DBMS_NorthwindForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvShippers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvShippers;
        private Label shipperIdLabel;
        private Label shipperName;
        private Label shipperPhone;
        private TextBox shipperIdInput;
        private TextBox shipperNameInput;
        private TextBox shipperPhoneInput;
        private Button insertBtn;
        private Button updateBtn;
        private Button deleteBtn;
        private Button clearFormBtn;
    }
}
