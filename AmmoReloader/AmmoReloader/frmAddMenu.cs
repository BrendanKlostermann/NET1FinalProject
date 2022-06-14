using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataObjects;
using LogicLayer;

namespace AmmoReloader
{

    public partial class frmAddMenu : Form
    {
        List<Ammo> _ammoList = null;
        AmmoLogic _ammoManager = null;

        public frmAddMenu()
        {
            InitializeComponent();
        }

        public Ammo GetNewAmmo()
        {
            Ammo ammo = new Ammo();

            try
            {
                ammo.ammoType = txtAddType.Text;
                ammo.ammoWeight = txtAddWeight.Text;
                ammo.ammoCharge = txtAddCharge.Text;
                ammo.ammoPrimer = txtAddPrimer.Text;
                ammo.ammoLength = txtAddLength.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.InnerException.Message, "Could not create new ammo type",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            

            return ammo;
        }

        private void btnAddCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddAccept_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtAddType.Text == "")
                {
                    MessageBox.Show("You must supply an ammo type.", "Missing input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtAddType.Focus();
                    return;
                }
                if(txtAddWeight.Text == "" )
                {
                    MessageBox.Show("You must supply an ammo weight.", "Missing input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtAddWeight.Focus();
                    return;
                }
                if (!AmmoLogic.CheckForNum(txtAddWeight.Text))
                {
                    MessageBox.Show("Only numbers can be used for ammo weight", "Incorrect input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtAddWeight.Focus();
                    return;
                }
                if (txtAddCharge.Text == "")
                {
                    MessageBox.Show("You must supply an ammo powder charge.", "Missing input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtAddCharge.Focus();
                    return;
                }
                if (!AmmoLogic.CheckForNum(txtAddCharge.Text))
                {
                    MessageBox.Show("Only numbers can be used for powder charge", "Incorrect input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtAddCharge.Focus();
                    return;
                }
                if (txtAddPrimer.Text == "")
                {
                    MessageBox.Show("You must supply a primer type.", "Missing input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtAddPrimer.Focus();
                    return;
                }
                if (txtAddLength.Text == "")
                {
                    MessageBox.Show("You must supply a case length.", "Missing input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtAddLength.Focus();
                    return;
                }
                if (!AmmoLogic.CheckForNum(txtAddWeight.Text))
                {
                    MessageBox.Show("Only numbers can be used for case length", "Incorrect input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtAddLength.Focus();
                    return;
                }

                _ammoManager = new AmmoLogic();
                _ammoList = _ammoManager.FetchAmmoList();
                Ammo ammo = GetNewAmmo();
                _ammoList.Add(ammo);

                AmmoLogic.UpdateAmmoList(_ammoList);

                MessageBox.Show("New Ammo has been saved", "Ammo saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                try
                {
                    if (AmmoLogic.UpdateAmmoList(_ammoList))
                    {
                        this.DialogResult = DialogResult.OK;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "\n\n" + ex.InnerException.Message,
                        "Save Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // need to refresh list on frmMain

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + "\n" + ex.InnerException.Message, "Save failed.",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
