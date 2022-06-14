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
    public partial class frmModifyMenu : Form
    {
        int _currentAmmo = -1;

        public frmModifyMenu(int index)
        {
            _currentAmmo = index;
            InitializeComponent();
        }

        public void ShowAmmo()
        {
            try
            {
                Ammo _ammo = new Ammo();
                _ammo = AmmoLogic.FetchAmmoItem(_currentAmmo);
                lblModifyAmmotype.Text = _ammo.ammoType;
                txtModifyWeight.Text = _ammo.ammoWeight;
                txtModifyCharge.Text = _ammo.ammoCharge;
                txtModifyPrimer.Text = _ammo.ammoPrimer;
                txtModifyLength.Text = _ammo.ammoLength;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.InnerException.Message);
            }
        } // end of ShowAmmo()

        private void frmModifyMenu_Load(object sender, EventArgs e)
        {
            ShowAmmo();
        }

        private void btnModifyCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModifyAccept_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (txtModifyWeight.Text == "")
                {
                    MessageBox.Show("You must supply an ammo weight.", "Missing input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtModifyWeight.Focus();
                    return;
                }
                if (!AmmoLogic.CheckForNum(txtModifyWeight.Text))
                {
                    MessageBox.Show("Only numbers can be used for ammo weight", "Incorrect input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtModifyWeight.Focus();
                    return;
                }
                if (txtModifyCharge.Text == "")
                {
                    MessageBox.Show("You must supply an ammo powder charge.", "Missing input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtModifyCharge.Focus();
                    return;
                }
                if (!AmmoLogic.CheckForNum(txtModifyCharge.Text))
                {
                    MessageBox.Show("Only numbers can be used for powder charge", "Incorrect input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtModifyCharge.Focus();
                    return;
                }
                if (txtModifyPrimer.Text == "")
                {
                    MessageBox.Show("You must supply a primer type.", "Missing input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtModifyPrimer.Focus();
                    return;
                }
                if (txtModifyLength.Text == "")
                {
                    MessageBox.Show("You must supply a case length.", "Missing input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtModifyLength.Focus();
                    return;
                }
                if (!AmmoLogic.CheckForNum(txtModifyLength.Text))
                {
                    MessageBox.Show("Only numbers can be used for case length", "Incorrect input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtModifyLength.Focus();
                    return;
                }

                Ammo _ammo = new Ammo();
                _ammo = AmmoLogic.FetchAmmoItem(_currentAmmo);
                _ammo.ammoWeight = txtModifyWeight.Text;
                _ammo.ammoCharge = txtModifyCharge.Text;
                _ammo.ammoPrimer = txtModifyPrimer.Text;
                _ammo.ammoLength = txtModifyLength.Text;

                AmmoLogic.ModifyAmmo(_ammo, _currentAmmo);
                MessageBox.Show("Ammo has been saved", "Ammo saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                try
                {
                    if(AmmoLogic.ModifyAmmo(_ammo, _currentAmmo))
                    {
                        this.DialogResult = DialogResult.OK;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "\n\n" + ex.InnerException.Message,
                        "Save Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
                                    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.InnerException.Message, "Update failed.",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        } // end of accept button click

    } // end of class frmModifyMenu
}
