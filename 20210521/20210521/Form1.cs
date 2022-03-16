using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _20210521
{
    public partial class form1 : Form
    {
        
        public form1()
        {
            InitializeComponent();
        }
        Versenyző[] versenyzők = new Versenyző[i];
        private void Form1_Load(object sender, EventArgs e)
        {
            string[] beolvas = File.ReadAllLines("Selejtezo2012.txt", Encoding.UTF8);
            versenyzők = new Versenyző[beolvas.Length - 1];
            for (int i = 0; i < versenyzők.Length; i++)
            {
                versenyzők[i] = new Versenyző(beolvas[i + 1]);
                cbx_versenyzo.Items.Add(versenyzők[i].Név);
            }
            for (int i = 0; i < versenyzők.Length; i++)
            {
                if (versenyzők[i].Név == "Pars Krisztián")
                {
                    cbx_versenyzo.Text = versenyzők[i].Név;
                    lbl_csoport.Text = "Csoport: " + versenyzők[i].Csoport.ToString();
                    lbl_Nemzet.Text = "Nemzet: " + versenyzők[i].Nemzet;
                    lbl_nemzetkod.Text = "Nemzeti Kód: " + versenyzők[i].Kód;
                    lbl_sorozat.Text = "Sorozat: " + versenyzők[i].Sorozat;
                    lbl_eredmeny.Text = "Eredmény: " + versenyzők[i].Eredmény.ToString();
                    pic_zaszlo.ImageLocation = "Images/Images/" + versenyzők[i].Kód + ".png";

                }
            }
        }

        private void Cbx_versenyzo_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < versenyzők.Length; i++)
            {
                if (versenyzők[i].Név == cbx_versenyzo.Selected.Items)
                {
                    cbx_versenyzo.Text = versenyzők[i].Név;
                    lbl_csoport.Text = "Csoport: " + versenyzők[i].Csoport.ToString();
                    lbl_Nemzet.Text = "Nemzet: " + versenyzők[i].Nemzet;
                    lbl_nemzetkod.Text = "Nemzeti Kód: " + versenyzők[i].Kód;
                    lbl_sorozat.Text = "Sorozat: " + versenyzők[i].Sorozat;
                    lbl_eredmeny.Text = "Eredmény: " + versenyzők[i].Eredmény.ToString();
                    pic_zaszlo.ImageLocation = "Images/Images/" + versenyzők[i].Kód + ".png";

                }
            }
        }
    }
}
