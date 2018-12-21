using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;

namespace TwinImageCrop
{
    public partial class Form1 : Form
    {
        // https://stackoverflow.com/questions/12054918/how-to-pan-image-inside-picturebox

        private Point m_startingPoint = Point.Empty;
        private Point m_movingPoint = Point.Empty;
        private Point m_drawStartingPt = Point.Empty;
        private bool m_bPanning = false;
        private bool m_bRefLineDrawingOn = false;
        private Dictionary<string, MyPoint> stringPtMap = new Dictionary<string, MyPoint>();
        private Image m_leftOriginalImage;

        const string PAN_FIRST_PT = "PAN_FIRST_PT";
        const string PAN_MOVING_PT = "PAN_MOVING_PT";

        public Form1()
        {
            InitializeComponent();
            stringPtMap.Add(pictureBox1.Name + PAN_FIRST_PT, new MyPoint(0, 0));
            stringPtMap.Add(pictureBox1.Name + PAN_MOVING_PT, new MyPoint(0, 0));
            stringPtMap.Add(pictureBox2.Name + PAN_FIRST_PT, new MyPoint(0, 0));
            stringPtMap.Add(pictureBox2.Name + PAN_MOVING_PT, new MyPoint(0, 0));

            m_leftOriginalImage = new Bitmap(pictureBox1.Image);
        }

        void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            var pictureBoxes = new List<PictureBox>();
            if (cbxLockBoth.Checked)
            {
                pictureBoxes.Add(pictureBox1);
                pictureBoxes.Add(pictureBox2);
            }
            else
            {
                pictureBoxes.Add(sender as PictureBox);
            }

            foreach (var picBox in pictureBoxes)
            {
                m_bPanning = true;
                var panFirstPt = stringPtMap[picBox.Name + PAN_FIRST_PT];
                var panMovingPt = stringPtMap[picBox.Name + PAN_MOVING_PT];

                panFirstPt.m_Pt.X = e.Location.X - panMovingPt.m_Pt.X;
                panFirstPt.m_Pt.Y = e.Location.Y - panMovingPt.m_Pt.Y;

                if (m_bRefLineDrawingOn)
                {
                    m_leftOriginalImage = new Bitmap(picBox.Image);
                    m_drawStartingPt = new Point(m_startingPoint.X, m_startingPoint.Y);
                }
            }
            
        }

        void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            m_bPanning = false;
        }

        void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            var pictureBoxes = new List<PictureBox>();
            if (cbxLockBoth.Checked)
            {
                pictureBoxes.Add(pictureBox1);
                pictureBoxes.Add(pictureBox2);
            }
            else
            {
                pictureBoxes.Add(sender as PictureBox);
            }

            foreach (var picBox in pictureBoxes)
            {

                if (m_bPanning)
                {
                    var panFirstPt = stringPtMap[picBox.Name + PAN_FIRST_PT];
                    var panMovingPt = stringPtMap[picBox.Name + PAN_MOVING_PT];

                    panMovingPt.m_Pt.X = e.Location.X - panFirstPt.m_Pt.X;
                    panMovingPt.m_Pt.Y = e.Location.Y - panFirstPt.m_Pt.Y;

                    picBox.Invalidate();
                }

                // If we are drawing on the canvas
                if (m_bRefLineDrawingOn && m_drawStartingPt != Point.Empty)
                {
                    DrawLine(picBox, m_drawStartingPt.X, m_drawStartingPt.Y, e.Location.X + m_movingPoint.X, e.Location.Y + m_movingPoint.Y);
                    picBox.Invalidate();
                }
            }
        }

        void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            // This will be called by individual PictureBox, so no need to synchronise here.
            var picBox = sender as PictureBox;
            var panMovingPt = stringPtMap[picBox.Name + PAN_MOVING_PT];

            e.Graphics.Clear(Color.White);
            e.Graphics.DrawImage(picBox.Image, panMovingPt.m_Pt);
        }

        private void DrawLine(PictureBox picBox, int x1, int y1, int x2, int y2)
        {
            picBox.Image.Dispose();
            
            Graphics g;
            pictureBox1.Image = new Bitmap(m_leftOriginalImage);
            // g = Graphics.FromImage(pictureBox1.Image);


            g = Graphics.FromImage(pictureBox1.Image);
            pictureBox1.Refresh();

            Pen mypen = new Pen(Color.Black);
            g.DrawLine(mypen, x1, y1, x2, y2);
            g.Dispose();
        }

        private void btnRefLine_Click(object sender, EventArgs e)
        {
            if(!m_bRefLineDrawingOn)
            {
                (sender as Button).BackColor = Color.Red;
            }
            else
            {
                (sender as Button).BackColor = Button.DefaultBackColor;
                m_drawStartingPt = Point.Empty;
            }
            m_bRefLineDrawingOn = !m_bRefLineDrawingOn;
        }

        private void cbxLockBoth_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxLockBoth.Checked)
            {
                var leftWindowMovingPt = stringPtMap[pictureBox1.Name + PAN_MOVING_PT];
                var rightWindowMovingPt = stringPtMap[pictureBox2.Name + PAN_MOVING_PT];

                leftWindowMovingPt.m_Pt = rightWindowMovingPt.m_Pt;
            }
        }


        public Image PictureBoxZoom(Image img, Size size)
        {
            Bitmap bm = new Bitmap(img, Convert.ToInt32(img.Width * size.Width), Convert.ToInt32(img.Height * size.Height));
            Graphics grap = Graphics.FromImage(bm);
            grap.InterpolationMode = InterpolationMode.HighQualityBicubic;
            return bm;
        }

        private void leftZoomBar_Scroll(object sender, EventArgs e)
        {
            if (leftZoomBar.Value > 0)
            {
                pictureBox1.Image = null;
                pictureBox1.Image = PictureBoxZoom(m_leftOriginalImage, new Size(leftZoomBar.Value, leftZoomBar.Value));
            }
        }
    }

    public class MyPoint
    {
        public Point m_Pt;
        public MyPoint(int x, int y)
        {
            m_Pt.X = x;
            m_Pt.Y = y;
        }

        private MyPoint()
        {

        }
    }
}
