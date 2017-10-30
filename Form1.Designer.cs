namespace GUIDMaker2
{
    partial class frmGUIDMaker
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.chkWithHyphen = new System.Windows.Forms.CheckBox();
            this.rdo3 = new System.Windows.Forms.RadioButton();
            this.rdo2 = new System.Windows.Forms.RadioButton();
            this.rdo1 = new System.Windows.Forms.RadioButton();
            this.rdoNone = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdoLower = new System.Windows.Forms.RadioButton();
            this.rdoUpper = new System.Windows.Forms.RadioButton();
            this.txtGUID = new System.Windows.Forms.TextBox();
            this.btnMake = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.txtGUID);
            this.groupBox1.Controls.Add(this.btnMake);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(795, 468);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(29, 32);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(739, 262);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Format";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.chkWithHyphen);
            this.groupBox4.Controls.Add(this.rdo3);
            this.groupBox4.Controls.Add(this.rdo2);
            this.groupBox4.Controls.Add(this.rdo1);
            this.groupBox4.Controls.Add(this.rdoNone);
            this.groupBox4.Location = new System.Drawing.Point(40, 128);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(664, 104);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Facing";
            // 
            // chkWithHyphen
            // 
            this.chkWithHyphen.AutoSize = true;
            this.chkWithHyphen.Checked = true;
            this.chkWithHyphen.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkWithHyphen.Location = new System.Drawing.Point(39, 49);
            this.chkWithHyphen.Name = "chkWithHyphen";
            this.chkWithHyphen.Size = new System.Drawing.Size(170, 25);
            this.chkWithHyphen.TabIndex = 3;
            this.chkWithHyphen.Text = "with hyphen \"-\"";
            this.chkWithHyphen.UseVisualStyleBackColor = true;
            this.chkWithHyphen.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // rdo3
            // 
            this.rdo3.AutoSize = true;
            this.rdo3.Location = new System.Drawing.Point(574, 49);
            this.rdo3.Name = "rdo3";
            this.rdo3.Size = new System.Drawing.Size(55, 25);
            this.rdo3.TabIndex = 2;
            this.rdo3.Text = "[]";
            this.rdo3.UseVisualStyleBackColor = true;
            this.rdo3.Click += new System.EventHandler(this.Option_Clicked);
            // 
            // rdo2
            // 
            this.rdo2.AutoSize = true;
            this.rdo2.Location = new System.Drawing.Point(477, 49);
            this.rdo2.Name = "rdo2";
            this.rdo2.Size = new System.Drawing.Size(55, 25);
            this.rdo2.TabIndex = 1;
            this.rdo2.Text = "{}";
            this.rdo2.UseVisualStyleBackColor = true;
            this.rdo2.Click += new System.EventHandler(this.Option_Clicked);
            // 
            // rdo1
            // 
            this.rdo1.AutoSize = true;
            this.rdo1.Location = new System.Drawing.Point(372, 49);
            this.rdo1.Name = "rdo1";
            this.rdo1.Size = new System.Drawing.Size(63, 25);
            this.rdo1.TabIndex = 0;
            this.rdo1.Text = "<>";
            this.rdo1.UseVisualStyleBackColor = true;
            this.rdo1.Click += new System.EventHandler(this.Option_Clicked);
            // 
            // rdoNone
            // 
            this.rdoNone.AutoSize = true;
            this.rdoNone.Checked = true;
            this.rdoNone.Location = new System.Drawing.Point(251, 49);
            this.rdoNone.Name = "rdoNone";
            this.rdoNone.Size = new System.Drawing.Size(79, 25);
            this.rdoNone.TabIndex = 0;
            this.rdoNone.TabStop = true;
            this.rdoNone.Text = "None";
            this.rdoNone.UseVisualStyleBackColor = true;
            this.rdoNone.Click += new System.EventHandler(this.Option_Clicked);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdoLower);
            this.groupBox3.Controls.Add(this.rdoUpper);
            this.groupBox3.Location = new System.Drawing.Point(37, 31);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(667, 77);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Case";
            // 
            // rdoLower
            // 
            this.rdoLower.AutoSize = true;
            this.rdoLower.Checked = true;
            this.rdoLower.Location = new System.Drawing.Point(137, 31);
            this.rdoLower.Name = "rdoLower";
            this.rdoLower.Size = new System.Drawing.Size(138, 25);
            this.rdoLower.TabIndex = 4;
            this.rdoLower.TabStop = true;
            this.rdoLower.Text = "Lower Case";
            this.rdoLower.UseVisualStyleBackColor = true;
            this.rdoLower.Click += new System.EventHandler(this.Option_Clicked);
            // 
            // rdoUpper
            // 
            this.rdoUpper.AutoSize = true;
            this.rdoUpper.Location = new System.Drawing.Point(419, 31);
            this.rdoUpper.Name = "rdoUpper";
            this.rdoUpper.Size = new System.Drawing.Size(137, 25);
            this.rdoUpper.TabIndex = 4;
            this.rdoUpper.Text = "Upper Case";
            this.rdoUpper.UseVisualStyleBackColor = true;
            this.rdoUpper.Click += new System.EventHandler(this.Option_Clicked);
            // 
            // txtGUID
            // 
            this.txtGUID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGUID.Enabled = false;
            this.txtGUID.Location = new System.Drawing.Point(32, 322);
            this.txtGUID.Name = "txtGUID";
            this.txtGUID.Size = new System.Drawing.Size(736, 32);
            this.txtGUID.TabIndex = 1;
            this.txtGUID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnMake
            // 
            this.btnMake.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMake.Location = new System.Drawing.Point(29, 377);
            this.btnMake.Name = "btnMake";
            this.btnMake.Size = new System.Drawing.Size(739, 72);
            this.btnMake.TabIndex = 0;
            this.btnMake.Text = "Make a New GUID And Copy to ClipBoard";
            this.btnMake.UseVisualStyleBackColor = true;
            this.btnMake.Click += new System.EventHandler(this.btnMake_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(646, 493);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(162, 38);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmGUIDMaker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 539);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmGUIDMaker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GUID Maker 2";
            this.TopMost = true;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtGUID;
        private System.Windows.Forms.Button btnMake;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rdo3;
        private System.Windows.Forms.RadioButton rdo2;
        private System.Windows.Forms.RadioButton rdo1;
        private System.Windows.Forms.RadioButton rdoNone;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdoLower;
        private System.Windows.Forms.RadioButton rdoUpper;
        private System.Windows.Forms.CheckBox chkWithHyphen;
    }
}

