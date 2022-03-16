namespace _20210521
{
    partial class form1
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
            this.lbl_valassz = new System.Windows.Forms.Label();
            this.lbl_csoport = new System.Windows.Forms.Label();
            this.lbl_Nemzet = new System.Windows.Forms.Label();
            this.lbl_nemzetkod = new System.Windows.Forms.Label();
            this.lbl_sorozat = new System.Windows.Forms.Label();
            this.lbl_eredmeny = new System.Windows.Forms.Label();
            this.cbx_versenyzo = new System.Windows.Forms.ComboBox();
            this.pic_zaszlo = new System.Windows.Forms.PictureBox();
            this.lbl_zaszlo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic_zaszlo)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_valassz
            // 
            this.lbl_valassz.AutoSize = true;
            this.lbl_valassz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_valassz.Location = new System.Drawing.Point(32, 50);
            this.lbl_valassz.Name = "lbl_valassz";
            this.lbl_valassz.Size = new System.Drawing.Size(167, 20);
            this.lbl_valassz.TabIndex = 0;
            this.lbl_valassz.Text = "Válasszon versenyzőt!";
            // 
            // lbl_csoport
            // 
            this.lbl_csoport.AutoSize = true;
            this.lbl_csoport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_csoport.Location = new System.Drawing.Point(32, 139);
            this.lbl_csoport.Name = "lbl_csoport";
            this.lbl_csoport.Size = new System.Drawing.Size(69, 20);
            this.lbl_csoport.TabIndex = 1;
            this.lbl_csoport.Text = "Csoport:";
            // 
            // lbl_Nemzet
            // 
            this.lbl_Nemzet.AutoSize = true;
            this.lbl_Nemzet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_Nemzet.Location = new System.Drawing.Point(32, 190);
            this.lbl_Nemzet.Name = "lbl_Nemzet";
            this.lbl_Nemzet.Size = new System.Drawing.Size(68, 20);
            this.lbl_Nemzet.TabIndex = 2;
            this.lbl_Nemzet.Text = "Nemzet:";
            // 
            // lbl_nemzetkod
            // 
            this.lbl_nemzetkod.AutoSize = true;
            this.lbl_nemzetkod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_nemzetkod.Location = new System.Drawing.Point(32, 245);
            this.lbl_nemzetkod.Name = "lbl_nemzetkod";
            this.lbl_nemzetkod.Size = new System.Drawing.Size(98, 20);
            this.lbl_nemzetkod.TabIndex = 3;
            this.lbl_nemzetkod.Text = "Nemzet kód:";
            // 
            // lbl_sorozat
            // 
            this.lbl_sorozat.AutoSize = true;
            this.lbl_sorozat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_sorozat.Location = new System.Drawing.Point(32, 296);
            this.lbl_sorozat.Name = "lbl_sorozat";
            this.lbl_sorozat.Size = new System.Drawing.Size(69, 20);
            this.lbl_sorozat.TabIndex = 4;
            this.lbl_sorozat.Text = "Sorozat:";
            // 
            // lbl_eredmeny
            // 
            this.lbl_eredmeny.AutoSize = true;
            this.lbl_eredmeny.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_eredmeny.Location = new System.Drawing.Point(32, 346);
            this.lbl_eredmeny.Name = "lbl_eredmeny";
            this.lbl_eredmeny.Size = new System.Drawing.Size(85, 20);
            this.lbl_eredmeny.TabIndex = 5;
            this.lbl_eredmeny.Text = "Eredmény:";
            // 
            // cbx_versenyzo
            // 
            this.cbx_versenyzo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbx_versenyzo.FormattingEnabled = true;
            this.cbx_versenyzo.Location = new System.Drawing.Point(36, 83);
            this.cbx_versenyzo.Name = "cbx_versenyzo";
            this.cbx_versenyzo.Size = new System.Drawing.Size(230, 28);
            this.cbx_versenyzo.TabIndex = 6;
            this.cbx_versenyzo.SelectedIndexChanged += new System.EventHandler(this.Cbx_versenyzo_SelectedIndexChanged);
            // 
            // pic_zaszlo
            // 
            this.pic_zaszlo.Location = new System.Drawing.Point(98, 392);
            this.pic_zaszlo.Name = "pic_zaszlo";
            this.pic_zaszlo.Size = new System.Drawing.Size(79, 47);
            this.pic_zaszlo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_zaszlo.TabIndex = 7;
            this.pic_zaszlo.TabStop = false;
            // 
            // lbl_zaszlo
            // 
            this.lbl_zaszlo.AutoSize = true;
            this.lbl_zaszlo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_zaszlo.Location = new System.Drawing.Point(32, 404);
            this.lbl_zaszlo.Name = "lbl_zaszlo";
            this.lbl_zaszlo.Size = new System.Drawing.Size(60, 20);
            this.lbl_zaszlo.TabIndex = 8;
            this.lbl_zaszlo.Text = "Zászló:";
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 483);
            this.Controls.Add(this.lbl_zaszlo);
            this.Controls.Add(this.pic_zaszlo);
            this.Controls.Add(this.cbx_versenyzo);
            this.Controls.Add(this.lbl_eredmeny);
            this.Controls.Add(this.lbl_sorozat);
            this.Controls.Add(this.lbl_nemzetkod);
            this.Controls.Add(this.lbl_Nemzet);
            this.Controls.Add(this.lbl_csoport);
            this.Controls.Add(this.lbl_valassz);
            this.Name = "form1";
            this.Text = "London 2012 - Férfi kalapácsvetés - selejtező";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_zaszlo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_valassz;
        private System.Windows.Forms.Label lbl_csoport;
        private System.Windows.Forms.Label lbl_Nemzet;
        private System.Windows.Forms.Label lbl_nemzetkod;
        private System.Windows.Forms.Label lbl_sorozat;
        private System.Windows.Forms.Label lbl_eredmeny;
        private System.Windows.Forms.ComboBox cbx_versenyzo;
        private System.Windows.Forms.PictureBox pic_zaszlo;
        private System.Windows.Forms.Label lbl_zaszlo;
    }
}

