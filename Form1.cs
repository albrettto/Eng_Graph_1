using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.IO;

namespace Eng_Graph_1
{
    public partial class LR1 : Form
    {
        public LR1()
        {
            InitializeComponent();
        }
        public void Update_Canvas()
        {
            Canvas.Controls.Clear();
            Canvas.Refresh();
        }

        public Color RandomColor()
        {
            Random r = new Random();
            Color color = Color.FromArgb(r.Next(256), r.Next(256), r.Next(256));
            return color;
        }

        private void btn_line_Click(object sender, EventArgs e)
        {
            Add_features.Visible = false;
            Update_Canvas();
            Canvas.CreateGraphics().DrawLine(new Pen(RandomColor(), 5), 100, 100, 500, 500);
        }

        private void btn_ellipse_Click(object sender, EventArgs e)
        {
            Add_features.Visible = false;
            Update_Canvas();
            Rectangle Ellipse = new Rectangle(100, 150, 400, 300);
            Canvas.CreateGraphics().DrawEllipse(new Pen(RandomColor(), 5), Ellipse);
        }

        Point[] points = new Point[4];
        Color color;

        public void btn_BezierCurve_Click(object sender, EventArgs e)
        {
            Add_features.Visible = true;
            trckbar_change.Visible = true;
            trckbr_scale.Visible = false;
            txtBox.Visible = false;
            trckbar_change.Value = 0;
            Update_Canvas();
            points[0] = new Point(75, 300); // Начальная точка
            points[1] = new Point(225, -200);
            points[2] = new Point(375, 750);
            points[3] = new Point(525, 300);
            color = RandomColor();
            Canvas.CreateGraphics().DrawBeziers(new Pen(color, 5), points);
        }

        private void trckbar_change_Scroll(object sender, EventArgs e)
        {
            Point[] copy_points = new Point[4];
            for (int i = 0; i < 4; ++i)
                copy_points[i] = points[i];
            copy_points[1].Y = points[1].Y + trckbar_change.Value * 10;
            copy_points[2].Y = points[2].Y - trckbar_change.Value * 10;
            Update_Canvas();
            Canvas.CreateGraphics().DrawBeziers(new Pen(color, 5), copy_points);
        }

        private void btn_ellipseSegment_Click(object sender, EventArgs e)
        {
            Add_features.Visible = false;
            Update_Canvas();
            // указываем расположение и размеры эллипса
            float x = 100.0F;
            float y = 100.0F;
            float width = 400.0F;
            float height = 400.0F;
            // Указываем начальный и конечный углы
            float startAngle = 0.0F;
            float endAngle = 240.0F;
            // Заливаем сегмент
            Canvas.CreateGraphics().FillPie(new SolidBrush(RandomColor()), x, y, width, height, startAngle, endAngle);
        }

        private void btn_diagram_Click(object sender, EventArgs e)
        {
            Add_features.Visible = false;
            Update_Canvas();
            float[] Angles = new float[] { 0, 130, 205, 290, 360 };
            Color[] Colors = new[] { Color.LightSeaGreen, Color.PeachPuff, Color.YellowGreen, RandomColor() };
            Rectangle rect = new Rectangle(50, 150, 500, 300);
            for (int angle = 1; angle <= Angles.Length - 1; angle++)
            {
                SolidBrush brush = new SolidBrush(Colors[angle - 1]);
                Canvas.CreateGraphics().FillPie(brush, rect, Angles[angle - 1], Angles[angle] - Angles[angle - 1]);
            }
            //Canvas.CreateGraphics().DrawEllipse(Pens.Black, rect);
        }

        private void btn_polygon_Click(object sender, EventArgs e)
        {
            Add_features.Visible = false;
            Update_Canvas();
            // Определяем штриховую кисть
            HatchBrush hBrush = new HatchBrush(HatchStyle.DarkUpwardDiagonal, Color.Black, RandomColor());
            // Создаем точки, определяющие полигон
            PointF point1 = new PointF(100.0F, 100.0F);
            PointF point2 = new PointF(230.0F, 60.0F);
            PointF point3 = new PointF(300.0F, 170.0F);
            PointF point4 = new PointF(350.0F, 150.0F);
            PointF point5 = new PointF(430.0F, 200.0F);
            PointF point6 = new PointF(450.0F, 100.0F);
            PointF point7 = new PointF(500.0F, 300.0F);
            PointF point8 = new PointF(230.0F, 330.0F);
            PointF[] curvePoints = new[] { point1, point2, point3, point4, point5, point6, point7, point8 };
            // Определяем режим заливки
            FillMode newFillMode = FillMode.Winding;
            // Заливаем полигон
            Canvas.CreateGraphics().FillPolygon(hBrush, curvePoints, newFillMode);
        }

