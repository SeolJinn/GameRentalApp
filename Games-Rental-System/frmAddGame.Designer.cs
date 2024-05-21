namespace Games_Rental_System
{
    partial class frmAddGame
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.inpGameAmount = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.inpVendorName = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.addButton = new System.Windows.Forms.Button();
            this.pnl_name = new System.Windows.Forms.Panel();
            this.inpGameName = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.inpGamePrice = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pbPhoto = new System.Windows.Forms.PictureBox();
            this.photoButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.Categories = new System.Windows.Forms.ComboBox();
            this.lbltitle = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnl_name.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(55, 427);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "Amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(49, 355);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "Vendor Name";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.inpGameAmount);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Location = new System.Drawing.Point(170, 421);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(211, 46);
            this.panel4.TabIndex = 13;
            // 
            // inpGameAmount
            // 
            this.inpGameAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inpGameAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.inpGameAmount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inpGameAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inpGameAmount.ForeColor = System.Drawing.SystemColors.Window;
            this.inpGameAmount.Location = new System.Drawing.Point(4, 4);
            this.inpGameAmount.Name = "inpGameAmount";
            this.inpGameAmount.Size = new System.Drawing.Size(204, 23);
            this.inpGameAmount.TabIndex = 19;
            this.inpGameAmount.Text = "Enter Game Amount";
            this.inpGameAmount.Click += new System.EventHandler(this.inpGameAmount_Click);
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(4, 33);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(288, 1);
            this.panel5.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(49, 280);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Game Name";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.inpVendorName);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(259, 349);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(491, 46);
            this.panel1.TabIndex = 12;
            // 
            // inpVendorName
            // 
            this.inpVendorName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inpVendorName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.inpVendorName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inpVendorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inpVendorName.ForeColor = System.Drawing.SystemColors.Window;
            this.inpVendorName.Location = new System.Drawing.Point(4, 4);
            this.inpVendorName.Name = "inpVendorName";
            this.inpVendorName.Size = new System.Drawing.Size(484, 23);
            this.inpVendorName.TabIndex = 18;
            this.inpVendorName.Text = "Enter Vendor Name";
            this.inpVendorName.Click += new System.EventHandler(this.inpVendorName_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(4, 33);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(568, 1);
            this.panel3.TabIndex = 2;
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
            this.addButton.Location = new System.Drawing.Point(575, 522);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(174, 58);
            this.addButton.TabIndex = 20;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // pnl_name
            // 
            this.pnl_name.Controls.Add(this.inpGameName);
            this.pnl_name.Controls.Add(this.panel2);
            this.pnl_name.Location = new System.Drawing.Point(259, 274);
            this.pnl_name.Name = "pnl_name";
            this.pnl_name.Size = new System.Drawing.Size(488, 46);
            this.pnl_name.TabIndex = 11;
            // 
            // inpGameName
            // 
            this.inpGameName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inpGameName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.inpGameName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inpGameName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inpGameName.ForeColor = System.Drawing.SystemColors.Window;
            this.inpGameName.Location = new System.Drawing.Point(4, 4);
            this.inpGameName.Name = "inpGameName";
            this.inpGameName.Size = new System.Drawing.Size(481, 23);
            this.inpGameName.TabIndex = 15;
            this.inpGameName.Text = "Enter Game Name";
            this.inpGameName.Click += new System.EventHandler(this.inpGameName_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(4, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(565, 1);
            this.panel2.TabIndex = 2;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.inpGamePrice);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Location = new System.Drawing.Point(563, 421);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(186, 46);
            this.panel6.TabIndex = 14;
            // 
            // inpGamePrice
            // 
            this.inpGamePrice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inpGamePrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.inpGamePrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inpGamePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inpGamePrice.ForeColor = System.Drawing.SystemColors.Window;
            this.inpGamePrice.Location = new System.Drawing.Point(4, 4);
            this.inpGamePrice.Name = "inpGamePrice";
            this.inpGamePrice.Size = new System.Drawing.Size(179, 23);
            this.inpGamePrice.TabIndex = 19;
            this.inpGamePrice.Text = "Enter Game Price";
            this.inpGamePrice.Click += new System.EventHandler(this.inpGamePrice_Click);
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.Location = new System.Drawing.Point(4, 33);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(263, 1);
            this.panel7.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(452, 427);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(55, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 25);
            this.label5.TabIndex = 16;
            this.label5.Text = "Game Photo";
            // 
            // pbPhoto
            // 
            this.pbPhoto.Image = global::Games_Rental_System.Properties.Resources.Logo;
            this.pbPhoto.Location = new System.Drawing.Point(202, 87);
            this.pbPhoto.Name = "pbPhoto";
            this.pbPhoto.Size = new System.Drawing.Size(323, 149);
            this.pbPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPhoto.TabIndex = 18;
            this.pbPhoto.TabStop = false;
            // 
            // photoButton
            // 
            this.photoButton.Location = new System.Drawing.Point(540, 194);
            this.photoButton.Name = "photoButton";
            this.photoButton.Size = new System.Drawing.Size(138, 42);
            this.photoButton.TabIndex = 19;
            this.photoButton.Text = "Choose image";
            this.photoButton.UseVisualStyleBackColor = true;
            this.photoButton.Click += new System.EventHandler(this.photoButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(55, 516);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 25);
            this.label6.TabIndex = 14;
            this.label6.Text = "Category";
            // 
            // Categories
            // 
            this.Categories.AllowDrop = true;
            this.Categories.DropDownHeight = 80;
            this.Categories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Categories.FormattingEnabled = true;
            this.Categories.IntegralHeight = false;
            this.Categories.Items.AddRange(new object[] {
            "Sandbox",
            "Real-time strategy (RTS)",
            "Shooters (FPS and TPS)",
            "Multiplayer online battle arena (MOBA)",
            "Role-playing (RPG, ARPG, and More)",
            "Simulation and sports",
            "Puzzlers and party games",
            "Action-adventure",
            "Survival and horror",
            "Platformer",
            "Funny"});
            this.Categories.Location = new System.Drawing.Point(182, 521);
            this.Categories.Name = "Categories";
            this.Categories.Size = new System.Drawing.Size(266, 23);
            this.Categories.TabIndex = 17;
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbltitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.lbltitle.Location = new System.Drawing.Point(13, 17);
            this.lbltitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(157, 32);
            this.lbltitle.TabIndex = 21;
            this.lbltitle.Text = "Add Game";
            // 
            // frmAddGame
            // 
            this.AcceptButton = this.addButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(920, 636);
            this.Controls.Add(this.lbltitle);
            this.Controls.Add(this.Categories);
            this.Controls.Add(this.photoButton);
            this.Controls.Add(this.pbPhoto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.pnl_name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmAddGame";
            this.Text = "frmAnalytics";
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnl_name.ResumeLayout(false);
            this.pnl_name.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label3;
        private Label label2;
        private Panel panel4;
        private TextBox inpGameAmount;
        private Panel panel5;
        private Label label1;
        private Panel panel1;
        private TextBox inpVendorName;
        private Panel panel3;
        private Button addButton;
        private Panel pnl_name;
        private TextBox inpGameName;
        private Panel panel2;
        private Panel panel6;
        private TextBox inpGamePrice;
        private Panel panel7;
        private Label label4;
        private Label label5;
        private PictureBox pbPhoto;
        private Button photoButton;
        private Label label6;
        private ComboBox Categories;
        private Label lbltitle;
    }
}