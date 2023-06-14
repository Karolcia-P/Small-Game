namespace game
{
    partial class GameScreen
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
            this.player = new System.Windows.Forms.PictureBox();
            this.playerTimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.fallingTimer = new System.Windows.Forms.Timer(this.components);
            this.createEnemyTimer = new System.Windows.Forms.Timer(this.components);
            this.operateTimer = new System.Windows.Forms.Timer(this.components);
            this.heart1 = new System.Windows.Forms.PictureBox();
            this.heart2 = new System.Windows.Forms.PictureBox();
            this.heart3 = new System.Windows.Forms.PictureBox();
            this.createPlayerEnemy = new System.Windows.Forms.Timer(this.components);
            this.stopwatchLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heart3)).BeginInit();
            this.SuspendLayout();
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.player.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.player.Location = new System.Drawing.Point(225, 413);
            this.player.Margin = new System.Windows.Forms.Padding(4);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(35, 35);
            this.player.TabIndex = 0;
            this.player.TabStop = false;
            // 
            // playerTimer
            // 
            this.playerTimer.Enabled = true;
            this.playerTimer.Interval = 20;
            this.playerTimer.Tick += new System.EventHandler(this.playerTimer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(20, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "level: 1";
            // 
            // fallingTimer
            // 
            this.fallingTimer.Enabled = true;
            this.fallingTimer.Interval = 50;
            this.fallingTimer.Tick += new System.EventHandler(this.fallingTimer_Tick);
            // 
            // createEnemyTimer
            // 
            this.createEnemyTimer.Enabled = true;
            this.createEnemyTimer.Interval = 2000;
            this.createEnemyTimer.Tick += new System.EventHandler(this.createEnemyTimer_Tick);
            // 
            // operateTimer
            // 
            this.operateTimer.Enabled = true;
            this.operateTimer.Interval = 5000;
            this.operateTimer.Tick += new System.EventHandler(this.operateTimer_Tick);
            // 
            // heart1
            // 
            this.heart1.BackColor = System.Drawing.Color.Lime;
            this.heart1.Location = new System.Drawing.Point(56, 52);
            this.heart1.Name = "heart1";
            this.heart1.Size = new System.Drawing.Size(13, 13);
            this.heart1.TabIndex = 2;
            this.heart1.TabStop = false;
            this.heart1.Tag = "heart";
            // 
            // heart2
            // 
            this.heart2.BackColor = System.Drawing.Color.Lime;
            this.heart2.Location = new System.Drawing.Point(37, 52);
            this.heart2.Name = "heart2";
            this.heart2.Size = new System.Drawing.Size(13, 13);
            this.heart2.TabIndex = 3;
            this.heart2.TabStop = false;
            this.heart2.Tag = "heart";
            // 
            // heart3
            // 
            this.heart3.BackColor = System.Drawing.Color.Lime;
            this.heart3.Location = new System.Drawing.Point(18, 52);
            this.heart3.Name = "heart3";
            this.heart3.Size = new System.Drawing.Size(13, 13);
            this.heart3.TabIndex = 4;
            this.heart3.TabStop = false;
            this.heart3.Tag = "heart";
            // 
            // createPlayerEnemy
            // 
            this.createPlayerEnemy.Enabled = true;
            this.createPlayerEnemy.Interval = 1500;
            this.createPlayerEnemy.Tick += new System.EventHandler(this.createPlayerEnemy_Tick);
            // 
            // stopwatchLabel
            // 
            this.stopwatchLabel.AutoSize = true;
            this.stopwatchLabel.BackColor = System.Drawing.Color.Transparent;
            this.stopwatchLabel.Location = new System.Drawing.Point(7, 33);
            this.stopwatchLabel.Name = "stopwatchLabel";
            this.stopwatchLabel.Size = new System.Drawing.Size(80, 16);
            this.stopwatchLabel.TabIndex = 5;
            this.stopwatchLabel.Text = "00:00:00.000";
            // 
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.stopwatchLabel);
            this.Controls.Add(this.heart3);
            this.Controls.Add(this.heart2);
            this.Controls.Add(this.heart1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.player);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GameScreen";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Game_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisup);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heart3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Timer playerTimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer fallingTimer;
        private System.Windows.Forms.Timer createEnemyTimer;
        private System.Windows.Forms.Timer operateTimer;
        private System.Windows.Forms.PictureBox heart1;
        private System.Windows.Forms.PictureBox heart2;
        private System.Windows.Forms.PictureBox heart3;
        private System.Windows.Forms.Timer createPlayerEnemy;
        private System.Windows.Forms.Label stopwatchLabel;
    }
}

