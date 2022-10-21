namespace trex
{
    public partial class Form1 : Form
    {

        bool saut = false;
        bool accroupie = false;



        public Form1()
        {
            InitializeComponent();
        }

        private void TimerJeuMain(object sender, EventArgs e)
        {

        }

        private void Appuyer(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up && !saut)
            {
                dino.Image = Properties.Resources.running;
                dino.Location = new Point(47, 515);
                saut = true;
                accroupie = false;
            }

            if (e.KeyCode == Keys.Down && !accroupie)
            {
                dino.Image = Properties.Resources.accroupi;
                dino.Location = new Point(47,530);
                accroupie = true;
                saut = false;
            }
        }

            private void Relacher(object sender, KeyEventArgs e)
        {
            if (saut)
            {
                //dino.Image = Properties.Resources.running;
                saut =false;
                //accroupie = false;
            }
            if (accroupie)
            {
                dino.Image = Properties.Resources.running;
                dino.Location = new Point(47, 515);
                accroupie =false;
                saut = false;
            }
   
        }
    }
}