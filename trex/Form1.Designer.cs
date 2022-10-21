namespace trex
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.sol = new System.Windows.Forms.PictureBox();
            this.TimerJeu = new System.Windows.Forms.Timer(this.components);
            this.dino = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.sol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dino)).BeginInit();
            this.SuspendLayout();
            // 
            // sol
            // 
            this.sol.BackColor = System.Drawing.SystemColors.ControlDark;
            this.sol.Location = new System.Drawing.Point(0, 420);
            this.sol.Name = "sol";
            this.sol.Size = new System.Drawing.Size(800, 30);
            this.sol.TabIndex = 0;
            this.sol.TabStop = false;
            // 
            // TimerJeu
            // 
            this.TimerJeu.Enabled = true;
            this.TimerJeu.Interval = 20;
            this.TimerJeu.Tick += new System.EventHandler(this.TimerJeuMain);
            // 
            // dino
            // 
            this.dino.Image = ((System.Drawing.Image)(resources.GetObject("dino.Image")));
            this.dino.Location = new System.Drawing.Point(47, 385);
            this.dino.Margin = new System.Windows.Forms.Padding(0);
            this.dino.Name = "dino";
            this.dino.Size = new System.Drawing.Size(40, 43);
            this.dino.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.dino.TabIndex = 1;
            this.dino.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dino);
            this.Controls.Add(this.sol);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Appuyer);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Relacher);
            ((System.ComponentModel.ISupportInitialize)(this.sol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dino)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox sol;
        private System.Windows.Forms.Timer TimerJeu;
        private PictureBox dino;
    }
}