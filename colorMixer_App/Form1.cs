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

       
    }
}