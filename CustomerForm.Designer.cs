namespace Schedulingproject
{
    partial class CustomerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            AddCustomerTextTitle = new Label();
            FullnameTextBoxAdd = new TextBox();
            CustomerAddressTextBoxAdd = new TextBox();
            PhoneNumberTextBoxAdd = new TextBox();
            CustomerAddButton = new Button();
            DeleteCustomerTextTitle = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            FullnameTextBoxDel = new TextBox();
            CustomerAddressTextBoxDel = new TextBox();
            PhoneNumberTextBoxDel = new TextBox();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            FullnameTextBoxUpd = new TextBox();
            CustomerAddressTextBoxUpd = new TextBox();
            CustomerDeleteButton = new Button();
            CustomerUpdateButton = new Button();
            PhoneNumberTextBoxUpd = new TextBox();
            label12 = new Label();
            linkLabel1 = new LinkLabel();
            linkLabel2 = new LinkLabel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(130, 70);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 0;
            label1.Text = "Fullname";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(130, 122);
            label2.Name = "label2";
            label2.Size = new Size(95, 20);
            label2.TabIndex = 1;
            label2.Text = "Your Address";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(130, 170);
            label3.Name = "label3";
            label3.Size = new Size(77, 20);
            label3.TabIndex = 2;
            label3.Text = "Phone No.";
            // 
            // AddCustomerTextTitle
            // 
            AddCustomerTextTitle.AutoSize = true;
            AddCustomerTextTitle.Font = new Font("Verdana", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddCustomerTextTitle.Location = new Point(239, 19);
            AddCustomerTextTitle.Name = "AddCustomerTextTitle";
            AddCustomerTextTitle.Size = new Size(239, 34);
            AddCustomerTextTitle.TabIndex = 3;
            AddCustomerTextTitle.Text = "Add Customer";
            AddCustomerTextTitle.TextAlign = ContentAlignment.TopCenter;
            AddCustomerTextTitle.Click += label4_Click;
            // 
            // FullnameTextBoxAdd
            // 
            FullnameTextBoxAdd.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            FullnameTextBoxAdd.Location = new Point(239, 67);
            FullnameTextBoxAdd.Name = "FullnameTextBoxAdd";
            FullnameTextBoxAdd.Size = new Size(358, 27);
            FullnameTextBoxAdd.TabIndex = 4;
            // 
            // CustomerAddressTextBoxAdd
            // 
            CustomerAddressTextBoxAdd.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CustomerAddressTextBoxAdd.Location = new Point(239, 119);
            CustomerAddressTextBoxAdd.Name = "CustomerAddressTextBoxAdd";
            CustomerAddressTextBoxAdd.Size = new Size(358, 27);
            CustomerAddressTextBoxAdd.TabIndex = 5;
            // 
            // PhoneNumberTextBoxAdd
            // 
            PhoneNumberTextBoxAdd.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PhoneNumberTextBoxAdd.Location = new Point(239, 167);
            PhoneNumberTextBoxAdd.Name = "PhoneNumberTextBoxAdd";
            PhoneNumberTextBoxAdd.Size = new Size(358, 27);
            PhoneNumberTextBoxAdd.TabIndex = 6;
            // 
            // CustomerAddButton
            // 
            CustomerAddButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CustomerAddButton.BackColor = SystemColors.MenuHighlight;
            CustomerAddButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CustomerAddButton.ForeColor = SystemColors.ControlLightLight;
            CustomerAddButton.Location = new Point(239, 213);
            CustomerAddButton.Name = "CustomerAddButton";
            CustomerAddButton.Size = new Size(129, 37);
            CustomerAddButton.TabIndex = 7;
            CustomerAddButton.Text = "Add";
            CustomerAddButton.UseVisualStyleBackColor = false;
            // 
            // DeleteCustomerTextTitle
            // 
            DeleteCustomerTextTitle.AutoSize = true;
            DeleteCustomerTextTitle.Font = new Font("Verdana", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DeleteCustomerTextTitle.Location = new Point(239, 280);
            DeleteCustomerTextTitle.Name = "DeleteCustomerTextTitle";
            DeleteCustomerTextTitle.Size = new Size(280, 34);
            DeleteCustomerTextTitle.TabIndex = 8;
            DeleteCustomerTextTitle.Text = "Delete Customer";
            DeleteCustomerTextTitle.TextAlign = ContentAlignment.TopCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(133, 330);
            label6.Name = "label6";
            label6.Size = new Size(69, 20);
            label6.TabIndex = 9;
            label6.Text = "Fullname";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(133, 375);
            label7.Name = "label7";
            label7.Size = new Size(95, 20);
            label7.TabIndex = 10;
            label7.Text = "Your Address";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(133, 428);
            label8.Name = "label8";
            label8.Size = new Size(74, 20);
            label8.TabIndex = 11;
            label8.Text = "Phone No";
            // 
            // FullnameTextBoxDel
            // 
            FullnameTextBoxDel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            FullnameTextBoxDel.Location = new Point(249, 327);
            FullnameTextBoxDel.Name = "FullnameTextBoxDel";
            FullnameTextBoxDel.Size = new Size(348, 27);
            FullnameTextBoxDel.TabIndex = 12;
            // 
            // CustomerAddressTextBoxDel
            // 
            CustomerAddressTextBoxDel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CustomerAddressTextBoxDel.Location = new Point(249, 375);
            CustomerAddressTextBoxDel.Name = "CustomerAddressTextBoxDel";
            CustomerAddressTextBoxDel.Size = new Size(348, 27);
            CustomerAddressTextBoxDel.TabIndex = 13;
            // 
            // PhoneNumberTextBoxDel
            // 
            PhoneNumberTextBoxDel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PhoneNumberTextBoxDel.Location = new Point(249, 428);
            PhoneNumberTextBoxDel.Name = "PhoneNumberTextBoxDel";
            PhoneNumberTextBoxDel.Size = new Size(348, 27);
            PhoneNumberTextBoxDel.TabIndex = 14;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Verdana", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(239, 537);
            label9.Name = "label9";
            label9.Size = new Size(288, 34);
            label9.TabIndex = 15;
            label9.Text = "update Customer";
            label9.TextAlign = ContentAlignment.TopCenter;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(133, 627);
            label10.Name = "label10";
            label10.Size = new Size(95, 20);
            label10.TabIndex = 16;
            label10.Text = "Your Address";
            label10.Click += label10_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(133, 671);
            label11.Name = "label11";
            label11.Size = new Size(74, 20);
            label11.TabIndex = 17;
            label11.Text = "Phone No";
            label11.Click += label11_Click;
            // 
            // FullnameTextBoxUpd
            // 
            FullnameTextBoxUpd.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            FullnameTextBoxUpd.Location = new Point(239, 584);
            FullnameTextBoxUpd.Name = "FullnameTextBoxUpd";
            FullnameTextBoxUpd.Size = new Size(369, 27);
            FullnameTextBoxUpd.TabIndex = 18;
            // 
            // CustomerAddressTextBoxUpd
            // 
            CustomerAddressTextBoxUpd.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CustomerAddressTextBoxUpd.Location = new Point(239, 627);
            CustomerAddressTextBoxUpd.Name = "CustomerAddressTextBoxUpd";
            CustomerAddressTextBoxUpd.Size = new Size(369, 27);
            CustomerAddressTextBoxUpd.TabIndex = 19;
            // 
            // CustomerDeleteButton
            // 
            CustomerDeleteButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CustomerDeleteButton.BackColor = SystemColors.MenuHighlight;
            CustomerDeleteButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CustomerDeleteButton.ForeColor = SystemColors.ControlLightLight;
            CustomerDeleteButton.Location = new Point(249, 471);
            CustomerDeleteButton.Name = "CustomerDeleteButton";
            CustomerDeleteButton.Size = new Size(119, 37);
            CustomerDeleteButton.TabIndex = 20;
            CustomerDeleteButton.Text = "Delete";
            CustomerDeleteButton.UseVisualStyleBackColor = false;
            // 
            // CustomerUpdateButton
            // 
            CustomerUpdateButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CustomerUpdateButton.BackColor = SystemColors.MenuHighlight;
            CustomerUpdateButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CustomerUpdateButton.ForeColor = SystemColors.ControlLightLight;
            CustomerUpdateButton.Location = new Point(239, 708);
            CustomerUpdateButton.Name = "CustomerUpdateButton";
            CustomerUpdateButton.Size = new Size(129, 37);
            CustomerUpdateButton.TabIndex = 21;
            CustomerUpdateButton.Text = "Update";
            CustomerUpdateButton.UseVisualStyleBackColor = false;
            // 
            // PhoneNumberTextBoxUpd
            // 
            PhoneNumberTextBoxUpd.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PhoneNumberTextBoxUpd.Location = new Point(239, 664);
            PhoneNumberTextBoxUpd.Name = "PhoneNumberTextBoxUpd";
            PhoneNumberTextBoxUpd.Size = new Size(369, 27);
            PhoneNumberTextBoxUpd.TabIndex = 22;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(130, 584);
            label12.Name = "label12";
            label12.Size = new Size(69, 20);
            label12.TabIndex = 23;
            label12.Text = "Fullname";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(623, 765);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(59, 20);
            linkLabel1.TabIndex = 24;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "go next";
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Location = new Point(511, 765);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(59, 20);
            linkLabel2.TabIndex = 25;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "go next";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // CustomerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(859, 828);
            Controls.Add(linkLabel2);
            Controls.Add(linkLabel1);
            Controls.Add(label12);
            Controls.Add(PhoneNumberTextBoxUpd);
            Controls.Add(CustomerUpdateButton);
            Controls.Add(CustomerDeleteButton);
            Controls.Add(CustomerAddressTextBoxUpd);
            Controls.Add(FullnameTextBoxUpd);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(PhoneNumberTextBoxDel);
            Controls.Add(CustomerAddressTextBoxDel);
            Controls.Add(FullnameTextBoxDel);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(DeleteCustomerTextTitle);
            Controls.Add(CustomerAddButton);
            Controls.Add(PhoneNumberTextBoxAdd);
            Controls.Add(CustomerAddressTextBoxAdd);
            Controls.Add(FullnameTextBoxAdd);
            Controls.Add(AddCustomerTextTitle);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CustomerForm";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label AddCustomerTextTitle;
        private TextBox FullnameTextBoxAdd;
        private TextBox CustomerAddressTextBoxAdd;
        private TextBox PhoneNumberTextBoxAdd;
        private Button CustomerAddButton;
        private Label DeleteCustomerTextTitle;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox FullnameTextBoxDel;
        private TextBox CustomerAddressTextBoxDel;
        private TextBox PhoneNumberTextBoxDel;
        private Label label9;
        private Label label10;
        private Label label11;
        private TextBox FullnameTextBoxUpd;
        private TextBox CustomerAddressTextBoxUpd;
        private Button CustomerDeleteButton;
        private Button CustomerUpdateButton;
        private TextBox PhoneNumberTextBoxUpd;
        private Label label12;
        private LinkLabel linkLabel1;
        private LinkLabel linkLabel2;
    }
}