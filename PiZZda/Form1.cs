namespace PiZZda
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            new Random().Next(260,400);
            Bitmap animal = Resource1.photo1716913160;
            Bitmap food = Resource1.photo1716913160__2_;
            for(int i = 0; i < 10; i++)
            {
                e.Graphics.DrawImage(animal, new Point(new Random().Next(190,490), new Random().Next(60, 300)));
            }
            e.Graphics.DrawImage(food, new Point(250, 200));
        }
    }
}