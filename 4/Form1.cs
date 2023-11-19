using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonGoster1_Click(object sender, EventArgs e)
        {
            string secim = "Seçilenler:";
            if (checkBoxAlısveris.Checked == true)
                secim += "\nAlışveriş";
            if (checkBoxSpor.Checked == true)
                secim += "\nSpor";
            if (checkBoxDers.Checked == true)
                secim += "\nDers";

            checkBoxAlısveris.Checked = false;
            checkBoxDers.Checked = false;
            checkBoxSpor.Checked = false;

            MessageBox.Show(secim);
            
        }

        private void buttonGoster2_Click(object sender, EventArgs e)
        {
            string secim2= "";
            int seciliElemanSayisi = checkedListBoxYapilacaklar.CheckedItems.Count;
            for(int i =0; i<seciliElemanSayisi; i++)
            {
                secim2 += "Seçim:" + (i + 1).ToString() + " =" +
                    checkedListBoxYapilacaklar.CheckedItems[i].ToString() + "\n";
            }
            int elemanSayisi = checkedListBoxYapilacaklar.Items.Count;

            for(int j=0; j<elemanSayisi; j++)
            {
                checkedListBoxYapilacaklar.SetItemChecked(j, false);
            }

            MessageBox.Show(secim2);
            
        }
    }
}
