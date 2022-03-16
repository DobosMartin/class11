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

namespace _20210302
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radiosimple_CheckedChanged(object sender, EventArgs e)
        {
            btnDDS.Text = "Simple";
            cbox.DropDownStyle = ComboBoxStyle.Simple;
        }

        private void radiodd_CheckedChanged(object sender, EventArgs e)
        {
            btnDDS.Text = "DropDown";
            cbox.DropDownStyle = ComboBoxStyle.DropDown;
        }

        private void radioDDL_CheckedChanged(object sender, EventArgs e)
        {
            btnDDS.Text = "DropDownList";
            cbox.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnDDS_Click(object sender, EventArgs e)
        {
            switch (btnDDS.Text)
            {
                case "Simple":
                    radiodd.Checked = true;

                    break;

                case "DropDown":
                    radioDDL.Checked = true;

                    break;

                case "DropDownList":
                    radiosimple.Checked = true;

                    break;

                default:
                    break;
            }
        }

        private void btnkilep_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnfeltolt_Click(object sender, EventArgs e)
        {
            int a = cbox.Items.Count;
            for (int i = 0; i < 11; i++)
            {
                cbox.Items.Add(i + a);
            }
        }

        private void btnmentes_Click(object sender, EventArgs e)
        {
            List<string> kiir = new List<string>();
            foreach (var item in cbox.Items)
            {
                kiir.Add(item.ToString());
                File.AppendAllText("lista2.txt", item.ToString() + "\n");
            }
            File.WriteAllLines("lista.txt", kiir);
        }

        private void btnbeolvas_Click(object sender, EventArgs e)
        {
            string[] beolvas = File.ReadAllLines("lista.txt");
            for (int i = 0; i < beolvas.Length; i++)
            {
                cbox.Items.Add(beolvas[i]);
            }
        }

        private void btntorol_Click(object sender, EventArgs e)
        {
            if (radioossz.Checked)
            {
                cbox.Items.Clear();
                cbox.IntegralHeight = false;
            }
            else if (radiokijelolt.Checked)
            {
                cbox.Items.Remove(cbox.SelectedItem);
            }
            else
            {
                cbox.Text = "";
            }
        }

        private void btnhozzaad_Click(object sender, EventArgs e)
        {
            cbox.Items.Add(cbox.Text);
        }

        private void btnbeszur_Click(object sender, EventArgs e)
        {
            if (cbox.SelectedIndex != -1)
            {
                cbox.Items.Insert(cbox.SelectedIndex, textBox1.Text);
            }

        }
    }
}
