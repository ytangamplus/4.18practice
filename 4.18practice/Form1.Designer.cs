
namespace _4._18practice
{
    partial class Form1
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
            this.txtboxDisp = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cmbItems = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtboxDisp
            // 
            this.txtboxDisp.Location = new System.Drawing.Point(241, 223);
            this.txtboxDisp.Multiline = true;
            this.txtboxDisp.Name = "txtboxDisp";
            this.txtboxDisp.ReadOnly = true;
            this.txtboxDisp.Size = new System.Drawing.Size(320, 66);
            this.txtboxDisp.TabIndex = 4;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(268, 149);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(228, 59);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cmbItems
            // 
            this.cmbItems.FormattingEnabled = true;
            this.cmbItems.Items.AddRange(new object[] {
            "Toyota",
            "Honda",
            "Mazda",
            "Nissan"});
            this.cmbItems.Location = new System.Drawing.Point(241, 67);
            this.cmbItems.Name = "cmbItems";
            this.cmbItems.Size = new System.Drawing.Size(320, 33);
            this.cmbItems.TabIndex = 6;
            this.cmbItems.Text = "Select the maker you want to search";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbItems);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtboxDisp);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtboxDisp;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cmbItems;
    }
}

