using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7_12_22_Razlomci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        
        private Razlomak UcitajPrvi()
        {
            int c, b, n;
            try
            {          
                if (txtCijeliBr1.Text == string.Empty)
                    c = 0;
                else
                    c = Int32.Parse(txtCijeliBr1.Text);
                if (txtBrojnik1.Text == string.Empty)
                   b = 0;
                else
                    b = Int32.Parse(txtBrojnik1.Text);
                if (txtNazivnik1.Text == string.Empty)
                    n = 0;
                else
                    n = Int32.Parse(txtNazivnik1.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Unesite broj!");
                return new Razlomak();
            }
            Razlomak razlomak1 = new Razlomak(c, b, n);
            return razlomak1;
        }

        private Razlomak UcitajDrugi()
        {
            int c, b, n;
            try
            {
                if (txtCijeliBr2.Text == string.Empty)
                    c = 0;
                else
                    c = Int32.Parse(txtCijeliBr2.Text);
                if (txtBrojnik2.Text == string.Empty)
                    b = 0;
                else
                    b = Int32.Parse(txtBrojnik2.Text);
                if (txtNazivnik2.Text == string.Empty)
                    n = 0;
                else
                    n = Int32.Parse(txtNazivnik2.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Unesite broj!");
                return new Razlomak();
            }
            Razlomak razlomak2 = new Razlomak(c, b, n);
            return razlomak2;
        }

        private void btnSkrati1_Click(object sender, EventArgs e)
        {
            try
            {
                Razlomak razlomak1 = UcitajPrvi();

                razlomak1.Skrati();
 
                if (razlomak1.CijeliBroj == 0)
                    txtCijeliBr1.Text = string.Empty;
                else
                    txtCijeliBr1.Text = Convert.ToString(razlomak1.CijeliBroj);

                if(razlomak1.Brojnik == 0)
                {
                    txtBrojnik1.Text = string.Empty;
                    txtNazivnik1.Text = string.Empty;
                }
                else
                {
                    txtBrojnik1.Text = Convert.ToString(razlomak1.Brojnik);
                    txtNazivnik1.Text = Convert.ToString(razlomak1.Nazivnik);
                }                    
            }
            catch (FormatException)
            {  
                MessageBox.Show("Unesite broj!"); 
            }
        }

        private void btnSkrati2_Click(object sender, EventArgs e)
        {
            try
            {
                Razlomak razlomak2 = UcitajDrugi();


                razlomak2.Skrati();

                if (razlomak2.CijeliBroj == 0)
                    txtCijeliBr2.Text = string.Empty;
                else
                    txtCijeliBr2.Text = Convert.ToString(razlomak2.CijeliBroj);

                if (razlomak2.Brojnik == 0)
                {
                    txtBrojnik2.Text = string.Empty;
                    txtNazivnik2.Text = string.Empty;
                }
                else
                {
                    txtBrojnik2.Text = Convert.ToString(razlomak2.Brojnik);
                    txtNazivnik2.Text = Convert.ToString(razlomak2.Nazivnik);
                }
            }
            catch (FormatException)
            {
                
                MessageBox.Show("Unesite broj!");
            }
        }

        private void btnZbroji_Click_1(object sender, EventArgs e)
        {
            Razlomak r1 = UcitajPrvi();
            Razlomak r2 = UcitajDrugi();
            Razlomak r3 = r1 + r2;

            if (r3.CijeliBroj == 0)
                txtCijeliBr3.Text = string.Empty;
            else
                txtCijeliBr3.Text = Convert.ToString(r3.CijeliBroj);

            if (r3.Brojnik == 0)
            {
                txtBrojnik3.Text = string.Empty;
                txtNazivnik3.Text = string.Empty;
            }
            else
            {
                txtBrojnik3.Text = Convert.ToString(r3.Brojnik);
                txtNazivnik3.Text = Convert.ToString(r3.Nazivnik);
            }

            txtCijeliBr3.Visible = true;
            txtBrojnik3.Visible = true;
            txtNazivnik3.Visible = true;

            txtCijeliBr3.Enabled = false;
            txtBrojnik3.Enabled = false;
            txtNazivnik3.Enabled = false;
        }
    }
}
