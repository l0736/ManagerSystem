using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using ManagerSystem.Module;
using MySql.Data.MySqlClient;

namespace ManagerSystem
{
    public partial class EditImageForm : Form
    {
        private static PictureBox[] picBoxList = new PictureBox[5];
        private static Dictionary<int, String> imagesDic = new Dictionary<int, string>();
        private static Boolean isTag = false;
        private static Boolean isInit = false;
        private static Label shareLabel = null;
        private static String tempLabel;
        private static String projectName;

        public EditImageForm()
        {
            InitializeComponent();
            setListNmae();
            init();
        }

        private void init()
        {
            panel.Enabled = false;
            pictureBoxMain.Enabled = false;
            picBoxList[0] = this.pictureBoxList1;
            picBoxList[1] = this.pictureBoxList2;
            picBoxList[2] = this.pictureBoxList3;
            picBoxList[3] = this.pictureBoxList4;
            picBoxList[4] = this.pictureBoxList5;

            picBoxList[0].Click += new EventHandler(pictureBox_Click);
            picBoxList[1].Click += new EventHandler(pictureBox_Click);
            picBoxList[2].Click += new EventHandler(pictureBox_Click);
            picBoxList[3].Click += new EventHandler(pictureBox_Click);
            picBoxList[4].Click += new EventHandler(pictureBox_Click);
            pictureBoxMain.SendToBack();
            this.Click += new EventHandler(allObjectClick);
            foreach (Control con in Controls)
            {
                //判斷是否屬於Panel
                if (con.GetType().Name == "Panel")
                {
                    con.Click += new EventHandler(allObjectClick);
                }
                else
                {
                    con.Click += new EventHandler(allObjectClick);
                }
            }
        }

        private void setListNmae()
        {
            if (Directory.Exists(DataPath.GetImagePath()))
            {
                string[] dirs = Directory.GetDirectories(DataPath.GetImagePath());

                if (dirs.Length >= 1)
                {
                    toolStripDropDownList.ShowDropDownArrow = true;
                    foreach (string name in dirs)
                    {
                        //取得資料夾名稱
                        String fileName = name.Substring(name.LastIndexOf('\\') + 1);

                        //新增名稱到清單上
                        addNewItems(fileName);
                    }
                }
            }
        }

        private void setListName(String name)
        {
            Boolean isSet = false;

            //是否有其他資料
            if (toolStripDropDownList.ShowDropDownArrow)
            {
                int length = toolStripDropDownList.DropDownItems.Count;
                for (int index = 0; index < length; index++)
                {
                    if (toolStripDropDownList.DropDownItems[index].Text.Equals(name))
                    {
                        isSet = true;
                        break;
                    }
                }

                if (!isSet)
                {
                    //新增名稱到清單上
                    addNewItems(name);
                }
            }
            else
            {
                toolStripDropDownList.ShowDropDownArrow = true;

                //新增名稱到清單上
                addNewItems(name);
            }
        }

        private void addNewItems(String name)
        {
            ToolStripMenuItem newItem = new ToolStripMenuItem(name);
            newItem.Click += new EventHandler(newStripMenuItem_Click);
            toolStripDropDownList.DropDownItems.Add(newItem);
        }

        private void newStripMenuItem_Click(object sender, EventArgs e)
        {
            //取得MenuItem Name
            String name = ((ToolStripMenuItem)sender).Text;
            projectName = name;

            //取得資料夾底下所有檔案
            string[] dirlist = Directory.GetFiles(DataPath.GetImagePath(name));
            if (dirlist.Length > 0)
            {
                pictureBoxMain.Enabled = true;
                panel.Enabled = true;
                int index = 0;
                imagesDic = new Dictionary<int, string>();
                foreach (string str in dirlist)
                {
                    imagesDic.Add(index, str);
                    index++;
                }

                for (index = 0; index < imagesDic.Values.Count; index++)
                {
                    if (imagesDic[index].ToString().EndsWith(".jpeg"))
                    {
                        FileStream fs = new FileStream(imagesDic[index], FileMode.Open);
                        Byte[] data = new Byte[fs.Length];
                        fs.Read(data, 0, data.Length);
                        fs.Close();
                        MemoryStream memory = new MemoryStream(data);
                        picBoxList[index].Image = Image.FromStream(memory);
                        memory.Dispose();
                    }
                }
            }
        }

