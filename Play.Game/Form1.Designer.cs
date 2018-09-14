namespace Play.Game
{
    partial class BlackGreen
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
            this.label1 = new System.Windows.Forms.Label();
            this.GameStart = new System.Windows.Forms.Label();
            this.PlayGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(314, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;            // 
            // GameStart
            // 
            this.GameStart.AutoSize = true;
            this.GameStart.BackColor = System.Drawing.Color.Black;
            this.GameStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameStart.Location = new System.Drawing.Point(312, 319);
            this.GameStart.Name = "GameStart";
            this.GameStart.Size = new System.Drawing.Size(18, 25);
            this.GameStart.TabIndex = 1;
            this.GameStart.Text = ".";
            this.GameStart.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PlayGame
            // 
            this.PlayGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlayGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayGame.ForeColor = System.Drawing.Color.White;
            this.PlayGame.Location = new System.Drawing.Point(263, 55);
            this.PlayGame.Name = "PlayGame";
            this.PlayGame.Size = new System.Drawing.Size(324, 147);
            this.PlayGame.TabIndex = 2;
            this.PlayGame.Text = "PLAY GAME";
            this.PlayGame.UseVisualStyleBackColor = true;
            this.PlayGame.Click += new System.EventHandler(this.PlayGame_Click);
            // 
            // BlackGreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PlayGame);
            this.Controls.Add(this.GameStart);
            this.Controls.Add(this.label1);
            this.Name = "BlackGreen";
            this.Text = "Play Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label GameStart;
        private System.Windows.Forms.Button PlayGame;
    }
}

