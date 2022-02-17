namespace Module_3_Final_Project
{
    partial class CustomerManagment
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
            this.customerphone = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.customeraddress = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.customername = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.customerdatagrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.homecustomer = new System.Windows.Forms.Button();
            this.updatecustomer = new System.Windows.Forms.Button();
            this.deletecustomer = new System.Windows.Forms.Button();
            this.addcustomer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.customerdatagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkOrange;
            this.label2.Location = new System.Drawing.Point(316, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(357, 38);
            this.label2.TabIndex = 11;
            this.label2.Text = "Customer Managment";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(262, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(476, 38);
            this.label1.TabIndex = 10;
            this.label1.Text = "Inventory Managment System";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // customerphone
            // 
            this.customerphone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.customerphone.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerphone.ForeColor = System.Drawing.Color.DarkOrange;
            this.customerphone.HintForeColor = System.Drawing.Color.Empty;
            this.customerphone.HintText = "";
            this.customerphone.isPassword = false;
            this.customerphone.LineFocusedColor = System.Drawing.Color.White;
            this.customerphone.LineIdleColor = System.Drawing.Color.Gray;
            this.customerphone.LineMouseHoverColor = System.Drawing.Color.White;
            this.customerphone.LineThickness = 3;
            this.customerphone.Location = new System.Drawing.Point(14, 321);
            this.customerphone.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.customerphone.Name = "customerphone";
            this.customerphone.Size = new System.Drawing.Size(296, 48);
            this.customerphone.TabIndex = 21;
            this.customerphone.Text = "Phone No";
            this.customerphone.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.customerphone.OnValueChanged += new System.EventHandler(this.customerphone_OnValueChanged);
            // 
            // customeraddress
            // 
            this.customeraddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.customeraddress.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customeraddress.ForeColor = System.Drawing.Color.DarkOrange;
            this.customeraddress.HintForeColor = System.Drawing.Color.Empty;
            this.customeraddress.HintText = "";
            this.customeraddress.isPassword = false;
            this.customeraddress.LineFocusedColor = System.Drawing.Color.White;
            this.customeraddress.LineIdleColor = System.Drawing.Color.Gray;
            this.customeraddress.LineMouseHoverColor = System.Drawing.Color.White;
            this.customeraddress.LineThickness = 3;
            this.customeraddress.Location = new System.Drawing.Point(14, 240);
            this.customeraddress.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.customeraddress.Name = "customeraddress";
            this.customeraddress.Size = new System.Drawing.Size(296, 48);
            this.customeraddress.TabIndex = 20;
            this.customeraddress.Text = "Address";
            this.customeraddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.customeraddress.OnValueChanged += new System.EventHandler(this.customeraddress_OnValueChanged);
            // 
            // customername
            // 
            this.customername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.customername.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customername.ForeColor = System.Drawing.Color.DarkOrange;
            this.customername.HintForeColor = System.Drawing.Color.Empty;
            this.customername.HintText = "";
            this.customername.isPassword = false;
            this.customername.LineFocusedColor = System.Drawing.Color.White;
            this.customername.LineIdleColor = System.Drawing.Color.Gray;
            this.customername.LineMouseHoverColor = System.Drawing.Color.White;
            this.customername.LineThickness = 3;
            this.customername.Location = new System.Drawing.Point(14, 156);
            this.customername.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.customername.Name = "customername";
            this.customername.Size = new System.Drawing.Size(296, 48);
            this.customername.TabIndex = 19;
            this.customername.Text = " Name";
            this.customername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.customername.OnValueChanged += new System.EventHandler(this.customername_OnValueChanged);
            // 
            // customerdatagrid
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.customerdatagrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.customerdatagrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.customerdatagrid.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.customerdatagrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.customerdatagrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkOrange;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.customerdatagrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.customerdatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerdatagrid.DoubleBuffered = true;
            this.customerdatagrid.EnableHeadersVisualStyles = false;
            this.customerdatagrid.HeaderBgColor = System.Drawing.Color.Black;
            this.customerdatagrid.HeaderForeColor = System.Drawing.Color.DarkOrange;
            this.customerdatagrid.Location = new System.Drawing.Point(380, 137);
            this.customerdatagrid.Name = "customerdatagrid";
            this.customerdatagrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.customerdatagrid.RowTemplate.Height = 24;
            this.customerdatagrid.Size = new System.Drawing.Size(689, 440);
            this.customerdatagrid.TabIndex = 27;
            this.customerdatagrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customerdatagrid_CellContentClick);
            this.customerdatagrid.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.customerdatagrid_RowHeaderMouseClick);
            // 
            // homecustomer
            // 
            this.homecustomer.BackColor = System.Drawing.Color.Black;
            this.homecustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homecustomer.ForeColor = System.Drawing.Color.DarkOrange;
            this.homecustomer.Location = new System.Drawing.Point(97, 509);
            this.homecustomer.Name = "homecustomer";
            this.homecustomer.Size = new System.Drawing.Size(135, 53);
            this.homecustomer.TabIndex = 31;
            this.homecustomer.Text = "Home";
            this.homecustomer.UseVisualStyleBackColor = false;
            this.homecustomer.Click += new System.EventHandler(this.homecustomer_Click);
            // 
            // updatecustomer
            // 
            this.updatecustomer.BackColor = System.Drawing.Color.Black;
            this.updatecustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatecustomer.ForeColor = System.Drawing.Color.DarkOrange;
            this.updatecustomer.Location = new System.Drawing.Point(14, 423);
            this.updatecustomer.Name = "updatecustomer";
            this.updatecustomer.Size = new System.Drawing.Size(135, 53);
            this.updatecustomer.TabIndex = 30;
            this.updatecustomer.Text = "Update";
            this.updatecustomer.UseVisualStyleBackColor = false;
            this.updatecustomer.Visible = false;
            this.updatecustomer.Click += new System.EventHandler(this.updatecustomer_Click);
            // 
            // deletecustomer
            // 
            this.deletecustomer.BackColor = System.Drawing.Color.Black;
            this.deletecustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletecustomer.ForeColor = System.Drawing.Color.DarkOrange;
            this.deletecustomer.Location = new System.Drawing.Point(175, 423);
            this.deletecustomer.Name = "deletecustomer";
            this.deletecustomer.Size = new System.Drawing.Size(135, 53);
            this.deletecustomer.TabIndex = 29;
            this.deletecustomer.Text = "Delete";
            this.deletecustomer.UseVisualStyleBackColor = false;
            this.deletecustomer.Click += new System.EventHandler(this.deletecustomer_Click);
            // 
            // addcustomer
            // 
            this.addcustomer.BackColor = System.Drawing.Color.Black;
            this.addcustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addcustomer.ForeColor = System.Drawing.Color.DarkOrange;
            this.addcustomer.Location = new System.Drawing.Point(12, 423);
            this.addcustomer.Name = "addcustomer";
            this.addcustomer.Size = new System.Drawing.Size(135, 53);
            this.addcustomer.TabIndex = 28;
            this.addcustomer.Text = "Add";
            this.addcustomer.UseVisualStyleBackColor = false;
            this.addcustomer.Click += new System.EventHandler(this.addcustomer_Click);
            // 
            // CustomerManagment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1098, 771);
            this.Controls.Add(this.homecustomer);
            this.Controls.Add(this.updatecustomer);
            this.Controls.Add(this.deletecustomer);
            this.Controls.Add(this.addcustomer);
            this.Controls.Add(this.customerdatagrid);
            this.Controls.Add(this.customerphone);
            this.Controls.Add(this.customeraddress);
            this.Controls.Add(this.customername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerManagment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerManagment";
            this.Load += new System.EventHandler(this.CustomerManagment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customerdatagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox customerphone;
        private Bunifu.Framework.UI.BunifuMaterialTextbox customeraddress;
        private Bunifu.Framework.UI.BunifuMaterialTextbox customername;
        private Bunifu.Framework.UI.BunifuCustomDataGrid customerdatagrid;
        private System.Windows.Forms.Button homecustomer;
        private System.Windows.Forms.Button updatecustomer;
        private System.Windows.Forms.Button deletecustomer;
        private System.Windows.Forms.Button addcustomer;
    }
}