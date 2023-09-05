namespace Simple_Unit_Test
{
    partial class frmUnitTesting
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
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            btnClear = new Button();
            btnSubmit = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            label3 = new Label();
            label5 = new Label();
            txbFirstName = new TextBox();
            txbLastName = new TextBox();
            txbEmailAddress = new TextBox();
            txbPhoneNumber = new TextBox();
            txbNationality = new TextBox();
            label6 = new Label();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 2);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Controls.Add(label6, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.Size = new Size(533, 452);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(btnClear, 0, 0);
            tableLayoutPanel3.Controls.Add(btnSubmit, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 386);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(527, 63);
            tableLayoutPanel3.TabIndex = 2;
            // 
            // btnClear
            // 
            btnClear.Dock = DockStyle.Fill;
            btnClear.Location = new Point(3, 3);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(257, 57);
            btnClear.TabIndex = 10;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnSubmit
            // 
            btnSubmit.Dock = DockStyle.Fill;
            btnSubmit.Location = new Point(266, 3);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(258, 57);
            btnSubmit.TabIndex = 9;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Controls.Add(label2, 0, 1);
            tableLayoutPanel2.Controls.Add(label4, 0, 2);
            tableLayoutPanel2.Controls.Add(label3, 0, 3);
            tableLayoutPanel2.Controls.Add(label5, 0, 4);
            tableLayoutPanel2.Controls.Add(txbFirstName, 1, 0);
            tableLayoutPanel2.Controls.Add(txbLastName, 1, 1);
            tableLayoutPanel2.Controls.Add(txbEmailAddress, 1, 2);
            tableLayoutPanel2.Controls.Add(txbPhoneNumber, 1, 3);
            tableLayoutPanel2.Controls.Add(txbNationality, 1, 4);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 70);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 5;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.Size = new Size(527, 310);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(152, 62);
            label1.TabIndex = 11;
            label1.Text = "First Name:";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(3, 62);
            label2.Name = "label2";
            label2.Size = new Size(152, 62);
            label2.TabIndex = 12;
            label2.Text = "Last Name:";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Location = new Point(3, 124);
            label4.Name = "label4";
            label4.Size = new Size(152, 62);
            label4.TabIndex = 14;
            label4.Text = "Email Address:";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(3, 186);
            label3.Name = "label3";
            label3.Size = new Size(152, 62);
            label3.TabIndex = 13;
            label3.Text = "Phone Number:";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Fill;
            label5.Location = new Point(3, 248);
            label5.Name = "label5";
            label5.Size = new Size(152, 62);
            label5.TabIndex = 15;
            label5.Text = "Nationality:";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // txbFirstName
            // 
            txbFirstName.Dock = DockStyle.Fill;
            txbFirstName.Location = new Point(161, 3);
            txbFirstName.Multiline = true;
            txbFirstName.Name = "txbFirstName";
            txbFirstName.Size = new Size(363, 56);
            txbFirstName.TabIndex = 10;
            // 
            // txbLastName
            // 
            txbLastName.Dock = DockStyle.Fill;
            txbLastName.Location = new Point(161, 65);
            txbLastName.Multiline = true;
            txbLastName.Name = "txbLastName";
            txbLastName.Size = new Size(363, 56);
            txbLastName.TabIndex = 16;
            // 
            // txbEmailAddress
            // 
            txbEmailAddress.Dock = DockStyle.Fill;
            txbEmailAddress.Location = new Point(161, 127);
            txbEmailAddress.Multiline = true;
            txbEmailAddress.Name = "txbEmailAddress";
            txbEmailAddress.Size = new Size(363, 56);
            txbEmailAddress.TabIndex = 17;
            // 
            // txbPhoneNumber
            // 
            txbPhoneNumber.Dock = DockStyle.Fill;
            txbPhoneNumber.Location = new Point(161, 189);
            txbPhoneNumber.Multiline = true;
            txbPhoneNumber.Name = "txbPhoneNumber";
            txbPhoneNumber.Size = new Size(363, 56);
            txbPhoneNumber.TabIndex = 18;
            // 
            // txbNationality
            // 
            txbNationality.Dock = DockStyle.Fill;
            txbNationality.Location = new Point(161, 251);
            txbNationality.Multiline = true;
            txbNationality.Name = "txbNationality";
            txbNationality.Size = new Size(363, 56);
            txbNationality.TabIndex = 19;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Fill;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(3, 0);
            label6.Name = "label6";
            label6.Size = new Size(527, 67);
            label6.TabIndex = 3;
            label6.Text = "Personal Details Form";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmUnitTesting
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(533, 452);
            Controls.Add(tableLayoutPanel1);
            Name = "frmUnitTesting";
            Text = "Unit Testing";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label3;
        private Label label5;
        private TextBox txbFirstName;
        private TextBox txbLastName;
        private TextBox txbEmailAddress;
        private TextBox txbPhoneNumber;
        private TextBox txbNationality;
        private TableLayoutPanel tableLayoutPanel3;
        private Button btnSubmit;
        private Button btnClear;
        private Label label6;
    }
}