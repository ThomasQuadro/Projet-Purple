using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using System.Windows.Forms;

namespace trex
{
    public partial class game : Form
    {
        //haut bas
        bool up = false;
        bool down = false;
        bool dino_death = false;

        //vitesse et force
        int gambetta_speed;
        int gambetta_strenght = 12;
        int res = 0;

        //score
        int score;

        //aleatoire
        Random r = new Random();

        //vitesse obstacle
        int speed_obstacle = 10;

        //initialisation/fin
        public game()
        {
            InitializeComponent();
            game_Reset();
        }

        //timer
        private void MainGameTimer(object sender, EventArgs e)
        {

            best_Score();

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
                dino.Top = 490;

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
                        obj.Left = this.ClientSize.Width + 2 * r.Next(50, 150);
                    }

                    //si le score est un multiple de 200, on augmente la vitesse des obstacles de 1 
                    if (speed_obstacle != 20)
                    {
                        if (score % 400 == 0)
                        {
                            speed_obstacle += 1;
                        }
                    }
                    

                    //si deux obstacles interagissent entre eux, on les éloignent aléatoirement
                    if (obstacle1.Bounds.IntersectsWith(obstacle2.Bounds))
                    {
                            obstacle2.Left += r.Next(100, 300);
                    }

                    //si le dino entre en collision avec un opbstacle on arrete le jeu
                    if (dino.Bounds.IntersectsWith(obj.Bounds))
                    {
                        dino_death = true;
                        dino.Image = Properties.Resources.dead;
                        GameTimer.Stop();
                        ScoreText.Text += " Pour rejouer, appuyer sur Space ou Up";
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
            if ((e.KeyCode == Keys.Space || e.KeyCode == Keys.Up) && dino_death)
            {
                game_Reset();
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

        //fonction de reset de jeu
        private void game_Reset()
        {
            gambetta_strenght = 12;
            gambetta_speed = 0;
            speed_obstacle = 10;

            up = false;
            down = false;
            dino_death = false;
            score = 0;

            //ScoreText.Text = "Score: " + score;
            dino.Image = Properties.Resources.stand2;
            dino.Top = 490;

            foreach (Control obj in this.Controls)
            {

                if (obj is PictureBox && (string)obj.Tag == "obstacle")
                {
                    obj.Left = this.ClientSize.Width + 2 * r.Next(50, 250);
                }
                if (obstacle1.Bounds.IntersectsWith(obstacle2.Bounds))
                {
                    obstacle2.Left += r.Next(50, 500);
                }
            }

            GameTimer.Start();

        }


        //fonction pour afficher le meilleur score
        private void best_Score()
        {
            if (score > res)
            {
                res = score;
                ScoreText.Text = "Meilleurs score : " + score;
            }
            else
            {
                ScoreText.Text = "Score : " + score + " Best Score : "+res;
            }
        }



    }
}