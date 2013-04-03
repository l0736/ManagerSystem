namespace ManagerSystem
{
    partial class EditImageForm
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
            this.pictureBoxMain = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ImportImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TagLabelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveLabelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Angle90ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Angle180ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Angle270ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Angle360ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxMain
            // 
            this.pictureBoxMain.Location = new System.Drawing.Point(104, 66);
            this.pictureBoxMain.Name = "pictureBoxMain";
            this.pictureBoxMain.Size = new System.Drawing.Size(753, 607);
            this.pictureBoxMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMain.TabIndex = 2;
            this.pictureBoxMain.TabStop = false;
            this.pictureBoxMain.DoubleClick += new System.EventHandler(this.pictureBoxMain_DoubleClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ImportImageToolStripMenuItem,
            this.OpenImageToolStripMenuItem,
            this.TagLabelToolStripMenuItem,
            this.SaveLabelToolStripMenuItem,
            this.ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1014, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ImportImageToolStripMenuItem
            // 
            this.ImportImageToolStripMenuItem.Name = "ImportImageToolStripMenuItem";
            this.ImportImageToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.ImportImageToolStripMenuItem.Text = "匯入零件圖";
            this.ImportImageToolStripMenuItem.Click += new System.EventHandler(this.ImportImageToolStripMenuItem_Click);
            // 
            // OpenImageToolStripMenuItem
            // 
            this.OpenImageToolStripMenuItem.Name = "OpenImageToolStripMenuItem";
            this.OpenImageToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.OpenImageToolStripMenuItem.Text = "開啟零件圖";
            this.OpenImageToolStripMenuItem.Click += new System.EventHandler(this.OpenImageToolStripMenuItem_Click);
            // 
            // TagLabelToolStripMenuItem
            // 
            this.TagLabelToolStripMenuItem.Name = "TagLabelToolStripMenuItem";
            this.TagLabelToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.TagLabelToolStripMenuItem.Text = "標記";
            this.TagLabelToolStripMenuItem.Click += new System.EventHandler(this.TagLabelToolStripMenuItem_Click);
            // 
            // SaveLabelToolStripMenuItem
            // 
            this.SaveLabelToolStripMenuItem.Name = "SaveLabelToolStripMenuItem";
            this.SaveLabelToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.SaveLabelToolStripMenuItem.Text = "儲存標記";
            this.SaveLabelToolStripMenuItem.Click += new System.EventHandler(this.SaveLabelToolStripMenuItem_Click);
            // 
            // ToolStripMenuItem
            // 
            this.ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Angle90ToolStripMenuItem,
            this.Angle180ToolStripMenuItem,
            this.Angle270ToolStripMenuItem,
            this.Angle360ToolStripMenuItem});
            this.ToolStripMenuItem.Name = "ToolStripMenuItem";
            this.ToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.ToolStripMenuItem.Text = "選轉圖片";
            // 
            // Angle90ToolStripMenuItem
            // 
            this.Angle90ToolStripMenuItem.Name = "Angle90ToolStripMenuItem";
            this.Angle90ToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.Angle90ToolStripMenuItem.Text = "旋轉90度";
            // 
            // Angle180ToolStripMenuItem
            // 
            this.Angle180ToolStripMenuItem.Name = "Angle180ToolStripMenuItem";
            this.Angle180ToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.Angle180ToolStripMenuItem.Text = "旋轉180度";
            // 
            // Angle270ToolStripMenuItem
            // 
            this.Angle270ToolStripMenuItem.Name = "Angle270ToolStripMenuItem";
            this.Angle270ToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.Angle270ToolStripMenuItem.Text = "旋轉270度";
            // 
            // Angle360ToolStripMenuItem
            // 
            this.Angle360ToolStripMenuItem.Name = "Angle360ToolStripMenuItem";
            this.Angle360ToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.Angle360ToolStripMenuItem.Text = "旋轉360度";
            this.Angle360ToolStripMenuItem.Click += new System.EventHandler(this.Angle360ToolStripMenuItem_Click_1);
            // 
            // EditImageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 750);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBoxMain);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "EditImageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditImage";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxMain;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ImportImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TagLabelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveLabelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Angle90ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Angle180ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Angle270ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Angle360ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}