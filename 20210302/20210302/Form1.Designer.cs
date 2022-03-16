namespace _20210302
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
            this.cbox = new System.Windows.Forms.ComboBox();
            this.grbDDS = new System.Windows.Forms.GroupBox();
            this.radiosimple = new System.Windows.Forms.RadioButton();
            this.radiodd = new System.Windows.Forms.RadioButton();
            this.radioDDL = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDDS = new System.Windows.Forms.Button();
            this.btnfeltolt = new System.Windows.Forms.Button();
            this.btnmentes = new System.Windows.Forms.Button();
            this.btnbeolvas = new System.Windows.Forms.Button();
            this.btnkilep = new System.Windows.Forms.Button();
            this.btntorol = new System.Windows.Forms.Button();
            this.grbt = new System.Windows.Forms.GroupBox();
            this.radiotext = new System.Windows.Forms.RadioButton();
            this.radiokijelolt = new System.Windows.Forms.RadioButton();
            this.radioossz = new System.Windows.Forms.RadioButton();
            this.btnbeszur = new System.Windows.Forms.Button();
            this.btnhozzaad = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.grbDDS.SuspendLayout();
            this.grbt.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbox
            // 
            this.cbox.FormattingEnabled = true;
            this.cbox.Location = new System.Drawing.Point(23, 66);
            this.cbox.Name = "cbox";
            this.cbox.Size = new System.Drawing.Size(151, 21);
            this.cbox.TabIndex = 0;
            // 
            // grbDDS
            // 
            this.grbDDS.Controls.Add(this.radioDDL);
            this.grbDDS.Controls.Add(this.radiodd);
            this.grbDDS.Controls.Add(this.radiosimple);
            this.grbDDS.Location = new System.Drawing.Point(23, 127);
            this.grbDDS.Name = "grbDDS";
            this.grbDDS.Size = new System.Drawing.Size(151, 150);
            this.grbDDS.TabIndex = 1;
            this.grbDDS.TabStop = false;
            this.grbDDS.Text = "DropDownStyle";
            // 
            // radiosimple
            // 
            this.radiosimple.AutoSize = true;
            this.radiosimple.Checked = true;
            this.radiosimple.Location = new System.Drawing.Point(6, 38);
            this.radiosimple.Name = "radiosimple";
            this.radiosimple.Size = new System.Drawing.Size(56, 17);
            this.radiosimple.TabIndex = 0;
            this.radiosimple.TabStop = true;
            this.radiosimple.Text = "Simple";
            this.radiosimple.UseVisualStyleBackColor = true;
            this.radiosimple.CheckedChanged += new System.EventHandler(this.radiosimple_CheckedChanged);
            // 
            // radiodd
            // 
            this.radiodd.AutoSize = true;
            this.radiodd.Location = new System.Drawing.Point(6, 78);
            this.radiodd.Name = "radiodd";
            this.radiodd.Size = new System.Drawing.Size(76, 17);
            this.radiodd.TabIndex = 1;
            this.radiodd.Text = "DropDown";
            this.radiodd.UseVisualStyleBackColor = true;
            this.radiodd.CheckedChanged += new System.EventHandler(this.radiodd_CheckedChanged);
            // 
            // radioDDL
            // 
            this.radioDDL.AutoSize = true;
            this.radioDDL.Location = new System.Drawing.Point(6, 117);
            this.radioDDL.Name = "radioDDL";
            this.radioDDL.Size = new System.Drawing.Size(92, 17);
            this.radioDDL.TabIndex = 2;
            this.radioDDL.Text = "DropDownList";
            this.radioDDL.UseVisualStyleBackColor = true;
            this.radioDDL.CheckedChanged += new System.EventHandler(this.radioDDL_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 309);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "DropDownStyle";
            // 
            // btnDDS
            // 
            this.btnDDS.Location = new System.Drawing.Point(38, 337);
            this.btnDDS.Name = "btnDDS";
            this.btnDDS.Size = new System.Drawing.Size(127, 28);
            this.btnDDS.TabIndex = 3;
            this.btnDDS.Text = "Simple";
            this.btnDDS.UseVisualStyleBackColor = true;
            this.btnDDS.Click += new System.EventHandler(this.btnDDS_Click);
            // 
            // btnfeltolt
            // 
            this.btnfeltolt.Location = new System.Drawing.Point(226, 38);
            this.btnfeltolt.Name = "btnfeltolt";
            this.btnfeltolt.Size = new System.Drawing.Size(112, 28);
            this.btnfeltolt.TabIndex = 4;
            this.btnfeltolt.Text = "Feltöltés";
            this.btnfeltolt.UseVisualStyleBackColor = true;
            this.btnfeltolt.Click += new System.EventHandler(this.btnfeltolt_Click);
            // 
            // btnmentes
            // 
            this.btnmentes.Location = new System.Drawing.Point(226, 96);
            this.btnmentes.Name = "btnmentes";
            this.btnmentes.Size = new System.Drawing.Size(112, 28);
            this.btnmentes.TabIndex = 5;
            this.btnmentes.Text = "Mentés";
            this.btnmentes.UseVisualStyleBackColor = true;
            this.btnmentes.Click += new System.EventHandler(this.btnmentes_Click);
            // 
            // btnbeolvas
            // 
            this.btnbeolvas.Location = new System.Drawing.Point(226, 160);
            this.btnbeolvas.Name = "btnbeolvas";
            this.btnbeolvas.Size = new System.Drawing.Size(112, 28);
            this.btnbeolvas.TabIndex = 6;
            this.btnbeolvas.Text = "Beolvasás";
            this.btnbeolvas.UseVisualStyleBackColor = true;
            this.btnbeolvas.Click += new System.EventHandler(this.btnbeolvas_Click);
            // 
            // btnkilep
            // 
            this.btnkilep.Location = new System.Drawing.Point(431, 354);
            this.btnkilep.Name = "btnkilep";
            this.btnkilep.Size = new System.Drawing.Size(112, 28);
            this.btnkilep.TabIndex = 7;
            this.btnkilep.Text = "Kilépés";
            this.btnkilep.UseVisualStyleBackColor = true;
            this.btnkilep.Click += new System.EventHandler(this.btnkilep_Click);
            // 
            // btntorol
            // 
            this.btntorol.Location = new System.Drawing.Point(226, 221);
            this.btntorol.Name = "btntorol";
            this.btntorol.Size = new System.Drawing.Size(112, 28);
            this.btntorol.TabIndex = 8;
            this.btntorol.Text = "Törlés";
            this.btntorol.UseVisualStyleBackColor = true;
            this.btntorol.Click += new System.EventHandler(this.btntorol_Click);
            // 
            // grbt
            // 
            this.grbt.Controls.Add(this.radiotext);
            this.grbt.Controls.Add(this.radiokijelolt);
            this.grbt.Controls.Add(this.radioossz);
            this.grbt.Location = new System.Drawing.Point(392, 127);
            this.grbt.Name = "grbt";
            this.grbt.Size = new System.Drawing.Size(151, 150);
            this.grbt.TabIndex = 9;
            this.grbt.TabStop = false;
            this.grbt.Text = "Törlés";
            // 
            // radiotext
            // 
            this.radiotext.AutoSize = true;
            this.radiotext.Location = new System.Drawing.Point(6, 117);
            this.radiotext.Name = "radiotext";
            this.radiotext.Size = new System.Drawing.Size(68, 17);
            this.radiotext.TabIndex = 2;
            this.radiotext.Text = "Text rész";
            this.radiotext.UseVisualStyleBackColor = true;
            // 
            // radiokijelolt
            // 
            this.radiokijelolt.AutoSize = true;
            this.radiokijelolt.Location = new System.Drawing.Point(6, 78);
            this.radiokijelolt.Name = "radiokijelolt";
            this.radiokijelolt.Size = new System.Drawing.Size(55, 17);
            this.radiokijelolt.TabIndex = 1;
            this.radiokijelolt.Text = "Kijelölt";
            this.radiokijelolt.UseVisualStyleBackColor = true;
            // 
            // radioossz
            // 
            this.radioossz.AutoSize = true;
            this.radioossz.Checked = true;
            this.radioossz.Location = new System.Drawing.Point(6, 38);
            this.radioossz.Name = "radioossz";
            this.radioossz.Size = new System.Drawing.Size(59, 17);
            this.radioossz.TabIndex = 0;
            this.radioossz.TabStop = true;
            this.radioossz.Text = "Összes";
            this.radioossz.UseVisualStyleBackColor = true;
            // 
            // btnbeszur
            // 
            this.btnbeszur.Location = new System.Drawing.Point(226, 355);
            this.btnbeszur.Name = "btnbeszur";
            this.btnbeszur.Size = new System.Drawing.Size(112, 28);
            this.btnbeszur.TabIndex = 10;
            this.btnbeszur.Text = "Beszúr";
            this.btnbeszur.UseVisualStyleBackColor = true;
            this.btnbeszur.Click += new System.EventHandler(this.btnbeszur_Click);
            // 
            // btnhozzaad
            // 
            this.btnhozzaad.Location = new System.Drawing.Point(226, 279);
            this.btnhozzaad.Name = "btnhozzaad";
            this.btnhozzaad.Size = new System.Drawing.Size(112, 28);
            this.btnhozzaad.TabIndex = 11;
            this.btnhozzaad.Text = "Hozzáad";
            this.btnhozzaad.UseVisualStyleBackColor = true;
            this.btnhozzaad.Click += new System.EventHandler(this.btnhozzaad_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(208, 329);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(153, 20);
            this.textBox1.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 395);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnhozzaad);
            this.Controls.Add(this.btnbeszur);
            this.Controls.Add(this.grbt);
            this.Controls.Add(this.btntorol);
            this.Controls.Add(this.btnkilep);
            this.Controls.Add(this.btnbeolvas);
            this.Controls.Add(this.btnmentes);
            this.Controls.Add(this.btnfeltolt);
            this.Controls.Add(this.btnDDS);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grbDDS);
            this.Controls.Add(this.cbox);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ComboBox";
            this.grbDDS.ResumeLayout(false);
            this.grbDDS.PerformLayout();
            this.grbt.ResumeLayout(false);
            this.grbt.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbox;
        private System.Windows.Forms.GroupBox grbDDS;
        private System.Windows.Forms.RadioButton radioDDL;
        private System.Windows.Forms.RadioButton radiodd;
        private System.Windows.Forms.RadioButton radiosimple;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDDS;
        private System.Windows.Forms.Button btnfeltolt;
        private System.Windows.Forms.Button btnmentes;
        private System.Windows.Forms.Button btnbeolvas;
        private System.Windows.Forms.Button btnkilep;
        private System.Windows.Forms.Button btntorol;
        private System.Windows.Forms.GroupBox grbt;
        private System.Windows.Forms.RadioButton radiotext;
        private System.Windows.Forms.RadioButton radiokijelolt;
        private System.Windows.Forms.RadioButton radioossz;
        private System.Windows.Forms.Button btnbeszur;
        private System.Windows.Forms.Button btnhozzaad;
        private System.Windows.Forms.TextBox textBox1;
    }
}

