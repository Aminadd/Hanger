using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vesala
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel1.Visible = true;
            panel1.BackColor = Color.Gray;
            Graphics g = panel1.CreateGraphics();
            Pen pn = new Pen(Color.Red);
            Pen pen = new Pen((Color.Red), 20);
            Brush brush = new SolidBrush(Color.Red);
            g.FillRectangle(brush, 20, 20, 20, 320);
            g.FillRectangle(brush, 10, 30, 300, 20);
            g.FillRectangle(brush, 220, 30, 20, 50);
            g.DrawEllipse(pn, 195, 78, 70, 70);
            g.DrawLine(pn, 230, 149, 230, 220);
            g.DrawLine(pn, 230, 219, 270, 250);
            g.DrawLine(pn, 230, 219, 190, 250);
            g.DrawLine(pn, 230, 170, 270, 180);
            g.DrawLine(pn, 230, 170, 190, 180);
            g.DrawLine(pen, new Point(25, 120), new Point(115, 40));

        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel1.Visible = true;
            Graphics g = panel1.CreateGraphics();
            Bitmap bitmap = new Bitmap(Properties.Resources.преузимање);
            Bitmap bitm = new Bitmap(Properties.Resources._12);
            TextureBrush tBrush = new TextureBrush(bitmap);
            Pen textPen = new Pen(tBrush, 20);
            g.DrawImage(bitmap, 20, 20,20 ,340);
            g.DrawImage(bitmap, 10, 30, 330, 20);
            g.DrawImage(bitm, 220, 50, 50, 100);
            g.DrawLine(textPen, new Point(25, 120), new Point(115, 40));

                Bitmap bi = new Bitmap(Properties.Resources.Cruella_de_Vil__1_);
                g.DrawImage(bi, 180, 105, 115, 70);

                    Bitmap bit = new Bitmap(Properties.Resources.Cruella_de_Vil___Copy);
                    g.DrawImage(bit, 180, 163, 120, 120);

                        Bitmap bb = new Bitmap(Properties.Resources.Cruella_de_Vil___Copy__2_);
                        g.DrawImage(bb, 295, 156, 55, 75);
                    
                            Bitmap b = new Bitmap(Properties.Resources.Cruella_de_Vil___Copy__3_);
                            g.DrawImage(b, 125, 140, 55, 70);
                   
                                Bitmap biit = new Bitmap(Properties.Resources.Cruella_de_Vil___Copy__5_);
                                g.DrawImage(biit, 245, 280, 40, 55);

                                    Bitmap bii = new Bitmap(Properties.Resources.Cruella_de_Vil___Copy__4_);
                                    g.DrawImage(bii, 210, 280, 40,40);
        }
    }
}