namespace ShipsGame.Okna
{
    partial class Rozgrywka
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
            this.planszaGracza = new System.Windows.Forms.PictureBox();
            this.planszaPrzeciwnika = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.planszaGracza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.planszaPrzeciwnika)).BeginInit();
            this.SuspendLayout();
            // 
            // planszaGracza
            // 
            this.planszaGracza.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.planszaGracza.Image = global::ShipsGame.Properties.Resources.board;
            this.planszaGracza.Location = new System.Drawing.Point(554, 23);
            this.planszaGracza.Name = "planszaGracza";
            this.planszaGracza.Size = new System.Drawing.Size(400, 400);
            this.planszaGracza.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.planszaGracza.TabIndex = 1;
            this.planszaGracza.TabStop = false;
            // 
            // planszaPrzeciwnika
            // 
            this.planszaPrzeciwnika.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.planszaPrzeciwnika.Image = global::ShipsGame.Properties.Resources.board;
            this.planszaPrzeciwnika.Location = new System.Drawing.Point(45, 23);
            this.planszaPrzeciwnika.Name = "planszaPrzeciwnika";
            this.planszaPrzeciwnika.Size = new System.Drawing.Size(400, 400);
            this.planszaPrzeciwnika.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.planszaPrzeciwnika.TabIndex = 0;
            this.planszaPrzeciwnika.TabStop = false;
            // 
            // Rozgrywka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 450);
            this.Controls.Add(this.planszaGracza);
            this.Controls.Add(this.planszaPrzeciwnika);
            this.Name = "Rozgrywka";
            this.Text = "Rozgrywka";
            ((System.ComponentModel.ISupportInitialize)(this.planszaGracza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.planszaPrzeciwnika)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox planszaPrzeciwnika;
        private System.Windows.Forms.PictureBox planszaGracza;
    }
}