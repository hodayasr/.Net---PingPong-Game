namespace PingPong
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.racket = new System.Windows.Forms.PictureBox();
            this.ball = new System.Windows.Forms.PictureBox();
            this.playground = new System.Windows.Forms.Panel();
            this.gameover = new System.Windows.Forms.Label();
            this.points = new System.Windows.Forms.Label();
            this.labelscore = new System.Windows.Forms.Label();
            this.exitLable = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.racket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            this.playground.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 15;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // racket
            // 
            this.racket.BackColor = System.Drawing.Color.Black;
            this.racket.Location = new System.Drawing.Point(471, 458);
            this.racket.Name = "racket";
            this.racket.Size = new System.Drawing.Size(142, 20);
            this.racket.TabIndex = 0;
            this.racket.TabStop = false;
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.Color.Red;
            this.ball.Location = new System.Drawing.Point(352, 77);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(30, 30);
            this.ball.TabIndex = 2;
            this.ball.TabStop = false;
            // 
            // playground
            // 
            this.playground.Controls.Add(this.gameover);
            this.playground.Controls.Add(this.points);
            this.playground.Controls.Add(this.labelscore);
            this.playground.Controls.Add(this.exitLable);
            this.playground.Controls.Add(this.ball);
            this.playground.Controls.Add(this.racket);
            this.playground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playground.Location = new System.Drawing.Point(0, 0);
            this.playground.Name = "playground";
            this.playground.Size = new System.Drawing.Size(870, 492);
            this.playground.TabIndex = 0;
            // 
            // gameover
            // 
            this.gameover.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gameover.AutoSize = true;
            this.gameover.Font = new System.Drawing.Font("Microsoft Sans Serif", 27F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.gameover.ForeColor = System.Drawing.Color.DarkRed;
            this.gameover.Location = new System.Drawing.Point(83, 115);
            this.gameover.Name = "gameover";
            this.gameover.Size = new System.Drawing.Size(345, 252);
            this.gameover.TabIndex = 7;
            this.gameover.Text = "Game Over !\n\n F1 to restart\n Esc to exit";
            this.gameover.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // points
            // 
            this.points.AutoSize = true;
            this.points.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.points.Location = new System.Drawing.Point(778, 12);
            this.points.Name = "points";
            this.points.Size = new System.Drawing.Size(32, 36);
            this.points.TabIndex = 6;
            this.points.Text = "0";
            // 
            // labelscore
            // 
            this.labelscore.AutoSize = true;
            this.labelscore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelscore.Location = new System.Drawing.Point(664, 12);
            this.labelscore.Name = "labelscore";
            this.labelscore.Size = new System.Drawing.Size(109, 36);
            this.labelscore.TabIndex = 5;
            this.labelscore.Text = "Score :";
            // 
            // exitLable
            // 
            this.exitLable.AutoSize = true;
            this.exitLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.exitLable.ForeColor = System.Drawing.Color.Maroon;
            this.exitLable.Location = new System.Drawing.Point(33, 18);
            this.exitLable.Name = "exitLable";
            this.exitLable.Size = new System.Drawing.Size(184, 20);
            this.exitLable.TabIndex = 4;
            this.exitLable.Text = "Enter Esc key to exit !";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 492);
            this.Controls.Add(this.playground);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.racket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            this.playground.ResumeLayout(false);
            this.playground.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox racket;
        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.Panel playground;
        private System.Windows.Forms.Label exitLable;
        private System.Windows.Forms.Label labelscore;
        private System.Windows.Forms.Label points;
        private System.Windows.Forms.Label gameover;
    }
}

