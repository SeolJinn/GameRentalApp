namespace Games_Rental_System
{
    partial class frmBrowse
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.cbValue = new System.Windows.Forms.ComboBox();
            this.cbSortby = new System.Windows.Forms.ComboBox();
            this.inpSearch = new System.Windows.Forms.TextBox();
            this.lbltitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 92);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(903, 532);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // cbValue
            // 
            this.cbValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.cbValue.ForeColor = System.Drawing.Color.White;
            this.cbValue.FormattingEnabled = true;
            this.cbValue.Location = new System.Drawing.Point(361, 27);
            this.cbValue.Name = "cbValue";
            this.cbValue.Size = new System.Drawing.Size(170, 23);
            this.cbValue.Sorted = true;
            this.cbValue.TabIndex = 18;
            this.cbValue.SelectedIndexChanged += new System.EventHandler(this.cbValue_SelectedIndexChanged);
            // 
            // cbSortby
            // 
            this.cbSortby.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.cbSortby.ForeColor = System.Drawing.Color.White;
            this.cbSortby.FormattingEnabled = true;
            this.cbSortby.Items.AddRange(new object[] {
            "Year",
            "Vendor",
            "Category"});
            this.cbSortby.Location = new System.Drawing.Point(256, 27);
            this.cbSortby.Name = "cbSortby";
            this.cbSortby.Size = new System.Drawing.Size(83, 23);
            this.cbSortby.TabIndex = 19;
            this.cbSortby.Text = "Sort By";
            this.cbSortby.SelectedIndexChanged += new System.EventHandler(this.cbSortby_SelectedIndexChanged);
            // 
            // inpSearch
            // 
            this.inpSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.inpSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inpSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inpSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.inpSearch.Location = new System.Drawing.Point(556, 24);
            this.inpSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.inpSearch.Multiline = true;
            this.inpSearch.Name = "inpSearch";
            this.inpSearch.Size = new System.Drawing.Size(341, 29);
            this.inpSearch.TabIndex = 17;
            this.inpSearch.Text = "Search for something...\r\n";
            this.inpSearch.Click += new System.EventHandler(this.inpSearch_Click);
            this.inpSearch.TextChanged += new System.EventHandler(this.inpSearch_TextChanged);
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbltitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.lbltitle.Location = new System.Drawing.Point(13, 17);
            this.lbltitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(203, 32);
            this.lbltitle.TabIndex = 16;
            this.lbltitle.Text = "Browse Game";
            // 
            // frmBrowse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(920, 636);
            this.Controls.Add(this.cbValue);
            this.Controls.Add(this.cbSortby);
            this.Controls.Add(this.inpSearch);
            this.Controls.Add(this.lbltitle);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBrowse";
            this.Text = "frmBrowse";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private ComboBox cbValue;
        private ComboBox cbSortby;
        private TextBox inpSearch;
        private Label lbltitle;
    }
}