namespace _20210528
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lbx_tizenharom = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_karakterszam = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_szavakszama = new System.Windows.Forms.Label();
            this.btn_hozzaad = new System.Windows.Forms.Button();
            this.btn_rendez = new System.Windows.Forms.Button();
            this.btn_áthelyez = new System.Windows.Forms.Button();
            this.btn_mentes = new System.Windows.Forms.Button();
            this.gbx_torles = new System.Windows.Forms.GroupBox();
            this.rbn_mindketto = new System.Windows.Forms.RadioButton();
            this.rbn_masodik = new System.Windows.Forms.RadioButton();
            this.rbn_elso = new System.Windows.Forms.RadioButton();
            this.btn_torles = new System.Windows.Forms.Button();
            this.btn_kilep = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.gbx_torles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(32, 49);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(156, 26);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.TextChanged += new System.EventHandler(this.ComboBox1_TextChanged);
            this.comboBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ComboBox1_KeyDown);
            // 
            // lbx_tizenharom
            // 
            this.lbx_tizenharom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbx_tizenharom.FormattingEnabled = true;
            this.lbx_tizenharom.ItemHeight = 18;
            this.lbx_tizenharom.Location = new System.Drawing.Point(32, 135);
            this.lbx_tizenharom.Name = "lbx_tizenharom";
            this.lbx_tizenharom.Size = new System.Drawing.Size(156, 310);
            this.lbx_tizenharom.TabIndex = 1;
            this.lbx_tizenharom.SelectedIndexChanged += new System.EventHandler(this.Lbx_tizenharom_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(258, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Karakterek száma:";
            // 
            // lbl_karakterszam
            // 
            this.lbl_karakterszam.AutoSize = true;
            this.lbl_karakterszam.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_karakterszam.Location = new System.Drawing.Point(270, 79);
            this.lbl_karakterszam.Name = "lbl_karakterszam";
            this.lbl_karakterszam.Size = new System.Drawing.Size(16, 18);
            this.lbl_karakterszam.TabIndex = 3;
            this.lbl_karakterszam.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(258, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Szavak száma:";
            // 
            // lbl_szavakszama
            // 
            this.lbl_szavakszama.AutoSize = true;
            this.lbl_szavakszama.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_szavakszama.Location = new System.Drawing.Point(270, 156);
            this.lbl_szavakszama.Name = "lbl_szavakszama";
            this.lbl_szavakszama.Size = new System.Drawing.Size(16, 18);
            this.lbl_szavakszama.TabIndex = 5;
            this.lbl_szavakszama.Text = "2";
            this.lbl_szavakszama.Click += new System.EventHandler(this.Lbl_szavakszama_Click);
            // 
            // btn_hozzaad
            // 
            this.btn_hozzaad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_hozzaad.Location = new System.Drawing.Point(434, 49);
            this.btn_hozzaad.Name = "btn_hozzaad";
            this.btn_hozzaad.Size = new System.Drawing.Size(97, 26);
            this.btn_hozzaad.TabIndex = 6;
            this.btn_hozzaad.Text = "Hozzáadás";
            this.btn_hozzaad.UseVisualStyleBackColor = true;
            this.btn_hozzaad.Click += new System.EventHandler(this.Btn_hozzaad_Click);
            // 
            // btn_rendez
            // 
            this.btn_rendez.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_rendez.Location = new System.Drawing.Point(434, 106);
            this.btn_rendez.Name = "btn_rendez";
            this.btn_rendez.Size = new System.Drawing.Size(97, 26);
            this.btn_rendez.TabIndex = 7;
            this.btn_rendez.Text = "Rendezés";
            this.btn_rendez.UseVisualStyleBackColor = true;
            this.btn_rendez.Click += new System.EventHandler(this.Btn_rendez_Click);
            // 
            // btn_áthelyez
            // 
            this.btn_áthelyez.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_áthelyez.Location = new System.Drawing.Point(434, 165);
            this.btn_áthelyez.Name = "btn_áthelyez";
            this.btn_áthelyez.Size = new System.Drawing.Size(97, 27);
            this.btn_áthelyez.TabIndex = 8;
            this.btn_áthelyez.Text = "Áthelyezés";
            this.btn_áthelyez.UseVisualStyleBackColor = true;
            this.btn_áthelyez.Click += new System.EventHandler(this.Btn_áthelyez_Click);
            // 
            // btn_mentes
            // 
            this.btn_mentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_mentes.Location = new System.Drawing.Point(434, 226);
            this.btn_mentes.Name = "btn_mentes";
            this.btn_mentes.Size = new System.Drawing.Size(97, 29);
            this.btn_mentes.TabIndex = 9;
            this.btn_mentes.Text = "Mentés";
            this.btn_mentes.UseVisualStyleBackColor = true;
            this.btn_mentes.Click += new System.EventHandler(this.Btn_mentes_Click);
            // 
            // gbx_torles
            // 
            this.gbx_torles.Controls.Add(this.rbn_mindketto);
            this.gbx_torles.Controls.Add(this.rbn_masodik);
            this.gbx_torles.Controls.Add(this.rbn_elso);
            this.gbx_torles.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbx_torles.Location = new System.Drawing.Point(413, 279);
            this.gbx_torles.Name = "gbx_torles";
            this.gbx_torles.Size = new System.Drawing.Size(134, 94);
            this.gbx_torles.TabIndex = 10;
            this.gbx_torles.TabStop = false;
            this.gbx_torles.Text = "Törlés";
            // 
            // rbn_mindketto
            // 
            this.rbn_mindketto.AutoSize = true;
            this.rbn_mindketto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbn_mindketto.Location = new System.Drawing.Point(6, 67);
            this.rbn_mindketto.Name = "rbn_mindketto";
            this.rbn_mindketto.Size = new System.Drawing.Size(91, 22);
            this.rbn_mindketto.TabIndex = 2;
            this.rbn_mindketto.TabStop = true;
            this.rbn_mindketto.Text = "Mindkettő";
            this.rbn_mindketto.UseVisualStyleBackColor = true;
            // 
            // rbn_masodik
            // 
            this.rbn_masodik.AutoSize = true;
            this.rbn_masodik.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbn_masodik.Location = new System.Drawing.Point(7, 43);
            this.rbn_masodik.Name = "rbn_masodik";
            this.rbn_masodik.Size = new System.Drawing.Size(103, 22);
            this.rbn_masodik.TabIndex = 1;
            this.rbn_masodik.TabStop = true;
            this.rbn_masodik.Text = "2. objektum";
            this.rbn_masodik.UseVisualStyleBackColor = true;
            // 
            // rbn_elso
            // 
            this.rbn_elso.AutoSize = true;
            this.rbn_elso.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbn_elso.Location = new System.Drawing.Point(6, 19);
            this.rbn_elso.Name = "rbn_elso";
            this.rbn_elso.Size = new System.Drawing.Size(103, 22);
            this.rbn_elso.TabIndex = 0;
            this.rbn_elso.TabStop = true;
            this.rbn_elso.Text = "1. objektum";
            this.rbn_elso.UseVisualStyleBackColor = true;
            // 
            // btn_torles
            // 
            this.btn_torles.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_torles.Location = new System.Drawing.Point(434, 397);
            this.btn_torles.Name = "btn_torles";
            this.btn_torles.Size = new System.Drawing.Size(97, 29);
            this.btn_torles.TabIndex = 11;
            this.btn_torles.Text = "Törlés";
            this.btn_torles.UseVisualStyleBackColor = true;
            this.btn_torles.Click += new System.EventHandler(this.Btn_torles_Click);
            // 
            // btn_kilep
            // 
            this.btn_kilep.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btn_kilep.Location = new System.Drawing.Point(434, 459);
            this.btn_kilep.Name = "btn_kilep";
            this.btn_kilep.Size = new System.Drawing.Size(97, 29);
            this.btn_kilep.TabIndex = 12;
            this.btn_kilep.Text = "Kilépés";
            this.btn_kilep.UseVisualStyleBackColor = true;
            this.btn_kilep.Click += new System.EventHandler(this.Btn_kilep_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::_20210528.Properties.Resources._03;
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.Location = new System.Drawing.Point(234, 202);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 133);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "txt";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 515);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_kilep);
            this.Controls.Add(this.btn_torles);
            this.Controls.Add(this.gbx_torles);
            this.Controls.Add(this.btn_mentes);
            this.Controls.Add(this.btn_áthelyez);
            this.Controls.Add(this.btn_rendez);
            this.Controls.Add(this.btn_hozzaad);
            this.Controls.Add(this.lbl_szavakszama);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_karakterszam);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbx_tizenharom);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "Dobos Martin";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbx_torles.ResumeLayout(false);
            this.gbx_torles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ListBox lbx_tizenharom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_karakterszam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_szavakszama;
        private System.Windows.Forms.Button btn_hozzaad;
        private System.Windows.Forms.Button btn_rendez;
        private System.Windows.Forms.Button btn_áthelyez;
        private System.Windows.Forms.Button btn_mentes;
        private System.Windows.Forms.GroupBox gbx_torles;
        private System.Windows.Forms.RadioButton rbn_mindketto;
        private System.Windows.Forms.RadioButton rbn_masodik;
        private System.Windows.Forms.RadioButton rbn_elso;
        private System.Windows.Forms.Button btn_torles;
        private System.Windows.Forms.Button btn_kilep;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