        private void toolStripSplitLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "PDF|*.pdf";
            fileDialog.InitialDirectory = DataPath.GetDesktopPath();
            fileDialog.RestoreDirectory = true;

            //多重選擇
            // fileDialog.Multiselect = true;
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                //紀錄點出現的地方
                int endIndex = fileDialog.SafeFileName.IndexOf('.');
                String fileName = fileDialog.SafeFileName.Substring(0, endIndex);
                PDFtoImage(fileDialog.FileName, fileName);
            }
        }

        private void PDFtoImage(String path, String name)
        {
            //倍數
            short pixelZoom = 10;

            //頁
            Acrobat.CAcroPDPage pdfPage = null;

            //頁面大小
            Acrobat.CAcroPoint pdfPoint = null;

            //矩形
            Acrobat.CAcroRect pdfRect = null;

            //判斷資料夾是否重複建立
            if (!Directory.Exists(DataPath.GetNewFolder(name)))
            {
                Directory.CreateDirectory((DataPath.GetNewFolder(name)));
            }

            Acrobat.CAcroPDDoc pdfDoc = (Acrobat.CAcroPDDoc)Microsoft.VisualBasic.Interaction.CreateObject("AcroExch.PDDoc", "");

            if (pdfDoc.Open(path))
            {
                //PDF頁數
                int pageCount = pdfDoc.GetNumPages();
                for (int index = 0; index < pageCount; index++)
                {
                    //取得目前頁數
                    pdfPage = (Acrobat.CAcroPDPage)pdfDoc.AcquirePage(index);

                    //取得頁面大小
                    pdfPoint = (Acrobat.CAcroPoint)pdfPage.GetSize();

                    //http://forums.adobe.com/thread/305835
                    pdfRect = (Acrobat.CAcroRect)Microsoft.VisualBasic.Interaction.CreateObject("AcroExch.Rect", "");

                    //左邊
                    pdfRect.Left = 0;

                    //頂端
                    pdfRect.Top = 0;

                    //右邊
                    pdfRect.right = (short)(pdfPoint.x * pixelZoom);

                    //底部
                    pdfRect.bottom = (short)(pdfPoint.y * pixelZoom);

                    //取得整個頁面
                    pdfPage.CopyToClipboard(pdfRect, (short)(pdfRect.Left * pixelZoom), (short)(pdfRect.Top * pixelZoom), (short)(100 * pixelZoom));

                    System.Windows.Forms.IDataObject loClipboardData = Clipboard.GetDataObject();

                    //Get Image
                    Bitmap pdfBitmap = (Bitmap)loClipboardData.GetData(DataFormats.Bitmap);
                    String fileName = DataPath.GetNewFolder(name) + @"\" + (index + 1) + ".jpeg";

                    //沒有重複新增相同影像
                    if (!File.Exists(fileName))
                    {
                        //Save Image
                        pdfBitmap.Save(fileName, ImageFormat.Jpeg);
                    }
                }
                pdfDoc.Close();

                Marshal.ReleaseComObject(pdfPage);
                Marshal.ReleaseComObject(pdfRect);
                Marshal.ReleaseComObject(pdfDoc);

                //加入到清單
                setListName(name);
                MessageBox.Show("轉換成功");
            }
            else
            {
                MessageBox.Show("檔案可能損毀或建立了");
            }
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            if (((MouseEventArgs)e).Button == MouseButtons.Left && isTag == false)
            {
                //判斷是否為空
                if (((PictureBox)sender).Image != null)
                {
                    pictureBoxMain.Controls.Clear();

                    //將點擊的照片給予主照片區
                    pictureBoxMain.Image = ((PictureBox)sender).Image;
                    this.pictureBoxMain.Image = ((PictureBox)sender).Image;
                    ReadConfig(this.pictureBoxMain.Controls);
                }
            }
        }

        private void ReadConfig(Control.ControlCollection controls)
        {
            String configPath = DataPath.GetConfigPath(projectName, "pic.config");
            StreamReader reader;

            if (File.Exists(configPath))
            {
                reader = new StreamReader(configPath);
                String str;
                while ((str = reader.ReadLine()) != null)
                {
                    try
                    {
                        if (str.Equals("[0]") || str.Equals("END"))
                        {
                        }
                        else
                        {
                            String[] ary = str.Split(',');
                            Label label = new Label();
                            label.Text = ary[0];
                            label.Location = new Point(Convert.ToInt32(ary[1]), Convert.ToInt32(ary[2]));
                            label.SendToBack();
                            label.DoubleClick += new EventHandler(label_DoubleClick);
                            label.MouseDown += new MouseEventHandler(label_MouseDown);
                            label.BackColor = Color.White;
                            label.AutoSize = true;
                            controls.Add(label);
                        }
                    }
                    catch (IndexOutOfRangeException ex)
                    {
                    }
                }
                reader.Close();
            }
        }

        private void SaveConfig(Control.ControlCollection controls)
        {
            try
            {
                StreamReader reader;
                String configPath = DataPath.GetConfigPath(projectName, "pic.config");
                if (!File.Exists(configPath))
                {
                    File.Create(configPath);
                    reader = new StreamReader(configPath);
                }
                else
                {
                    reader = new StreamReader(configPath);
                }
                if (reader.ReadToEnd().Length > 0)
                {
                    String oldData = reader.ReadToEnd();
                }
                reader.Close();
                int index = 0;
                StreamWriter writer = new StreamWriter(configPath);
                writer.WriteLine("[" + index + "]");
                foreach (Control con in controls)
                {
                    if (con.GetType() == typeof(Label))
                    {
                        writer.WriteLine(((Label)con).Text + "," + ((Label)con).Location.X + "," + ((Label)con).Location.Y);
                    }
                }
                writer.WriteLine("[END]");
                writer.Close();
            }
            catch (IOException ex)
            {
            }
        }

        private void toolStripDropDownTag_Click(object sender, EventArgs e)
        {
            //表示已經有tag
            isTag = true;
            Image image = Properties.Resources.Tag;
            Cursor cursor = new Cursor(new Bitmap(image).GetHicon());
            this.Cursor = cursor;
        }

        private void EditImageForm_MouseMove(object sender, MouseEventArgs e)
        {
            //  Label label = new Label();
            //   label.Location = new Point(e.X, e.Y);
            //   label.BringToFront();
            //  this.Controls.Add(label);

            //    label.Location = new Point(e.X, e.Y);
        }

        /*
        private void pictureBoxList_Click(object sender, EventArgs e)
        {
            if (((PictureBox)sender).Image != null)
            {
                this.pictureBoxMain.Controls.Clear();
                newImage(sender);
            }
        }
        */

        private void newImage(object sender)
        {
            this.pictureBoxMain.Image = ((PictureBox)sender).Image;
            ReadConfig(this.pictureBoxMain.Controls);
        }

        private void allObjectClick(object sender, EventArgs e)
        {
            if (((MouseEventArgs)e).Button == MouseButtons.Right && isTag == true)
            {
                this.Cursor = Cursors.Default;
                isTag = false;
            }
        }

        private void pictureBoxMain_DoubleClick(object sender, EventArgs e)
        {
            //Get MouseEventArgs
            MouseEventArgs mouse = ((MouseEventArgs)e);

            //判斷滑鼠按鈕
            if (isTag == true && mouse.Button == MouseButtons.Left)
            {
                //Initialization label
                Label label = new Label();
                label.DoubleClick += new EventHandler(label_DoubleClick);
                label.MouseDown += new MouseEventHandler(label_MouseDown);
                label.BackColor = Color.White;
                label.BringToFront();
                label.AutoSize = true;

                //Share Label
                setShareLabel(label);

                TextBox textbox = new TextBox();
                textbox.KeyDown += new KeyEventHandler(textBox_KeyDown);
                textbox.BringToFront();

                //設定新位置
                label.Location = new Point(mouse.X, mouse.Y);
                textbox.Location = new Point(mouse.X, mouse.Y);
                pictureBoxMain.Controls.Add(label);
                pictureBoxMain.Controls.Add(textbox);
            }
        }

        private void setShareLabel(Label label)
        {
            if (label != null)
            {
                shareLabel = label;
            }
        }

        private void setShareString(String str)
        {
            if (shareLabel != null)
            {
                shareLabel.Text = str;
                shareLabel.Visible = true;
            }
            else
            {
                //如果標籤為空
                if (shareLabel.Text.Equals(""))
                {
                    if (isInit == false)
                    {
                        //則代表沒有輸入文字並且釋放資源
                        shareLabel.Dispose();
                    }
                }
                else
                {
                    shareLabel.Visible = true;
                }
            }

            //Release resource
            shareLabel = null;
        }

        private void textBox_KeyDown(object sender, KeyEventArgs e)
        {
            TextBox point = (TextBox)sender;
            if (e.KeyCode == Keys.Enter)
            {
                if (!point.Text.Equals(""))
                {
                    //Share data
                    setShareString(point.Text);

                    //Release resource
                    point.Dispose();
                }
            }
        }

        private void label_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Clicks == 2 && e.Button == MouseButtons.Right)
            {
                SearchDataForm form = new SearchDataForm(((Label)sender).Text);
                try
                {
                    form.SendToBack();
                    form.Show();
                }
                catch (ObjectDisposedException ex)
                {
                    form.Dispose();
                }
            }
        }

        private void label_DoubleClick(object sender, EventArgs e)
        {
            //Setting label
            Label label = (Label)sender;
            label.Visible = false;
            setShareLabel(label);
            TextBox textbox = new TextBox();
            textbox.Location = label.Location;
            textbox.KeyDown += new KeyEventHandler(textBox_KeyDown);
            textbox.BringToFront();
            textbox.Focus();
            pictureBoxMain.Controls.Add(textbox);
        }

        private void label_MouseHover(object sender, EventArgs e)
        {
            String sql = "SELECT * FROM inventory WHERE ProductNumber='" + this.Text.ToString() + "'";

            MySQLT.cmd = new MySqlCommand(sql, MySQLT.getMySqlConnection());
            ToolTip tip = new ToolTip();
            tip.ForeColor = Color.Red;
            tip.BackColor = Color.DarkBlue;
            tip.AutoPopDelay = 2000;

            try
            {
                MySqlDataReader data = MySQLT.cmd.ExecuteReader();

                if (data.HasRows == true)
                {
                    tempLabel = this.Text;
                    tip.SetToolTip(this, "請稍等兩秒後出現編輯視窗");
                }
                else
                {
                    MessageBox.Show("零件庫沒有該資料喔");
                }
                data.Close();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            catch (MySqlException ex)
            {
            }
        }

        private Size CalculateNewSize(int width, int height, double RotateAngle)
        {
            double r = Math.Sqrt(Math.Pow((double)width / 2d, 2d) + Math.Pow((double)height / 2d, 2d)); //半徑L
            double OriginalAngle = Math.Acos((width / 2d) / r) / Math.PI * 180d;  //對角線和X軸的角度θ
            double minW = 0d, maxW = 0d, minH = 0d, maxH = 0d; //最大和最小的 X、Y座標
            double[] drawPoint = new double[4];

            drawPoint[0] = (-OriginalAngle + RotateAngle) * Math.PI / 180d;
            drawPoint[1] = (OriginalAngle + RotateAngle) * Math.PI / 180d;
            drawPoint[2] = (180f - OriginalAngle + RotateAngle) * Math.PI / 180d;
            drawPoint[3] = (180f + OriginalAngle + RotateAngle) * Math.PI / 180d;

            foreach (double point in drawPoint) //由四個角的點算出X、Y的最大值及最小值
            {
                double x = r * Math.Cos(point);
                double y = r * Math.Sin(point);

                if (x < minW)
                    minW = x;
                if (x > maxW)
                    maxW = x;
                if (y < minH)
                    minH = y;
                if (y > maxH)
                    maxH = y;
            }

            return new Size((int)(maxW - minW), (int)(maxH - minH));
        }

        //旋轉圖片之函式
        //參數    image：要旋轉的圖片  RotateAngle：旋轉角度
        private Bitmap RotateBitmap(Bitmap image, float RotateAngle)
        {
            Size newSize = CalculateNewSize(image.Width, image.Height, RotateAngle);
            Bitmap rotatedBmp = new Bitmap(newSize.Width, newSize.Height);
            PointF centerPoint = new PointF((float)rotatedBmp.Width / 2f, (float)rotatedBmp.Height / 2f);
            Graphics g = Graphics.FromImage(rotatedBmp);

            g.CompositingQuality = CompositingQuality.HighQuality;
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;

            g.TranslateTransform(centerPoint.X, centerPoint.Y);
            g.RotateTransform(RotateAngle);
            g.TranslateTransform(-centerPoint.X, -centerPoint.Y);

            g.DrawImage(image, (float)(newSize.Width - image.Width) / 2f, (float)(newSize.Height - image.Height) / 2f, image.Width, image.Height);
            g.Dispose();

            return rotatedBmp;
        }

        private void Angle90ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBoxMain.Image != null)
            {
                try
                {
                    Bitmap bitmap;
                    bitmap = RotateBitmap(new Bitmap(pictureBoxMain.Image), 90);
                    pictureBoxMain.Image = Image.FromHbitmap(bitmap.GetHbitmap());
                    MessageBox.Show("轉換成功");
                }
                catch (OutOfMemoryException ex)
                {
                }
            }
        }

        private void Angle180ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBoxMain.Image != null)
            {
                try
                {
                    Bitmap bitmap;
                    bitmap = RotateBitmap(new Bitmap(pictureBoxMain.Image), 180);
                    pictureBoxMain.Image = Image.FromHbitmap(bitmap.GetHbitmap());
                    MessageBox.Show("轉換成功");
                }
                catch (OutOfMemoryException ex)
                {
                }
            }
        }

        private void Angle270ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBoxMain.Image != null)
            {
                try
                {
                    Bitmap bitmap;
                    bitmap = RotateBitmap(new Bitmap(pictureBoxMain.Image), 270);
                    pictureBoxMain.Image = Image.FromHbitmap(bitmap.GetHbitmap());
                    MessageBox.Show("轉換成功");
                }
                catch (OutOfMemoryException ex)
                {
                }
            }
        }

        private void Angle360ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBoxMain.Image != null)
            {
                try
                {
                    Bitmap bitmap;
                    bitmap = RotateBitmap(new Bitmap(pictureBoxMain.Image), 360);
                    pictureBoxMain.Image = Image.FromHbitmap(bitmap.GetHbitmap());
                    MessageBox.Show("轉換成功");
                }
                catch (OutOfMemoryException ex)
                {
                }
            }
        }

        private void toolStripDropDownSave_Click(object sender, EventArgs e)
        {
            SaveConfig(pictureBoxMain.Controls);
        }
    }
}