using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace trex
{
    public partial class game : Form
    {
        //haut bas
        bool up = false;
        bool down = false;

        //vitesse et force
        int gambetta_speed;
        int gambetta_strenght = 12;

        //score
        int score;

        //aleatoire
        Random r = new Random();

        //vitesse obstacle
        int speed_obstacle = 10;

        //initialisation fin
        public game()
        {
            InitializeComponent();
        }

        //timer
        private void MainGameTimer(object sender, EventArgs e)
        {
            Debug.WriteLine(gambetta_strenght);

            ScoreText.Text = "Score : " + score;

            score++;

            //on ajoute la vitesse au niveau de la tete du dino
            dino.Top += gambetta_speed;

            //si on appuie sur up et que la force du dino est inferieur a zero, on ne peux plus sauter
            if (up && gambetta_strenght < 0)
            {
                up = false;
            }

            //si on saute,vitesse de saut a -12 au dessus du dino et on enleve 1 a la force
            if (up)
            {
                gambetta_speed = -10;
                gambetta_strenght -= 1;
            } else //sinon la vitesse de saut est de 20 (augmente la vitesse de descente du dino
            {
                gambetta_speed = 15;
            }

            //si on ne saute pas et que le perso s'accroupie, augmente la vitesse a 60
            if (!up && down || up && down)
            {
                gambetta_speed = 60;
            }

            //si mon dino interagie avec le sol
            if (dino.Bounds.IntersectsWith(floor.Bounds))
            {
                gambetta_strenght = 12;
                gambetta_speed = 0;
                dino.Top = 355;

                //si up n'est pas appuyé et down appuyé change d'image (debout/accroupie)
                if (!up && down)
                {
                    dino.Image = Properties.Resources.crouch;
                }
                else
                {
                    dino.Image = Properties.Resources.stand2;
                }
            }

            //Pour chaque objets de type controle present dans la zone de controle
            foreach (Control obj in this.Controls)
            {
                //si l'objet est une image et que son tag est obstacle, on lui attribue une vitesse
                if (obj is PictureBox && (string) obj.Tag == "obstacle")
                {
                    obj.Left -= speed_obstacle;

                    //Si l'objet se trouve en dehors de la zone de jeu a gauche, on lui attribut une position aleatoire a droite  en dehors de la zone de jeu et on augmente le score
                    if (obj.Left < -100)
                    {
                        obj.Left = 2*this.ClientSize.Width + 2*r.Next(50,250);
                        score++;
                    }

                    //si le score est un multiple de 200, on augmente la vitesse des obstacles de 1 
                    if (score%200 == 0)
                    {
                        speed_obstacle += 1;
                    }

                    //si deux obstacles interagissent entre eux, on les éloignent aléatoirement
                    if (obstacle1.Bounds.IntersectsWith(obstacle2.Bounds))
                    {
                        obstacle2.Left += r.Next(50, 500);                  
                    }

                    //si le dino entre en collision avec un opbstacle on arrete le jeu
                    if (dino.Bounds.IntersectsWith(obj.Bounds))
                    {
                        GameTimer.Stop();
                    }
                }
            }


        }

        //si on appuie sur une touche
        private void game_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space || e.KeyCode == Keys.Up && !up)
            {
                up = true;
            }

            if (e.KeyCode == Keys.Down && !down)
            {
                down = true;
            }
        }

        //si on appuie pas sur une touche
        private void game_KeyUp(object sender, KeyEventArgs e)
        {
            if (up)
            {
                up = false;
            }
            if (down)
            {
                down =false;
            }
        }

        /*private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }*/

        

    }
}