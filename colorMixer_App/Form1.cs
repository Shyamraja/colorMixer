namespace colorMixer_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
     public void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            Bitmap pixelData = (Bitmap)pictureBox1.Image;
            Color clr = pixelData.GetPixel(e.X, e.Y);
            tBxRed.Text = clr.R.ToString();
            tBxGreen.Text = clr.G.ToString();
            tBxBlue.Text = clr.B.ToString();
            pnlSelectedScreen1.BackColor = clr;

        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            Bitmap pixelData = (Bitmap)pictureBox2.Image;
            Color clr = pixelData.GetPixel(e.X, e.Y);
            tBxRed1.Text = clr.R.ToString();
            tBxGreen1.Text = clr.G.ToString();
            tBxBlue1.Text = clr.B.ToString();
            pnlSelectedScreen2.BackColor = clr;
        }

        private void mixSelectedColors(object sender, EventArgs e)
        {
            Color mix;
            int r1, g1, b1, r2, g2, b2, r3, g3, b3;

            r1 = Convert.ToInt16(tBxRed.Text);
            r2 = Convert.ToInt16(tBxRed1.Text);
            g1 = Convert.ToInt16(tBxGreen.Text);
            g2 = Convert.ToInt16(tBxGreen1.Text);
            b1 = Convert.ToInt16(tBxBlue.Text);
            b2 = Convert.ToInt16(tBxBlue1.Text);
            r3 = (r1 + r2) / 2;
            g3 = (g1 + g2) / 2;
            b3 = (b1 + b2) / 2;
        
            mix = Color.FromArgb(r3, g3, b3);
            panelMixedColor.BackColor = mix;
        }


       

        private void mixColours(object sender, EventArgs e)
        {
            Color randommix;
            int r1, g1, b1, r2, g2, b2, r3, g3, b3,r4, g4, b4;

            r1 = Convert.ToInt16(tBxRed.Text);
            r2 = Convert.ToInt16(tBxRed1.Text);
            g1 = Convert.ToInt16(tBxGreen.Text);
            g2 = Convert.ToInt16(tBxGreen1.Text);
            b1 = Convert.ToInt16(tBxBlue.Text);
            b2 = Convert.ToInt16(tBxBlue1.Text);
            r3 = (r1 + r2) / 2;
            g3 = (g1 + g2) / 2;
            b3 = (b1 + b2) / 2;
            r4 = Math.Min((r1 + r2 + r3), 255);
            b4 = Math.Min((b1 + b2 + b3), 255);
            g4 = Math.Min((g1 + g2 + g3), 255);

            randommix = Color.FromArgb(r4, g4, b4);
            panelRandomlySelectedColors.BackColor = randommix;
        }
    }
}