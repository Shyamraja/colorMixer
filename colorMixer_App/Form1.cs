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
    }
}