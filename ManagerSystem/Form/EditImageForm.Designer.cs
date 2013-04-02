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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditImageForm));
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripSplitLoad = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripDropDownList = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripDropDownTag = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripDropDownSave = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripSplitButton = new System.Windows.Forms.ToolStripSplitButton();
            this.Angle90ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Angle180ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Angle270ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Angle360ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel = new System.Windows.Forms.Panel();
            this.pictureBoxList5 = new System.Windows.Forms.PictureBox();
            this.pictureBoxList4 = new System.Windows.Forms.PictureBox();
            this.pictureBoxList3 = new System.Windows.Forms.PictureBox();
            this.pictureBoxList2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxList1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxMain = new System.Windows.Forms.PictureBox();
            this.toolStrip.SuspendLayout();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxList5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxList4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxList3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxList2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxList1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSplitLoad,
            this.toolStripDropDownList,
            this.toolStripDropDownTag,
            this.toolStripDropDownSave,
            this.toolStripSplitButton});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(1014, 25);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "toolStrip1";
            // 
            // toolStripSplitLoad
            // 
            this.toolStripSplitLoad.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSplitLoad.Image = global::ManagerSystem.Properties.Resources.Folder;
            this.toolStripSplitLoad.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitLoad.Name = "toolStripSplitLoad";
            this.toolStripSplitLoad.ShowDropDownArrow = false;
            this.toolStripSplitLoad.Size = new System.Drawing.Size(20, 22);
            this.toolStripSplitLoad.Text = "匯入零件圖";
            this.toolStripSplitLoad.Click += new System.EventHandler(this.toolStripSplitLoad_Click);
            // 
            // toolStripDropDownList
            // 
            this.toolStripDropDownList.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownList.Image = global::ManagerSystem.Properties.Resources.Component;
            this.toolStripDropDownList.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownList.Name = "toolStripDropDownList";
            this.toolStripDropDownList.ShowDropDownArrow = false;
            this.toolStripDropDownList.Size = new System.Drawing.Size(20, 22);
            this.toolStripDropDownList.Text = "開啟零件圖";
            // 
            // toolStripDropDownTag
            // 
            this.toolStripDropDownTag.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownTag.Image = global::ManagerSystem.Properties.Resources.Tag;
            this.toolStripDropDownTag.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownTag.Name = "toolStripDropDownTag";
            this.toolStripDropDownTag.ShowDropDownArrow = false;
            this.toolStripDropDownTag.Size = new System.Drawing.Size(20, 22);
            this.toolStripDropDownTag.Text = "標記";
            this.toolStripDropDownTag.Click += new System.EventHandler(this.toolStripDropDownTag_Click);
            // 
            // toolStripDropDownSave
            // 
            this.toolStripDropDownSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownSave.Image = global::ManagerSystem.Properties.Resources.Save;
            this.toolStripDropDownSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownSave.Name = "toolStripDropDownSave";
            this.toolStripDropDownSave.ShowDropDownArrow = false;
            this.toolStripDropDownSave.Size = new System.Drawing.Size(20, 22);
            this.toolStripDropDownSave.Text = "儲存零件圖";
            this.toolStripDropDownSave.Click += new System.EventHandler(this.toolStripDropDownSave_Click);
            // 
            // toolStripSplitButton
            // 
            this.toolStripSplitButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSplitButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Angle90ToolStripMenuItem,
            this.Angle180ToolStripMenuItem,
            this.Angle270ToolStripMenuItem,
            this.Angle360ToolStripMenuItem});
            this.toolStripSplitButton.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSplitButton.Image")));
            this.toolStripSplitButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSplitButton.Name = "toolStripSplitButton";
            this.toolStripSplitButton.Size = new System.Drawing.Size(72, 22);
            this.toolStripSplitButton.Text = "選轉圖片";
            // 
            // Angle90ToolStripMenuItem
            // 
            this.Angle90ToolStripMenuItem.Name = "Angle90ToolStripMenuItem";
            this.Angle90ToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.Angle90ToolStripMenuItem.Text = "旋轉90度";
            this.Angle90ToolStripMenuItem.Click += new System.EventHandler(this.Angle90ToolStripMenuItem_Click);
            // 
            // Angle180ToolStripMenuItem
            // 
            this.Angle180ToolStripMenuItem.Name = "Angle180ToolStripMenuItem";
            this.Angle180ToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.Angle180ToolStripMenuItem.Text = "旋轉180度";
            this.Angle180ToolStripMenuItem.Click += new System.EventHandler(this.Angle180ToolStripMenuItem_Click);
            // 
            // Angle270ToolStripMenuItem
            // 
            this.Angle270ToolStripMenuItem.Name = "Angle270ToolStripMenuItem";
            this.Angle270ToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.Angle270ToolStripMenuItem.Text = "旋轉270度";
            this.Angle270ToolStripMenuItem.Click += new System.EventHandler(this.Angle270ToolStripMenuItem_Click);
            // 
            // Angle360ToolStripMenuItem
            // 
            this.Angle360ToolStripMenuItem.Name = "Angle360ToolStripMenuItem";
            this.Angle360ToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.Angle360ToolStripMenuItem.Text = "旋轉360度";
            this.Angle360ToolStripMenuItem.Click += new System.EventHandler(this.Angle360ToolStripMenuItem_Click);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.pictureBoxList5);
            this.panel.Controls.Add(this.pictureBoxList4);
            this.panel.Controls.Add(this.pictureBoxList3);
            this.panel.Controls.Add(this.pictureBoxList2);
            this.panel.Controls.Add(this.pictureBoxList1);
            this.panel.Location = new System.Drawing.Point(12, 28);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(86, 430);
            this.panel.TabIndex = 3;
            this.panel.Click += new System.EventHandler(this.allObjectClick);
            // 
            // pictureBoxList5
            // 
            this.pictureBoxList5.Location = new System.Drawing.Point(3, 344);
            this.pictureBoxList5.Name = "pictureBoxList5";
            this.pictureBoxList5.Size = new System.Drawing.Size(80, 80);
            this.pictureBoxList5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxList5.TabIndex = 0;
            this.pictureBoxList5.TabStop = false;
            this.pictureBoxList5.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // pictureBoxList4
            // 
            this.pictureBoxList4.Location = new System.Drawing.Point(3, 258);
            this.pictureBoxList4.Name = "pictureBoxList4";
            this.pictureBoxList4.Size = new System.Drawing.Size(80, 80);
            this.pictureBoxList4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxList4.TabIndex = 0;
            this.pictureBoxList4.TabStop = false;
            this.pictureBoxList4.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // pictureBoxList3
            // 
            this.pictureBoxList3.Location = new System.Drawing.Point(3, 172);
            this.pictureBoxList3.Name = "pictureBoxList3";
            this.pictureBoxList3.Size = new System.Drawing.Size(80, 80);
            this.pictureBoxList3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxList3.TabIndex = 0;
            this.pictureBoxList3.TabStop = false;
            this.pictureBoxList3.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // pictureBoxList2
            // 
            this.pictureBoxList2.Location = new System.Drawing.Point(3, 86);
            this.pictureBoxList2.Name = "pictureBoxList2";
            this.pictureBoxList2.Size = new System.Drawing.Size(80, 80);
            this.pictureBoxList2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxList2.TabIndex = 0;
            this.pictureBoxList2.TabStop = false;
            this.pictureBoxList2.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // pictureBoxList1
            // 
            this.pictureBoxList1.Location = new System.Drawing.Point(3, 0);
            this.pictureBoxList1.Name = "pictureBoxList1";
            this.pictureBoxList1.Size = new System.Drawing.Size(80, 80);
            this.pictureBoxList1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxList1.TabIndex = 0;
            this.pictureBoxList1.TabStop = false;

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
            // EditImageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 750);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.pictureBoxMain);
            this.Name = "EditImageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditImage";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.EditImageForm_MouseMove);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxList5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxList4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxList3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxList2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxList1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownList;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownSave;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownTag;
        private System.Windows.Forms.PictureBox pictureBoxMain;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.PictureBox pictureBoxList5;
        private System.Windows.Forms.PictureBox pictureBoxList4;
        private System.Windows.Forms.PictureBox pictureBoxList3;
        private System.Windows.Forms.PictureBox pictureBoxList2;
        private System.Windows.Forms.PictureBox pictureBoxList1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripSplitLoad;
        private System.Windows.Forms.ToolStripSplitButton toolStripSplitButton;
        private System.Windows.Forms.ToolStripMenuItem Angle90ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Angle180ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Angle270ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Angle360ToolStripMenuItem;
    }
}