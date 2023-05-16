namespace DemoProject
{
    partial class LoginPage
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label3 = new System.Windows.Forms.Label();
            this.login_btn = new System.Windows.Forms.Button();
            this.Password_lbl = new System.Windows.Forms.Label();
            this.UserId_lbl = new System.Windows.Forms.Label();
            this.Password_txt = new System.Windows.Forms.TextBox();
            this.UserId_txt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(12, 12);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.login_btn);
            this.splitContainer1.Panel2.Controls.Add(this.Password_lbl);
            this.splitContainer1.Panel2.Controls.Add(this.UserId_lbl);
            this.splitContainer1.Panel2.Controls.Add(this.Password_txt);
            this.splitContainer1.Panel2.Controls.Add(this.UserId_txt);
            this.splitContainer1.Size = new System.Drawing.Size(699, 405);
            this.splitContainer1.SplitterDistance = 233;
            this.splitContainer1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(32, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 32);
            this.label3.TabIndex = 0;
            this.label3.Text = "WELCOME";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // login_btn
            // 
            this.login_btn.AutoEllipsis = true;
            this.login_btn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.login_btn.Font = new System.Drawing.Font("Arial", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_btn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.login_btn.Location = new System.Drawing.Point(318, 227);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(75, 34);
            this.login_btn.TabIndex = 9;
            this.login_btn.Text = "Login";
            this.login_btn.UseVisualStyleBackColor = false;
            this.login_btn.Click += new System.EventHandler(this.login_button_Click);
            // 
            // Password_lbl
            // 
            this.Password_lbl.AutoSize = true;
            this.Password_lbl.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_lbl.Location = new System.Drawing.Point(63, 183);
            this.Password_lbl.Name = "Password_lbl";
            this.Password_lbl.Size = new System.Drawing.Size(74, 17);
            this.Password_lbl.TabIndex = 8;
            this.Password_lbl.Text = "Password";
            // 
            // UserId_lbl
            // 
            this.UserId_lbl.AutoSize = true;
            this.UserId_lbl.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserId_lbl.Location = new System.Drawing.Point(63, 144);
            this.UserId_lbl.Name = "UserId_lbl";
            this.UserId_lbl.Size = new System.Drawing.Size(54, 17);
            this.UserId_lbl.TabIndex = 7;
            this.UserId_lbl.Text = "User Id";
            // 
            // Password_txt
            // 
            this.Password_txt.Location = new System.Drawing.Point(144, 182);
            this.Password_txt.Name = "Password_txt";
            this.Password_txt.Size = new System.Drawing.Size(249, 22);
            this.Password_txt.TabIndex = 6;
            this.Password_txt.TextChanged += new System.EventHandler(this.Password_txt_TextChanged);
            // 
            // UserId_txt
            // 
            this.UserId_txt.Location = new System.Drawing.Point(144, 143);
            this.UserId_txt.Name = "UserId_txt";
            this.UserId_txt.Size = new System.Drawing.Size(249, 22);
            this.UserId_txt.TabIndex = 5;
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 429);
            this.Controls.Add(this.splitContainer1);
            this.Name = "LoginPage";
            this.Text = "LoginPage";
            this.Activated += new System.EventHandler(this.LoginPage_Activated);
            this.Deactivate += new System.EventHandler(this.LoginPage_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginPage_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LoginPage_FormClosed);
            this.Load += new System.EventHandler(this.LoginPage_Load);
            this.Shown += new System.EventHandler(this.LoginPage_Shown);
            this.VisibleChanged += new System.EventHandler(this.LoginPage_VisibleChanged);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.LoginPage_Paint);
            this.Move += new System.EventHandler(this.LoginPage_Move);
            this.StyleChanged += new System.EventHandler(this.LoginPage_StyleChanged);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.Label Password_lbl;
        private System.Windows.Forms.Label UserId_lbl;
        private System.Windows.Forms.TextBox Password_txt;
        private System.Windows.Forms.TextBox UserId_txt;
        private System.Windows.Forms.Label label3;
    }
}