        private void btn_gradient_Click(object sender, EventArgs e)
        {
            Add_features.Visible = false;
            Update_Canvas();
            Rectangle MyRectangle = new Rectangle(150, 150, 300, 300);
            Pen MyPen = new Pen(RandomColor(), 5);
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(MyRectangle);
            PathGradientBrush pthGrBrush = new PathGradientBrush(path);
            // Центр пути будет красного цвета
            pthGrBrush.CenterColor = RandomColor();
            Canvas.CreateGraphics().DrawEllipse(MyPen, MyRectangle);
            Canvas.CreateGraphics().FillPath(pthGrBrush, path);
        }

        private void btn_arrayOfPoints_Click(object sender, EventArgs e)
        {
            Add_features.Visible = false;
            Update_Canvas();
            // Строим градиент, основанный на массиве точке
            PointF[] myPoints = new[] { 
                new PointF(200, 100), 
                new PointF(400, 100), 
                new PointF(500, 200), 
                new PointF(500, 400), 
                new PointF(400, 500), 
                new PointF(200, 500), 
                new PointF(100, 400), 
                new PointF(100, 200) };
            PathGradientBrush myBrush = new PathGradientBrush(myPoints);
            Color[] colors = new[] { 
                Color.FromArgb(255, 255, 255, 255), 
                Color.FromArgb(255, 255, 255, 0),
                Color.FromArgb(255, 255, 0, 255), 
                Color.FromArgb(255, 0, 255, 255), 
                Color.FromArgb(255, 255, 0, 0), 
                Color.FromArgb(255, 0, 255, 0),
                Color.FromArgb(255, 0, 0, 255),
                Color.FromArgb(255, 0, 0, 0) };
            myBrush.SurroundColors = colors;
            // Центр будет белым
            myBrush.CenterColor = Color.White;
            // Используем градиентную кисть для заливки прямоугольника
            Canvas.CreateGraphics().FillRectangle(myBrush, new Rectangle(100, 100, 500, 500));
        }

        string file = "C:\\Users\\User\\OneDrive\\Документы\\Кафе.jpg";
        private void btn_uploadImage_Click(object sender, EventArgs e)
        {
            Add_features.Visible = false;
            Update_Canvas();
            Stream myStream;
            OpenFileDialog MyopenFileDialog = new OpenFileDialog();
            MyopenFileDialog.Filter = @"Images|*.GIF;*JPG;*.TIF;*BMP";
            MyopenFileDialog.FilterIndex = 2;
            MyopenFileDialog.RestoreDirectory = true;
            PictureBox MyPictureBox = new PictureBox();
            if (MyopenFileDialog.ShowDialog() == DialogResult.OK)
            {
                myStream = MyopenFileDialog.OpenFile();
                file = MyopenFileDialog.FileName;
                if (!(myStream == null))
                {
                    MyPictureBox.Location = new Point(0, 0);
                    Canvas.Controls.Add(MyPictureBox);
                    MyPictureBox.Size = new Size(Canvas.Height, Canvas.Width);
                    MyPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    MyPictureBox.Image = Image.FromFile(MyopenFileDialog.FileName);
                    myStream.Close();
                }
            }
        }
        
        int check = 0; //Узнаём на сколько градусов повернуть картинку
        private void btn_turn_Click(object sender, EventArgs e)
        {
            Add_features.Visible = false;
            Update_Canvas();
            PictureBox MyPictureBox = new PictureBox();
            MyPictureBox.Location = new Point(0, 0);
            MyPictureBox.Size = new Size(Canvas.Height, Canvas.Width);
            MyPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            Image img;
            img = Image.FromFile(@file);
            MyPictureBox.Image = img;
            switch (check)
            {
                case 0:
                    MyPictureBox.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    check = 1;
                    break;
                case 1:
                    MyPictureBox.Image.RotateFlip(RotateFlipType.Rotate180FlipNone);
                    check = 2;
                    break;
                case 2:
                    MyPictureBox.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
                    check = 3;
                    break;
                case 3:
                    check = 0;
                    break;
            }
            Canvas.Controls.Add(MyPictureBox);
        }

        private void btn_scale_Click(object sender, EventArgs e)
        {
            Update_Canvas();
            Add_features.Visible = true;
            trckbar_change.Visible = false;
            trckbr_scale.Visible = true;
            txtBox.Visible = false;
            PictureBox MyPictureBox = new PictureBox();
            MyPictureBox.Location = new Point(0, 0);
            MyPictureBox.Size = new Size(Canvas.Width, Canvas.Height);
            MyPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            MyPictureBox.Paint += new System.Windows.Forms.PaintEventHandler(MyPictureBox_Paint);
            Canvas.Controls.Add(MyPictureBox);
        }

