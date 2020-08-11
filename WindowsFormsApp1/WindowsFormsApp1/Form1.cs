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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMainBar_Paint);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hellow World!");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void panelMainBar_Paint(object sender, PaintEventArgs e)
        {
            LinearGradientBrush linGrBrush = new LinearGradientBrush(
           this.ClientRectangle,
           Color.FromArgb(255, 207, 223, 249),
           Color.FromArgb(255, 139, 174, 232),
           LinearGradientMode.Vertical);
            ColorBlend cb = new ColorBlend();
            cb.Colors = new Color[] { Color.FromArgb(255, 207, 223, 249), Color.FromArgb(255, 139, 174, 232) };
            cb.Positions = new Single[] { 0.0F, 1.0F };
            linGrBrush.InterpolationColors = cb;
            e.Graphics.FillRectangle(linGrBrush, this.ClientRectangle);

        }

        private void panelText_Paint(object sender, PaintEventArgs e)
        {
            LinearGradientBrush linGrBrush = new LinearGradientBrush(
            this.ClientRectangle,
            Color.FromArgb(255, 207, 223, 249),
            Color.FromArgb(255, 139, 174, 232),
            LinearGradientMode.Vertical);
            ColorBlend cb = new ColorBlend();
            cb.Colors = new Color[] { Color.FromArgb(255, 207, 223, 249), Color.FromArgb(255, 139, 174, 232) };
            cb.Positions = new Single[] { 0.0F, 1.0F };
            linGrBrush.InterpolationColors = cb;
            e.Graphics.FillRectangle(linGrBrush, this.ClientRectangle);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            panelSubBar1.Visible = true;
            panel6.Visible = true;
            panel5.Visible = true;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelSubBar1_Paint(object sender, PaintEventArgs e)
        {
            LinearGradientBrush linGrBrush = new LinearGradientBrush(
            this.ClientRectangle,
            Color.FromArgb(255, 207, 223, 249),
            Color.FromArgb(255, 139, 174, 232),
            LinearGradientMode.Vertical);
            ColorBlend cb = new ColorBlend();
            cb.Colors = new Color[] { Color.FromArgb(255, 207, 223, 249), Color.FromArgb(255, 139, 174, 232) };
            cb.Positions = new Single[] { 0.0F, 1.0F };
            linGrBrush.InterpolationColors = cb;
            e.Graphics.FillRectangle(linGrBrush, this.ClientRectangle);
        }
        
    }
}
