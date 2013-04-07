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
            this.components = new System.ComponentModel.Container();
            this.pictureBoxMain = new System.Windows.Forms.PictureBox();
            this.ImportImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveLabelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Angle90ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Angle180ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Angle270ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Angle360ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logouttoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.UserNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TagToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditTagToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveTagToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxMain
            // 
            this.pictureBoxMain.Location = new System.Drawing.Point(12, 27);
            this.pictureBoxMain.Name = "pictureBoxMain";
            this.pictureBoxMain.Size = new System.Drawing.Size(990, 711);
            this.pictureBoxMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMain.TabIndex = 2;
            this.pictureBoxMain.TabStop = false;
            this.pictureBoxMain.DoubleClick += new System.EventHandler(this.pictureBoxMain_DoubleClick);
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
            // logouttoolStripMenuItem
            // 
            this.logouttoolStripMenuItem.Name = "logouttoolStripMenuItem";
            this.logouttoolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.logouttoolStripMenuItem.Text = "登出";
            this.logouttoolStripMenuItem.Click += new System.EventHandler(this.logouttoolStripMenuItem_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ImportImageToolStripMenuItem,
            this.OpenImageToolStripMenuItem,
            this.SaveLabelToolStripMenuItem,
            this.ToolStripMenuItem,
            this.UserNameToolStripMenuItem,
            this.logouttoolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1014, 24);
            this.menuStrip.TabIndex = 4;
            this.menuStrip.Text = "menuStrip1";
            // 
            // UserNameToolStripMenuItem
            // 
            this.UserNameToolStripMenuItem.Name = "UserNameToolStripMenuItem";
            this.UserNameToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.UserNameToolStripMenuItem.Text = "先生/小姐您好";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.exitToolStripMenuItem.Text = "離開";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TagToolStripMenuItem,
            this.EditTagToolStripMenuItem,
            this.SaveTagToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(153, 92);
            // 
            // TagToolStripMenuItem
            // 
            this.TagToolStripMenuItem.Name = "TagToolStripMenuItem";
            this.TagToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.TagToolStripMenuItem.Text = "標記";
            this.TagToolStripMenuItem.Click += new System.EventHandler(this.TagToolStripMenuItem_Click);
            // 
            // EditTagToolStripMenuItem
            // 
            this.EditTagToolStripMenuItem.Name = "EditTagToolStripMenuItem";
            this.EditTagToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.EditTagToolStripMenuItem.Text = "編輯標籤";
            // 
            // SaveTagToolStripMenuItem
            // 
            this.SaveTagToolStripMenuItem.Name = "SaveTagToolStripMenuItem";
            this.SaveTagToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.SaveTagToolStripMenuItem.Text = "儲存標籤";
            // 
            // EditImageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 750);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.pictureBoxMain);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "EditImageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditImage";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxMain;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ImportImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveLabelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Angle90ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Angle180ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Angle270ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Angle360ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logouttoolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem UserNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem TagToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditTagToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveTagToolStripMenuItem;
    }
}