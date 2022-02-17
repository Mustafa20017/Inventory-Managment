namespace Module_3_Final_Project
{
    partial class CategoryManagment
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.categorytextbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.categorydatagridview = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.homeuser = new System.Windows.Forms.Button();
            this.updatecategory = new System.Windows.Forms.Button();
            this.deletecategory = new System.Windows.Forms.Button();
            this.addcategory = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.categorydatagridview)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkOrange;
            this.label2.Location = new System.Drawing.Point(368, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(348, 38);
            this.label2.TabIndex = 14;
            this.label2.Text = "Category Managment";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(301, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(476, 38);
            this.label1.TabIndex = 13;
            this.label1.Text = "Inventory Managment System";
            // 
            // categorytextbox
            // 
            this.categorytextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.categorytextbox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categorytextbox.ForeColor = System.Drawing.Color.DarkOrange;
            this.categorytextbox.HintForeColor = System.Drawing.Color.Empty;
            this.categorytextbox.HintText = "";
            this.categorytextbox.isPassword = false;
            this.categorytextbox.LineFocusedColor = System.Drawing.Color.White;
            this.categorytextbox.LineIdleColor = System.Drawing.Color.Gray;
            this.categorytextbox.LineMouseHoverColor = System.Drawing.Color.White;
            this.categorytextbox.LineThickness = 3;
            this.categorytextbox.Location = new System.Drawing.Point(14, 204);
            this.categorytextbox.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.categorytextbox.Name = "categorytextbox";
            this.categorytextbox.Size = new System.Drawing.Size(296, 48);
            this.categorytextbox.TabIndex = 21;
            this.categorytextbox.Text = "Category Name";
            this.categorytextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // categorydatagridview
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.categorydatagridview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.categorydatagridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.categorydatagridview.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.categorydatagridview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.categorydatagridview.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.categorydatagridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.categorydatagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.categorydatagridview.DoubleBuffered = true;
            this.categorydatagridview.EnableHeadersVisualStyles = false;
            this.categorydatagridview.HeaderBgColor = System.Drawing.Color.Black;
            this.categorydatagridview.HeaderForeColor = System.Drawing.Color.DarkOrange;
            this.categorydatagridview.Location = new System.Drawing.Point(389, 155);
            this.categorydatagridview.Name = "categorydatagridview";
            this.categorydatagridview.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.categorydatagridview.RowTemplate.Height = 24;
            this.categorydatagridview.Size = new System.Drawing.Size(595, 327);
            this.categorydatagridview.TabIndex = 23;
            this.categorydatagridview.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.categorydatagridview_RowHeaderMouseClick);
            // 
            // homeuser
            // 
            this.homeuser.BackColor = System.Drawing.Color.Black;
            this.homeuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeuser.ForeColor = System.Drawing.Color.DarkOrange;
            this.homeuser.Location = new System.Drawing.Point(107, 380);
            this.homeuser.Name = "homeuser";
            this.homeuser.Size = new System.Drawing.Size(135, 53);
            this.homeuser.TabIndex = 31;
            this.homeuser.Text = "Home";
            this.homeuser.UseVisualStyleBackColor = false;
            this.homeuser.Click += new System.EventHandler(this.homeuser_Click);
            // 
            // updatecategory
            // 
            this.updatecategory.BackColor = System.Drawing.Color.Black;
            this.updatecategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatecategory.ForeColor = System.Drawing.Color.DarkOrange;
            this.updatecategory.Location = new System.Drawing.Point(12, 309);
            this.updatecategory.Name = "updatecategory";
            this.updatecategory.Size = new System.Drawing.Size(135, 53);
            this.updatecategory.TabIndex = 30;
            this.updatecategory.Text = "Update";
            this.updatecategory.UseVisualStyleBackColor = false;
            this.updatecategory.Visible = false;
            this.updatecategory.Click += new System.EventHandler(this.updatecategory_Click);
            // 
            // deletecategory
            // 
            this.deletecategory.BackColor = System.Drawing.Color.Black;
            this.deletecategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletecategory.ForeColor = System.Drawing.Color.DarkOrange;
            this.deletecategory.Location = new System.Drawing.Point(177, 309);
            this.deletecategory.Name = "deletecategory";
            this.deletecategory.Size = new System.Drawing.Size(135, 53);
            this.deletecategory.TabIndex = 29;
            this.deletecategory.Text = "Delete";
            this.deletecategory.UseVisualStyleBackColor = false;
            this.deletecategory.Visible = false;
            this.deletecategory.Click += new System.EventHandler(this.deletecategory_Click);
            // 
            // addcategory
            // 
            this.addcategory.BackColor = System.Drawing.Color.Black;
            this.addcategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addcategory.ForeColor = System.Drawing.Color.DarkOrange;
            this.addcategory.Location = new System.Drawing.Point(14, 309);
            this.addcategory.Name = "addcategory";
            this.addcategory.Size = new System.Drawing.Size(135, 53);
            this.addcategory.TabIndex = 28;
            this.addcategory.Text = "Add";
            this.addcategory.UseVisualStyleBackColor = false;
            this.addcategory.Click += new System.EventHandler(this.addcategory_Click);
            // 
            // CategoryManagment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1012, 593);
            this.Controls.Add(this.homeuser);
            this.Controls.Add(this.updatecategory);
            this.Controls.Add(this.deletecategory);
            this.Controls.Add(this.addcategory);
            this.Controls.Add(this.categorydatagridview);
            this.Controls.Add(this.categorytextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CategoryManagment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CategoryManagment";
            this.Load += new System.EventHandler(this.CategoryManagment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.categorydatagridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox categorytextbox;
        private Bunifu.Framework.UI.BunifuCustomDataGrid categorydatagridview;
        private System.Windows.Forms.Button homeuser;
        private System.Windows.Forms.Button updatecategory;
        private System.Windows.Forms.Button deletecategory;
        private System.Windows.Forms.Button addcategory;
    }
}