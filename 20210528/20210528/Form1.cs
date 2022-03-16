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

namespace _20210528
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Lbl_szavakszama_Click(object sender, EventArgs e)
        {
            
        }

        private void Lbx_tizenharom_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Btn_torles_Click(object sender, EventArgs e)
        {
            if (rbn_elso.Checked)
            {
                comboBox1.Items.Clear();
            }
            else if( rbn_masodik.Checked)
            {
                lbx_tizenharom.Items.Clear();
            }
            else
            {
                comboBox1.Items.Clear();
                lbx_tizenharom.Items.Clear();
            }
        }

        private void Btn_kilep_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 1; i < 14; i++)
            {
                lbx_tizenharom.Items.Add(i);
            }
            comboBox1.Focus();
        }

        private void Btn_hozzaad_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text!="")
            {
                comboBox1.Items.Add(comboBox1.Text);
                comboBox1.Text = "";
            }
            else
            {
                MessageBox.Show("Nem írtál semmit!");
            }
        }

        private void ComboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                Btn_hozzaad_Click(sender, e);
            }
        }

        private void Btn_áthelyez_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex>=0)
            {
                lbx_tizenharom.Items.Add(comboBox1.SelectedItem);
                comboBox1.Items.Remove(comboBox1.SelectedItem);
            }
            else
            {
                MessageBox.Show("Nem jelöltél ki semmit!");
            }
        }

        private void Btn_rendez_Click(object sender, EventArgs e)
        {
            lbx_tizenharom.Sorted = true;
            lbx_tizenharom.Sorted = false;
        }

        private void Btn_mentes_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog()==DialogResult.OK)
            {
                foreach (var item in lbx_tizenharom.Items)
                {
                    File.AppendAllText(saveFileDialog1.FileName, item + "\n");
                }
            }
        }

        private void ComboBox1_TextChanged(object sender, EventArgs e)
        {
            string szoveg = comboBox1.Text;
            lbl_karakterszam.Text = szoveg.Length.ToString();
            lbl_szavakszama.Text = szoveg.Trim().Split(' ').Length.ToString();
        }
    }
}
