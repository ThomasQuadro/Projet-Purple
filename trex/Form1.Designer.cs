﻿namespace trex
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
            ((System.ComponentModel.ISupportInitialize)(this.dino)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.floor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle2)).BeginInit();
            this.SuspendLayout();
            // 
            // dino
            // 
            this.dino.BackColor = System.Drawing.Color.Transparent;
            this.dino.Image = global::trex.Properties.Resources.stand2;
            this.dino.Location = new System.Drawing.Point(58, 380);
            this.dino.Name = "dino";
            this.dino.Size = new System.Drawing.Size(41, 43);
            this.dino.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.dino.TabIndex = 0;
            this.dino.TabStop = false;
            // 
            // floor
            // 
            this.floor.BackColor = System.Drawing.SystemColors.ControlDark;
            this.floor.Location = new System.Drawing.Point(0, 400);
            this.floor.Name = "floor";
            this.floor.Size = new System.Drawing.Size(816, 60);
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
            this.obstacle1.Location = new System.Drawing.Point(501, 354);
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
            this.obstacle2.Location = new System.Drawing.Point(696, 367);
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
            this.ScoreText.Location = new System.Drawing.Point(28, 22);
            this.ScoreText.Name = "ScoreText";
            this.ScoreText.Size = new System.Drawing.Size(0, 37);
            this.ScoreText.TabIndex = 4;
            // 
            // game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 456);
            this.Controls.Add(this.ScoreText);
            this.Controls.Add(this.obstacle2);
            this.Controls.Add(this.dino);
            this.Controls.Add(this.obstacle1);
            this.Controls.Add(this.floor);
            this.Name = "game";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.game_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.game_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.dino)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.floor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.obstacle2)).EndInit();
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
    }
}