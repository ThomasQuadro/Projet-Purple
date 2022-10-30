namespace trex
{
    partial class game
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dino = new System.Windows.Forms.PictureBox();
            this.floor = new System.Windows.Forms.PictureBox();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.obstacle1 = new System.Windows.Forms.PictureBox();
            this.obstacle2 = new System.Windows.Forms.PictureBox();
            this.ScoreText = new System.Windows.Forms.Label();
            this.obstacle3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dino)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.floor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle3)).BeginInit();
            this.SuspendLayout();
            // 
            // dino
            // 
            this.dino.BackColor = System.Drawing.Color.Transparent;
            this.dino.Image = global::trex.Properties.Resources.stand2;
            this.dino.Location = new System.Drawing.Point(66, 507);
            this.dino.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dino.Name = "dino";
            this.dino.Size = new System.Drawing.Size(41, 43);
            this.dino.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.dino.TabIndex = 0;
            this.dino.TabStop = false;
            // 
            // floor
            // 
            this.floor.BackColor = System.Drawing.SystemColors.ControlDark;
            this.floor.Location = new System.Drawing.Point(0, 533);
            this.floor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.floor.Name = "floor";
            this.floor.Size = new System.Drawing.Size(933, 80);
            this.floor.TabIndex = 1;
            this.floor.TabStop = false;
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 20;
            this.GameTimer.Tick += new System.EventHandler(this.MainGameTimer);
            // 
            // obstacle1
            // 
            this.obstacle1.Image = global::trex.Properties.Resources.obstacle_1;
            this.obstacle1.Location = new System.Drawing.Point(573, 487);
            this.obstacle1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.obstacle1.Name = "obstacle1";
            this.obstacle1.Size = new System.Drawing.Size(23, 46);
            this.obstacle1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.obstacle1.TabIndex = 2;
            this.obstacle1.TabStop = false;
            this.obstacle1.Tag = "obstacle";
            // 
            // obstacle2
            // 
            this.obstacle2.Image = global::trex.Properties.Resources.obstacle_2;
            this.obstacle2.Location = new System.Drawing.Point(795, 500);
            this.obstacle2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.obstacle2.Name = "obstacle2";
            this.obstacle2.Size = new System.Drawing.Size(32, 33);
            this.obstacle2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.obstacle2.TabIndex = 3;
            this.obstacle2.TabStop = false;
            this.obstacle2.Tag = "obstacle";
            // 
            // ScoreText
            // 
            this.ScoreText.AutoSize = true;
            this.ScoreText.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ScoreText.Location = new System.Drawing.Point(32, 29);
            this.ScoreText.Name = "ScoreText";
            this.ScoreText.Size = new System.Drawing.Size(0, 46);
            this.ScoreText.TabIndex = 4;
            // 
            // obstacle3
            // 
            this.obstacle3.Image = global::trex.Properties.Resources.cactus3;
            this.obstacle3.Location = new System.Drawing.Point(700, 484);
            this.obstacle3.Name = "obstacle3";
            this.obstacle3.Size = new System.Drawing.Size(50, 50);
            this.obstacle3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.obstacle3.TabIndex = 5;
            this.obstacle3.TabStop = false;
            this.obstacle3.Tag = "obstacle";
            // 
            // game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 597);
            this.Controls.Add(this.obstacle3);
            this.Controls.Add(this.obstacle2);
            this.Controls.Add(this.obstacle1);
            this.Controls.Add(this.ScoreText);
            this.Controls.Add(this.dino);
            this.Controls.Add(this.floor);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximumSize = new System.Drawing.Size(930, 644);
            this.MinimumSize = new System.Drawing.Size(930, 644);
            this.Name = "game";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.game_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.game_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.dino)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.floor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox dino;
        private PictureBox floor;
        private System.Windows.Forms.Timer GameTimer;
        private PictureBox obstacle1;
        private PictureBox obstacle2;
        private Label ScoreText;
        private PictureBox obstacle3;
    }
}