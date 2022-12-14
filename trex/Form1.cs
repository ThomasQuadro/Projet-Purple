using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using System.Windows.Forms;

namespace trex
{
    public partial class game : Form
    {
        //vitesse nuage et position nuage en x et y
        int positionx = 0;
        int positiony = 0;
        int speed_cloud = 5;

        //haut bas
        bool up = false;
        bool down = false;
        bool dino_death = false;

        //aleatoire
        Random r = new Random();

        //vitesse et force
        int gambetta_speed;
        int gambetta_strenght = 12;

        //score le plus ?lev?
        int res = 0;

        //score
        int score;

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
            //appel de la fonction best_Score
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

                //si up n'est pas appuy? et down appuy? change d'image (debout/accroupie)
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
                //si c'est un nuage, attribue une vitesse aux nuages et met une position aleatoire aux nuages
                if (obj is PictureBox && (string) obj.Tag == "clouds")
                {
                    obj.Left -= speed_cloud;
                    if(obj.Left < -50)
                    {
                        positionx = this.ClientSize.Width;
                        positiony = r.Next(375,425) ;
                        obj.Left = positionx;
                        obj.Top = positiony;
                    }
                }

                //si l'objet est une image et que son tag est obstacle, on lui attribue une vitesse
                if (obj is PictureBox && (string) obj.Tag == "obstacle" && obj.Visible == true)
                {
                    obj.Left -= speed_obstacle;

                    //Si l'objet se trouve en dehors de la zone de jeu a gauche, on lui attribut une position aleatoire a droite  en dehors de la zone de jeu et on augmente le score
                    if (obj.Left < -50)
                    {
                        if (score < 400)
                        {
                            obj.Left = this.ClientSize.Width;
                            obj.Left += r.Next(500, 600);

                        }
                        else if (score < 800)
                        {
                            obstacle3.Visible = true;
                            obj.Left = this.ClientSize.Width ;
                            obj.Left += r.Next(400, 500);

                        } else
                        {
                            if (obstacle3.Left < -50)
                            {
                                obstacle3.Visible = false;
                            }
                            ptero1.Visible = true;
                            ptero1.Top = r.Next(400, 460);
                            obj.Left = this.ClientSize.Width ;
                            obj.Left += r.Next(300, 400);
                            
                        }
                    }

                    //si le score est un multiple de 200, on augmente la vitesse des obstacles de 1 
                    if (speed_obstacle != 20)
                    {
                        if (score % 400 == 0)
                        {
                            speed_obstacle += 1;
                        }
                    }
                    

                    //si deux obstacles interagissent entre eux, on les ?loignent al?atoirement
                    if (obstacle1.Bounds.IntersectsWith(obstacle2.Bounds))
                    {
                            Debug.WriteLine(true);
                            obstacle2.Left += r.Next(100, 300);
                    }

                    //si le dino entre en collision avec un opbstacle on arrete le jeu
                    if (dino.Bounds.IntersectsWith(obj.Bounds) && obj.Visible == true)
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

            dino.Image = Properties.Resources.stand2;
            dino.Top = 490;

            

            foreach (Control obj in this.Controls)
            {
                cloud1.Left = this.ClientSize.Width + 100;
                cloud2.Left = cloud1.Left + r.Next(200,250);
                cloud3.Left = cloud2.Left + r.Next(200, 250);

                if (obj.Tag == "clouds")
                {
                    obj.Top = r.Next(375, 425);
                }
                

                if (obj is PictureBox && (string)obj.Tag == "obstacle")
                {
                    obj.Left = this.ClientSize.Width;
                    obstacle2.Left += r.Next(200, 300);
                    obstacle3.Visible = false;
                    ptero1.Visible = false;
                    ptero1.Top = r.Next(400, 460);
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