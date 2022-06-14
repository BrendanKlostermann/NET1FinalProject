using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicLayer;
using DataObjects;

namespace AmmoReloader
{
    public partial class frmReloadScreen : Form

    {
        int _currentAmmo = -1;
        
        public frmReloadScreen(int ca)
        {
            _currentAmmo = ca;
            InitializeComponent();
        }

        public void ShowAmmo()
        {
            try
            {
                Ammo _ammo = new Ammo();
                _ammo = AmmoLogic.FetchAmmoItem(_currentAmmo);
                lblAmmotype.Text = _ammo.ammoType;
                txtWeight.Text = _ammo.ammoWeight;
                txtCharge.Text = _ammo.ammoCharge;
                txtPrimer.Text = _ammo.ammoPrimer;
                txtLength.Text = _ammo.ammoLength;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.InnerException.Message);
            }
        }

        private void frmReloadScreen_Load(object sender, EventArgs e)
        {
            ShowAmmo();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            int amount = (int)numReloadAmount.Value;
            int totalProjectile = amount;
            double totalPowder = AmmoLogic.TotalCharge(txtCharge.Text,amount);
            int totalPrimer = amount;
            int totalCase = amount;

            MessageBox.Show("Total Projectiles: " + totalProjectile + "\nTotal powder: " + totalPowder
                + " grams\nTotal primers: " + totalPrimer + "\nTotal cases: " + totalCase, "Total output",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
