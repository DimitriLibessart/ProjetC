namespace Projet2
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.Nom = new System.Windows.Forms.TextBox();
            this.Valider = new System.Windows.Forms.Button();
            this.talk = new System.Windows.Forms.TextBox();
            this.tboxPers = new System.Windows.Forms.TextBox();
            this.BtnPers = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbtxt2 = new System.Windows.Forms.TextBox();
            this.Testbtn = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(33, 136);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(609, 392);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(714, 53);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(39, 53);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(809, 136);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(609, 392);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(503, 210);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(54, 66);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            // 
            // Nom
            // 
            this.Nom.Location = new System.Drawing.Point(23, 81);
            this.Nom.Name = "Nom";
            this.Nom.Size = new System.Drawing.Size(100, 20);
            this.Nom.TabIndex = 6;
            // 
            // Valider
            // 
            this.Valider.Location = new System.Drawing.Point(33, 107);
            this.Valider.Name = "Valider";
            this.Valider.Size = new System.Drawing.Size(75, 23);
            this.Valider.TabIndex = 7;
            this.Valider.Text = "Valider";
            this.Valider.UseVisualStyleBackColor = true;
            this.Valider.Click += new System.EventHandler(this.Valider_Click);
            // 
            // talk
            // 
            this.talk.Location = new System.Drawing.Point(12, 12);
            this.talk.Name = "talk";
            this.talk.Size = new System.Drawing.Size(630, 20);
            this.talk.TabIndex = 8;
            // 
            // tboxPers
            // 
            this.tboxPers.Location = new System.Drawing.Point(179, 81);
            this.tboxPers.Name = "tboxPers";
            this.tboxPers.Size = new System.Drawing.Size(28, 20);
            this.tboxPers.TabIndex = 9;
            // 
            // BtnPers
            // 
            this.BtnPers.Location = new System.Drawing.Point(156, 107);
            this.BtnPers.Name = "BtnPers";
            this.BtnPers.Size = new System.Drawing.Size(75, 23);
            this.BtnPers.TabIndex = 10;
            this.BtnPers.Text = "Valider";
            this.BtnPers.UseVisualStyleBackColor = true;
            this.BtnPers.Click += new System.EventHandler(this.BtnPers_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nom Prénom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(141, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Nombre de personnes";
            // 
            // tbtxt2
            // 
            this.tbtxt2.Location = new System.Drawing.Point(12, 38);
            this.tbtxt2.Name = "tbtxt2";
            this.tbtxt2.Size = new System.Drawing.Size(630, 20);
            this.tbtxt2.TabIndex = 13;
            // 
            // Testbtn
            // 
            this.Testbtn.Location = new System.Drawing.Point(392, 82);
            this.Testbtn.Name = "Testbtn";
            this.Testbtn.Size = new System.Drawing.Size(75, 23);
            this.Testbtn.TabIndex = 14;
            this.Testbtn.Text = "button1";
            this.Testbtn.UseVisualStyleBackColor = true;
            this.Testbtn.Click += new System.EventHandler(this.Testbtn_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(590, 288);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(52, 77);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 15;
            this.pictureBox5.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1546, 611);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.Testbtn);
            this.Controls.Add(this.tbtxt2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnPers);
            this.Controls.Add(this.tboxPers);
            this.Controls.Add(this.talk);
            this.Controls.Add(this.Valider);
            this.Controls.Add(this.Nom);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox Nom;
        private System.Windows.Forms.Button Valider;
        private System.Windows.Forms.TextBox talk;
        private System.Windows.Forms.TextBox tboxPers;
        private System.Windows.Forms.Button BtnPers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbtxt2;
        private System.Windows.Forms.Button Testbtn;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}

