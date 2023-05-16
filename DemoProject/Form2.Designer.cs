namespace DemoProject
{
    partial class DataPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataPage));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.Quit_btn = new System.Windows.Forms.Button();
            this.Cancel_btn = new System.Windows.Forms.Button();
            this.Clear_btn = new System.Windows.Forms.Button();
            this.New_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Delete_btn = new System.Windows.Forms.Button();
            this.Edit_btn = new System.Windows.Forms.Button();
            this.Save_btn = new System.Windows.Forms.Button();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.Title_txt = new System.Windows.Forms.TextBox();
            this.Lname_txt = new System.Windows.Forms.TextBox();
            this.Fname_txt = new System.Windows.Forms.TextBox();
            this.Company_txt = new System.Windows.Forms.TextBox();
            this.Title_lbl = new System.Windows.Forms.Label();
            this.Lname_lbl = new System.Windows.Forms.Label();
            this.Fname_lbl = new System.Windows.Forms.Label();
            this.Company_lbl = new System.Windows.Forms.Label();
            this.List_grid = new System.Windows.Forms.DataGridView();
            this.Update_btn = new System.Windows.Forms.Button();
            this.View_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.List_grid)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.splitContainer1.Panel1.Controls.Add(this.View_btn);
            this.splitContainer1.Panel1.Controls.Add(this.Update_btn);
            this.splitContainer1.Panel1.Controls.Add(this.Quit_btn);
            this.splitContainer1.Panel1.Controls.Add(this.Cancel_btn);
            this.splitContainer1.Panel1.Controls.Add(this.Clear_btn);
            this.splitContainer1.Panel1.Controls.Add(this.New_btn);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            this.splitContainer1.Panel1.Controls.Add(this.Delete_btn);
            this.splitContainer1.Panel1.Controls.Add(this.Edit_btn);
            this.splitContainer1.Panel1.Controls.Add(this.Save_btn);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(1006, 502);
            this.splitContainer1.SplitterDistance = 215;
            this.splitContainer1.TabIndex = 0;
            this.splitContainer1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer1_SplitterMoved);
            // 
            // Quit_btn
            // 
            this.Quit_btn.BackColor = System.Drawing.Color.DarkOrange;
            this.Quit_btn.Font = new System.Drawing.Font("Arial", 9.134328F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quit_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Quit_btn.Location = new System.Drawing.Point(57, 426);
            this.Quit_btn.Name = "Quit_btn";
            this.Quit_btn.Size = new System.Drawing.Size(104, 37);
            this.Quit_btn.TabIndex = 8;
            this.Quit_btn.Text = "QUIT";
            this.Quit_btn.UseVisualStyleBackColor = false;
            this.Quit_btn.Click += new System.EventHandler(this.Quit_btn_Click);
            // 
            // Cancel_btn
            // 
            this.Cancel_btn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Cancel_btn.Font = new System.Drawing.Font("Arial", 9.134328F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Cancel_btn.Location = new System.Drawing.Point(57, 383);
            this.Cancel_btn.Name = "Cancel_btn";
            this.Cancel_btn.Size = new System.Drawing.Size(104, 37);
            this.Cancel_btn.TabIndex = 7;
            this.Cancel_btn.Text = "CANCEL";
            this.Cancel_btn.UseVisualStyleBackColor = false;
            this.Cancel_btn.Click += new System.EventHandler(this.Cancle_btn_Click);
            // 
            // Clear_btn
            // 
            this.Clear_btn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Clear_btn.Font = new System.Drawing.Font("Arial", 9.134328F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Clear_btn.Location = new System.Drawing.Point(56, 211);
            this.Clear_btn.Name = "Clear_btn";
            this.Clear_btn.Size = new System.Drawing.Size(104, 37);
            this.Clear_btn.TabIndex = 6;
            this.Clear_btn.Text = "CLEAR";
            this.Clear_btn.UseVisualStyleBackColor = false;
            this.Clear_btn.Click += new System.EventHandler(this.CLEAR_Click);
            // 
            // New_btn
            // 
            this.New_btn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.New_btn.Font = new System.Drawing.Font("Arial", 9.134328F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.New_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.New_btn.Location = new System.Drawing.Point(57, 168);
            this.New_btn.Name = "New_btn";
            this.New_btn.Size = new System.Drawing.Size(104, 37);
            this.New_btn.TabIndex = 5;
            this.New_btn.Text = "NEW";
            this.New_btn.UseVisualStyleBackColor = false;
            this.New_btn.Click += new System.EventHandler(this.New_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(68, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Delete_btn
            // 
            this.Delete_btn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Delete_btn.Font = new System.Drawing.Font("Arial", 9.134328F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Delete_btn.Location = new System.Drawing.Point(56, 340);
            this.Delete_btn.Name = "Delete_btn";
            this.Delete_btn.Size = new System.Drawing.Size(105, 37);
            this.Delete_btn.TabIndex = 3;
            this.Delete_btn.Text = "DELETE";
            this.Delete_btn.UseVisualStyleBackColor = false;
            this.Delete_btn.Click += new System.EventHandler(this.Delete_btn_Click);
            // 
            // Edit_btn
            // 
            this.Edit_btn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Edit_btn.Font = new System.Drawing.Font("Arial", 9.134328F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edit_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Edit_btn.Location = new System.Drawing.Point(56, 297);
            this.Edit_btn.Name = "Edit_btn";
            this.Edit_btn.Size = new System.Drawing.Size(105, 37);
            this.Edit_btn.TabIndex = 0;
            this.Edit_btn.Text = "EDIT";
            this.Edit_btn.UseVisualStyleBackColor = false;
            this.Edit_btn.Click += new System.EventHandler(this.Edit_btn_Click);
            this.Edit_btn.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.Edit_btn_ControlAdded);
            // 
            // Save_btn
            // 
            this.Save_btn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Save_btn.Font = new System.Drawing.Font("Arial", 9.134328F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Save_btn.Location = new System.Drawing.Point(56, 254);
            this.Save_btn.Name = "Save_btn";
            this.Save_btn.Size = new System.Drawing.Size(104, 37);
            this.Save_btn.TabIndex = 1;
            this.Save_btn.Text = "SAVE";
            this.Save_btn.UseVisualStyleBackColor = false;
            this.Save_btn.Click += new System.EventHandler(this.Save_btn_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.splitContainer2.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.Title_txt);
            this.splitContainer2.Panel2.Controls.Add(this.Lname_txt);
            this.splitContainer2.Panel2.Controls.Add(this.Fname_txt);
            this.splitContainer2.Panel2.Controls.Add(this.Company_txt);
            this.splitContainer2.Panel2.Controls.Add(this.Title_lbl);
            this.splitContainer2.Panel2.Controls.Add(this.Lname_lbl);
            this.splitContainer2.Panel2.Controls.Add(this.Fname_lbl);
            this.splitContainer2.Panel2.Controls.Add(this.Company_lbl);
            this.splitContainer2.Panel2.Controls.Add(this.List_grid);
            this.splitContainer2.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer2_Panel2_Paint);
            this.splitContainer2.Size = new System.Drawing.Size(787, 502);
            this.splitContainer2.SplitterDistance = 85;
            this.splitContainer2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(197, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(394, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "EMPLOYEE PROTAL";
            // 
            // Title_txt
            // 
            this.Title_txt.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title_txt.Location = new System.Drawing.Point(326, 158);
            this.Title_txt.Name = "Title_txt";
            this.Title_txt.Size = new System.Drawing.Size(229, 27);
            this.Title_txt.TabIndex = 19;
            // 
            // Lname_txt
            // 
            this.Lname_txt.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lname_txt.Location = new System.Drawing.Point(326, 116);
            this.Lname_txt.Name = "Lname_txt";
            this.Lname_txt.Size = new System.Drawing.Size(229, 27);
            this.Lname_txt.TabIndex = 18;
            // 
            // Fname_txt
            // 
            this.Fname_txt.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fname_txt.Location = new System.Drawing.Point(326, 68);
            this.Fname_txt.Name = "Fname_txt";
            this.Fname_txt.Size = new System.Drawing.Size(229, 27);
            this.Fname_txt.TabIndex = 17;
            // 
            // Company_txt
            // 
            this.Company_txt.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Company_txt.Location = new System.Drawing.Point(326, 28);
            this.Company_txt.Name = "Company_txt";
            this.Company_txt.Size = new System.Drawing.Size(229, 27);
            this.Company_txt.TabIndex = 16;
            // 
            // Title_lbl
            // 
            this.Title_lbl.AutoSize = true;
            this.Title_lbl.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title_lbl.Location = new System.Drawing.Point(226, 161);
            this.Title_lbl.Name = "Title_lbl";
            this.Title_lbl.Size = new System.Drawing.Size(37, 19);
            this.Title_lbl.TabIndex = 15;
            this.Title_lbl.Text = "Title";
            // 
            // Lname_lbl
            // 
            this.Lname_lbl.AutoSize = true;
            this.Lname_lbl.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lname_lbl.Location = new System.Drawing.Point(226, 119);
            this.Lname_lbl.Name = "Lname_lbl";
            this.Lname_lbl.Size = new System.Drawing.Size(86, 19);
            this.Lname_lbl.TabIndex = 14;
            this.Lname_lbl.Text = "Last Name";
            // 
            // Fname_lbl
            // 
            this.Fname_lbl.AutoSize = true;
            this.Fname_lbl.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fname_lbl.Location = new System.Drawing.Point(226, 71);
            this.Fname_lbl.Name = "Fname_lbl";
            this.Fname_lbl.Size = new System.Drawing.Size(88, 19);
            this.Fname_lbl.TabIndex = 13;
            this.Fname_lbl.Text = "First Name";
            // 
            // Company_lbl
            // 
            this.Company_lbl.AutoSize = true;
            this.Company_lbl.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Company_lbl.Location = new System.Drawing.Point(226, 31);
            this.Company_lbl.Name = "Company_lbl";
            this.Company_lbl.Size = new System.Drawing.Size(79, 19);
            this.Company_lbl.TabIndex = 12;
            this.Company_lbl.Text = "Company";
            // 
            // List_grid
            // 
            this.List_grid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.985075F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.List_grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.List_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.985075F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.List_grid.DefaultCellStyle = dataGridViewCellStyle5;
            this.List_grid.Location = new System.Drawing.Point(25, 198);
            this.List_grid.Name = "List_grid";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.985075F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.List_grid.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.List_grid.RowHeadersWidth = 57;
            this.List_grid.RowTemplate.Height = 24;
            this.List_grid.Size = new System.Drawing.Size(739, 190);
            this.List_grid.TabIndex = 11;
            this.List_grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.List_grid_CellContentClick);
            // 
            // Update_btn
            // 
            this.Update_btn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Update_btn.Font = new System.Drawing.Font("Arial", 9.134328F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Update_btn.Location = new System.Drawing.Point(57, 125);
            this.Update_btn.Name = "Update_btn";
            this.Update_btn.Size = new System.Drawing.Size(105, 37);
            this.Update_btn.TabIndex = 9;
            this.Update_btn.Text = "UPDATE";
            this.Update_btn.UseVisualStyleBackColor = false;
            this.Update_btn.Click += new System.EventHandler(this.Update_btn_Click);
            // 
            // View_btn
            // 
            this.View_btn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.View_btn.Font = new System.Drawing.Font("Arial", 9.134328F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.View_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.View_btn.Location = new System.Drawing.Point(56, 82);
            this.View_btn.Name = "View_btn";
            this.View_btn.Size = new System.Drawing.Size(105, 37);
            this.View_btn.TabIndex = 10;
            this.View_btn.Text = "VIEW";
            this.View_btn.UseVisualStyleBackColor = false;
            this.View_btn.Click += new System.EventHandler(this.View_btn_Click);
            // 
            // DataPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 502);
            this.Controls.Add(this.splitContainer1);
            this.Name = "DataPage";
            this.Text = "DataPage";
            this.Load += new System.EventHandler(this.DataPage_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.List_grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button Save_btn;
        private System.Windows.Forms.Button Edit_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Delete_btn;
        private System.Windows.Forms.DataGridView List_grid;
        private System.Windows.Forms.Button New_btn;
        private System.Windows.Forms.Button Clear_btn;
        private System.Windows.Forms.TextBox Title_txt;
        private System.Windows.Forms.TextBox Lname_txt;
        private System.Windows.Forms.TextBox Fname_txt;
        private System.Windows.Forms.TextBox Company_txt;
        private System.Windows.Forms.Label Title_lbl;
        private System.Windows.Forms.Label Lname_lbl;
        private System.Windows.Forms.Label Fname_lbl;
        private System.Windows.Forms.Label Company_lbl;
        private System.Windows.Forms.Button Cancel_btn;
        private System.Windows.Forms.Button Quit_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Update_btn;
        private System.Windows.Forms.Button View_btn;
    }
}