namespace Games_Rental_System
{
    partial class frmAddClient
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
            this.inpClientPhone = new System.Windows.Forms.TextBox();
            this.pnl_name = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.addButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.inpClientFirstName = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.inpClientSecondName = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.inpCLientPasswordConfirm = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.inpCLientPassword = new System.Windows.Forms.TextBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.inpClientUsername = new System.Windows.Forms.TextBox();
            this.panel11 = new System.Windows.Forms.Panel();
            this.lbltitle = new System.Windows.Forms.Label();
            this.pnl_name.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel10.SuspendLayout();
            this.SuspendLayout();
            // 
            // inpClientPhone
            // 
            this.inpClientPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inpClientPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.inpClientPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inpClientPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inpClientPhone.ForeColor = System.Drawing.SystemColors.Window;
            this.inpClientPhone.Location = new System.Drawing.Point(4, 4);
            this.inpClientPhone.Name = "inpClientPhone";
            this.inpClientPhone.Size = new System.Drawing.Size(246, 23);
            this.inpClientPhone.TabIndex = 15;
            this.inpClientPhone.Text = "Enter Client Phone Number";
            this.inpClientPhone.Click += new System.EventHandler(this.inpClientPhone_Click);
            // 
            // pnl_name
            // 
            this.pnl_name.Controls.Add(this.inpClientPhone);
            this.pnl_name.Controls.Add(this.panel2);
            this.pnl_name.Location = new System.Drawing.Point(602, 238);
            this.pnl_name.Name = "pnl_name";
            this.pnl_name.Size = new System.Drawing.Size(252, 46);
            this.pnl_name.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(4, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(246, 1);
            this.panel2.TabIndex = 2;
            // 
            // addButton
            // 
            this.addButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(184)))), ((int)(((byte)(174)))));
            this.addButton.FlatAppearance.BorderSize = 2;
            this.addButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(250)))), ((int)(((byte)(238)))));
            this.addButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(217)))), ((int)(((byte)(205)))));
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addButton.ForeColor = System.Drawing.Color.White;
            this.addButton.Location = new System.Drawing.Point(344, 508);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(174, 58);
            this.addButton.TabIndex = 10;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(456, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Phone Number";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.inpClientFirstName);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(193, 152);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(221, 46);
            this.panel1.TabIndex = 0;
            // 
            // inpClientFirstName
            // 
            this.inpClientFirstName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inpClientFirstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.inpClientFirstName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inpClientFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inpClientFirstName.ForeColor = System.Drawing.SystemColors.Window;
            this.inpClientFirstName.Location = new System.Drawing.Point(4, 4);
            this.inpClientFirstName.Name = "inpClientFirstName";
            this.inpClientFirstName.Size = new System.Drawing.Size(215, 23);
            this.inpClientFirstName.TabIndex = 18;
            this.inpClientFirstName.Text = "Enter Client First Name";
            this.inpClientFirstName.Click += new System.EventHandler(this.inpClientFirstName_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(4, 33);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(215, 1);
            this.panel3.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(72, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "First Name";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.inpClientSecondName);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Location = new System.Drawing.Point(602, 152);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(252, 46);
            this.panel4.TabIndex = 1;
            // 
            // inpClientSecondName
            // 
            this.inpClientSecondName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inpClientSecondName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.inpClientSecondName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inpClientSecondName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inpClientSecondName.ForeColor = System.Drawing.SystemColors.Window;
            this.inpClientSecondName.Location = new System.Drawing.Point(4, 4);
            this.inpClientSecondName.Name = "inpClientSecondName";
            this.inpClientSecondName.Size = new System.Drawing.Size(246, 23);
            this.inpClientSecondName.TabIndex = 19;
            this.inpClientSecondName.Text = "Enter Client Second Name";
            this.inpClientSecondName.Click += new System.EventHandler(this.inpClientSecondName_Click);
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(4, 33);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(246, 1);
            this.panel5.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(455, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Second Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(74, 405);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Confirm Password";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.inpCLientPasswordConfirm);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Location = new System.Drawing.Point(321, 399);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(383, 46);
            this.panel6.TabIndex = 5;
            // 
            // inpCLientPasswordConfirm
            // 
            this.inpCLientPasswordConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inpCLientPasswordConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.inpCLientPasswordConfirm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inpCLientPasswordConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inpCLientPasswordConfirm.ForeColor = System.Drawing.SystemColors.Window;
            this.inpCLientPasswordConfirm.Location = new System.Drawing.Point(4, 4);
            this.inpCLientPasswordConfirm.Name = "inpCLientPasswordConfirm";
            this.inpCLientPasswordConfirm.Size = new System.Drawing.Size(377, 23);
            this.inpCLientPasswordConfirm.TabIndex = 15;
            this.inpCLientPasswordConfirm.Text = "Enter Client Password";
            this.inpCLientPasswordConfirm.Click += new System.EventHandler(this.inpCLientPasswordConfirm_Click);
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.Location = new System.Drawing.Point(4, 33);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(377, 1);
            this.panel7.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(74, 323);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Password";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.inpCLientPassword);
            this.panel8.Controls.Add(this.panel9);
            this.panel8.Location = new System.Drawing.Point(321, 317);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(385, 46);
            this.panel8.TabIndex = 4;
            // 
            // inpCLientPassword
            // 
            this.inpCLientPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inpCLientPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.inpCLientPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inpCLientPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inpCLientPassword.ForeColor = System.Drawing.SystemColors.Window;
            this.inpCLientPassword.Location = new System.Drawing.Point(4, 4);
            this.inpCLientPassword.Name = "inpCLientPassword";
            this.inpCLientPassword.Size = new System.Drawing.Size(379, 23);
            this.inpCLientPassword.TabIndex = 15;
            this.inpCLientPassword.Text = "Enter Client Password";
            this.inpCLientPassword.Click += new System.EventHandler(this.inpCLientPassword_Click);
            // 
            // panel9
            // 
            this.panel9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel9.BackColor = System.Drawing.Color.White;
            this.panel9.Location = new System.Drawing.Point(4, 33);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(379, 1);
            this.panel9.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(72, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 25);
            this.label6.TabIndex = 3;
            this.label6.Text = "Username";
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.inpClientUsername);
            this.panel10.Controls.Add(this.panel11);
            this.panel10.Location = new System.Drawing.Point(193, 238);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(221, 46);
            this.panel10.TabIndex = 2;
            // 
            // inpClientUsername
            // 
            this.inpClientUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inpClientUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.inpClientUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inpClientUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inpClientUsername.ForeColor = System.Drawing.SystemColors.Window;
            this.inpClientUsername.Location = new System.Drawing.Point(4, 4);
            this.inpClientUsername.Name = "inpClientUsername";
            this.inpClientUsername.Size = new System.Drawing.Size(215, 23);
            this.inpClientUsername.TabIndex = 15;
            this.inpClientUsername.Text = "Enter Client Username";
            this.inpClientUsername.Click += new System.EventHandler(this.inpClientUsername_Click);
            // 
            // panel11
            // 
            this.panel11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel11.BackColor = System.Drawing.Color.White;
            this.panel11.Location = new System.Drawing.Point(4, 33);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(215, 1);
            this.panel11.TabIndex = 2;
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbltitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.lbltitle.Location = new System.Drawing.Point(13, 17);
            this.lbltitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(156, 32);
            this.lbltitle.TabIndex = 11;
            this.lbltitle.Text = "Add Client";
            // 
            // frmAddClient
            // 
            this.AcceptButton = this.addButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(920, 636);
            this.Controls.Add(this.lbltitle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pnl_name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.addButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmAddClient";
            this.Text = "frmContactUs";
            this.Load += new System.EventHandler(this.frmAddClient_Load);
            this.pnl_name.ResumeLayout(false);
            this.pnl_name.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox inpClientPhone;
        private Panel pnl_name;
        private Panel panel2;
        private Button addButton;
        private Label label1;
        private Panel panel1;
        private Panel panel3;
        private TextBox inpClientFirstName;
        private Label label2;
        private Panel panel4;
        private Panel panel5;
        private TextBox inpClientSecondName;
        private Label label3;
        private Label label4;
        private Panel panel6;
        private TextBox inpCLientPasswordConfirm;
        private Panel panel7;
        private Label label5;
        private Panel panel8;
        private TextBox inpCLientPassword;
        private Panel panel9;
        private Label label6;
        private Panel panel10;
        private TextBox inpClientUsername;
        private Panel panel11;
        private Label lbltitle;
    }
}