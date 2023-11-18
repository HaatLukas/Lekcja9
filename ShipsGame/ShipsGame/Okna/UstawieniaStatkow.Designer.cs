namespace ShipsGame.Okna
{
    partial class UstawieniaStatkow
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
            this.lb_Gracz = new System.Windows.Forms.Label();
            this.txt_NazwaGracza = new System.Windows.Forms.TextBox();
            this.lb_WpiszNazwe = new System.Windows.Forms.Label();
            this.btn_Obrot = new System.Windows.Forms.Button();
            this.btn_Dalej = new System.Windows.Forms.Button();
            this.planszaGracza = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.planszaGracza)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_Gracz
            // 
            this.lb_Gracz.AutoSize = true;
            this.lb_Gracz.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_Gracz.Location = new System.Drawing.Point(634, 46);
            this.lb_Gracz.Name = "lb_Gracz";
            this.lb_Gracz.Size = new System.Drawing.Size(64, 24);
            this.lb_Gracz.TabIndex = 1;
            this.lb_Gracz.Text = "Gracz";
            // 
            // txt_NazwaGracza
            // 
            this.txt_NazwaGracza.Location = new System.Drawing.Point(614, 115);
            this.txt_NazwaGracza.Name = "txt_NazwaGracza";
            this.txt_NazwaGracza.Size = new System.Drawing.Size(100, 20);
            this.txt_NazwaGracza.TabIndex = 2;
            // 
            // lb_WpiszNazwe
            // 
            this.lb_WpiszNazwe.AutoSize = true;
            this.lb_WpiszNazwe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lb_WpiszNazwe.ForeColor = System.Drawing.Color.Red;
            this.lb_WpiszNazwe.Location = new System.Drawing.Point(552, 162);
            this.lb_WpiszNazwe.Name = "lb_WpiszNazwe";
            this.lb_WpiszNazwe.Size = new System.Drawing.Size(236, 20);
            this.lb_WpiszNazwe.TabIndex = 3;
            this.lb_WpiszNazwe.Text = "Wpisz swoją nazwę użytkownika";
            // 
            // btn_Obrot
            // 
            this.btn_Obrot.Location = new System.Drawing.Point(623, 204);
            this.btn_Obrot.Name = "btn_Obrot";
            this.btn_Obrot.Size = new System.Drawing.Size(75, 23);
            this.btn_Obrot.TabIndex = 4;
            this.btn_Obrot.Text = "Obróć";
            this.btn_Obrot.UseVisualStyleBackColor = true;
            // 
            // btn_Dalej
            // 
            this.btn_Dalej.Location = new System.Drawing.Point(623, 245);
            this.btn_Dalej.Name = "btn_Dalej";
            this.btn_Dalej.Size = new System.Drawing.Size(75, 23);
            this.btn_Dalej.TabIndex = 5;
            this.btn_Dalej.Text = "Dalej";
            this.btn_Dalej.UseVisualStyleBackColor = true;
            // 
            // planszaGracza
            // 
            this.planszaGracza.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.planszaGracza.Image = global::ShipsGame.Properties.Resources.board;
            this.planszaGracza.Location = new System.Drawing.Point(55, 12);
            this.planszaGracza.Name = "planszaGracza";
            this.planszaGracza.Size = new System.Drawing.Size(400, 400);
            this.planszaGracza.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.planszaGracza.TabIndex = 0;
            this.planszaGracza.TabStop = false;
            // 
            // UstawieniaStatkow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Dalej);
            this.Controls.Add(this.btn_Obrot);
            this.Controls.Add(this.lb_WpiszNazwe);
            this.Controls.Add(this.txt_NazwaGracza);
            this.Controls.Add(this.lb_Gracz);
            this.Controls.Add(this.planszaGracza);
            this.Name = "UstawieniaStatkow";
            this.Text = "UstawieniaStatkow";
            this.Load += new System.EventHandler(this.UstawieniaStatkow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.planszaGracza)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox planszaGracza;
        private System.Windows.Forms.Label lb_Gracz;
        private System.Windows.Forms.TextBox txt_NazwaGracza;
        private System.Windows.Forms.Label lb_WpiszNazwe;
        private System.Windows.Forms.Button btn_Obrot;
        private System.Windows.Forms.Button btn_Dalej;
    }
}