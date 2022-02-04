using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PremieBerekenenVanDuits
{
    public partial class FrmPremieBerekenenVan : Form
    {
        public FrmPremieBerekenenVan()
        {
            InitializeComponent();
        }

        private void FrmPremieBerekenenVan_Load(object sender, EventArgs e)
        {
            txtEigendomswaarden.Text = "De waarde van het eigendom";
        }

        private void txtEigendomswaarden_Click(object sender, EventArgs e)
        {
            txtEigendomswaarden.Text = "";
        }

        private void cbRegio_MouseEnter(object sender, EventArgs e)
        {
            txtKortingen.Visible = true;
        }

        private void cbRegio_MouseLeave(object sender, EventArgs e)
        {
            txtKortingen.Visible = false;
        }

        private void tbKorting_TextChanged(object sender, EventArgs e)
        {
            switch (txtKorting.te)
            {
                case ("Noord"):
                    txtKorting.Text = "25%";
                    break;

                case ("Midden"):
                    txtKorting.Text = "10%";
                    break;

                case ("Zuid"):
                    txtKorting.Text = "15%";
                    break;
            }
        }
    }
}