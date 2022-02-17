namespace Module_3_Final_Project
{
    partial class Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtusername = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtpassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.loginbtn = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Label();
            this.shpassword = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOrange;
            this.label1.Location = new System.Drawing.Point(26, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(476, 38);
            this.label1.TabIndex = 5;
            this.label1.Text = "Inventory Managment System";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Module_3_Final_Project.Properties.Resources.Login_icon;
            this.pictureBox1.Location = new System.Drawing.Point(181, 91);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(166, 146);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // txtusername
            // 
            this.txtusername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtusername.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusername.ForeColor = System.Drawing.Color.White;
            this.txtusername.HintForeColor = System.Drawing.Color.Empty;
            this.txtusername.HintText = "";
            this.txtusername.isPassword = false;
            this.txtusername.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtusername.LineIdleColor = System.Drawing.Color.FloralWhite;
            this.txtusername.LineMouseHoverColor = System.Drawing.Color.Snow;
            this.txtusername.LineThickness = 3;
            this.txtusername.Location = new System.Drawing.Point(66, 282);
            this.txtusername.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(444, 48);
            this.txtusername.TabIndex = 7;
            this.txtusername.Text = "UserName";
            this.txtusername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtpassword
            // 
            this.txtpassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtpassword.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassword.ForeColor = System.Drawing.Color.White;
            this.txtpassword.HintForeColor = System.Drawing.Color.Empty;
            this.txtpassword.HintText = "";
            this.txtpassword.isPassword = true;
            this.txtpassword.LineFocusedColor = System.Drawing.Color.WhiteSmoke;
            this.txtpassword.LineIdleColor = System.Drawing.Color.FloralWhite;
            this.txtpassword.LineMouseHoverColor = System.Drawing.Color.Snow;
            this.txtpassword.LineThickness = 3;
            this.txtpassword.Location = new System.Drawing.Point(66, 380);
            this.txtpassword.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(444, 48);
            this.txtpassword.TabIndex = 8;
            this.txtpassword.Text = "Password";
            this.txtpassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // loginbtn
            // 
            this.loginbtn.BackColor = System.Drawing.Color.Black;
            this.loginbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginbtn.ForeColor = System.Drawing.Color.DarkOrange;
            this.loginbtn.Location = new System.Drawing.Point(181, 509);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Size = new System.Drawing.Size(180, 79);
            this.loginbtn.TabIndex = 9;
            this.loginbtn.Text = "Login";
            this.loginbtn.UseVisualStyleBackColor = false;
            this.loginbtn.Click += new System.EventHandler(this.loginbtn_Click);
            // 
            // clear
            // 
            this.clear.AutoSize = true;
            this.clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.ForeColor = System.Drawing.Color.DarkOrange;
            this.clear.Location = new System.Drawing.Point(105, 456);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(76, 29);
            this.clear.TabIndex = 10;
            this.clear.Text = "Clear";
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // shpassword
            // 
            this.shpassword.AutoSize = true;
            this.shpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shpassword.ForeColor = System.Drawing.Color.DarkOrange;
            this.shpassword.Location = new System.Drawing.Point(279, 456);
            this.shpassword.Name = "shpassword";
            this.shpassword.Size = new System.Drawing.Size(222, 33);
            this.shpassword.TabIndex = 11;
            this.shpassword.Text = "Show Password";
            this.shpassword.UseVisualStyleBackColor = true;
            this.shpassword.CheckedChanged += new System.EventHandler(this.shpassword_CheckedChanged);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(559, 618);
            this.Controls.Add(this.shpassword);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.loginbtn);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtusername;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtpassword;
        private System.Windows.Forms.Button loginbtn;
        private System.Windows.Forms.Label clear;
        private System.Windows.Forms.CheckBox shpassword;
    }
}