        private void MyPictureBox_Paint(object sender, PaintEventArgs e)
        {
            Bitmap bitmap = new Bitmap(file);
            (sender as PictureBox).Size = new Size(bitmap.Size.Width, bitmap.Size.Height);
            e.Graphics.DrawImage(bitmap, 
                new Rectangle(0, 0, Canvas.Width * trckbr_scale.Value, Canvas.Height * trckbr_scale.Value), 
                new Rectangle(0, 0, bitmap.Size.Width, bitmap.Size.Height), GraphicsUnit.Pixel);
        }

        private void trckbr_scale_Scroll(object sender, EventArgs e)
        {
            btn_scale_Click(sender,e);
        }

        private void btn_inversionColor_Click(object sender, EventArgs e)
        {
            Add_features.Visible = false;
            Update_Canvas();
            PictureBox MyPictureBox = new PictureBox();
            MyPictureBox.Location = new Point(0, 0);
            MyPictureBox.Size = new Size(Canvas.Width, Canvas.Height);
            MyPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            Canvas.Controls.Add(MyPictureBox);
            MyPictureBox.Image = Image.FromFile(@"C:\\Users\\User\\OneDrive\\Документы\\street.jpg");
            Bitmap bmap = new Bitmap(MyPictureBox.Image);
            MyPictureBox.Image = bmap;
            Bitmap tempbmp = new Bitmap(MyPictureBox.Image);
            int DX = 1;
            int DY = 1;
            int red, green, blue;
            int i, j;
            {
                var withBlock = tempbmp;
                for (i = DX; i <= withBlock.Height - DX - 1; i++)
                {
                    for (j = DY; j <= withBlock.Width - DY - 1; j++)
                    {
                        red = 255 - Convert.ToInt32(Convert.ToInt32(withBlock.GetPixel(j - 1, i - 1).R));
                        green = 255 - Convert.ToInt32(Convert.ToInt32(withBlock.GetPixel(j - 1, i - 1).G));
                        blue = 255 - Convert.ToInt32(Convert.ToInt32(withBlock.GetPixel(j - 1, i - 1).B));

                        red = Math.Min(Math.Max(red, 0), 255);
                        green = Math.Min(Math.Max(green, 0), 255);
                        blue = Math.Min(Math.Max(blue, 0), 255);
                        bmap.SetPixel(j, i, Color.FromArgb(red, green, blue));
                        if (i % 10 == 0)
                        {
                            MyPictureBox.Invalidate();
                            MyPictureBox.Refresh();
                        }
                    }
                }
            }
        }

        private void btn_watermark_Click(object sender, EventArgs e)
        {
            Add_features.Visible = true;
            trckbar_change.Visible = false;
            trckbr_scale.Visible = false;
            txtBox.Visible = true;
            Update_Canvas();
            PictureBox MyPictureBox = new PictureBox();
            MyPictureBox.Location = new Point(0, 0);
            MyPictureBox.Size = new Size(Canvas.Width, Canvas.Height);
            MyPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            Canvas.Controls.Add(MyPictureBox);
            Font WMfont = new Font("Monofur", 40, FontStyle.Bold);
            SolidBrush WMBrush = new SolidBrush(RandomColor());
            Image img;
            img = Image.FromFile(file);
            MyPictureBox.Image = img;
            Graphics g = Graphics.FromImage(MyPictureBox.Image);
            if(txtBox.Text != "")
                g.DrawString(txtBox.Text, WMfont, WMBrush, 600, 660);
            else
                g.DrawString("Hello World!", WMfont, WMBrush, 600, 660);
        }

        private void txtBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btn_watermark_Click(sender, e);
            if (e.KeyCode == Keys.Escape)
                txtBox.Text = "";
        }
        private void btn_vector_Click(object sender, EventArgs e)
        {
            Add_features.Visible = false;
            Update_Canvas();
            Graphics g = Canvas.CreateGraphics();
            g.Clear(Color.White);
            System.Drawing.Imaging.Metafile myBitmap = new System.Drawing.Imaging.Metafile(@"C:\\Users\\User\\OneDrive\\Документы\\example.wmf");
            
            g.DrawImage(myBitmap, 0, 0);
        }

        private void btn_colorModel_Click(object sender, EventArgs e)
        {
            Add_features.Visible = false;
            Update_Canvas();
            Color newColor = Color.FromArgb(128, 128, 128);
            Canvas.BackColor = newColor;
        }
    }
}
