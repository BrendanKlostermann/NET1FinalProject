
namespace AmmoReloader
{
    partial class frmAddMenu
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
            this.txtAddType = new System.Windows.Forms.TextBox();
            this.lblAddName = new System.Windows.Forms.Label();
            this.lblAddWeight = new System.Windows.Forms.Label();
            this.txtAddWeight = new System.Windows.Forms.TextBox();
            this.lblAddCharge = new System.Windows.Forms.Label();
            this.txtAddCharge = new System.Windows.Forms.TextBox();
            this.lblAddPrimer = new System.Windows.Forms.Label();
            this.txtAddPrimer = new System.Windows.Forms.TextBox();
            this.lblAddLength = new System.Windows.Forms.Label();
            this.txtAddLength = new System.Windows.Forms.TextBox();
            this.btnAddAccept = new System.Windows.Forms.Button();
            this.btnAddCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtAddType
            // 
            this.txtAddType.Location = new System.Drawing.Point(245, 64);
            this.txtAddType.Name = "txtAddType";
            this.txtAddType.Size = new System.Drawing.Size(119, 22);
            this.txtAddType.TabIndex = 8;
            // 
            // lblAddName
            // 
            this.lblAddName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddName.Location = new System.Drawing.Point(68, 63);
            this.lblAddName.Name = "lblAddName";
            this.lblAddName.Size = new System.Drawing.Size(133, 23);
            this.lblAddName.TabIndex = 12;
            this.lblAddName.Text = "Name";
            // 
            // lblAddWeight
            // 
            this.lblAddWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddWeight.Location = new System.Drawing.Point(68, 136);
            this.lblAddWeight.Name = "lblAddWeight";
            this.lblAddWeight.Size = new System.Drawing.Size(133, 23);
            this.lblAddWeight.TabIndex = 14;
            this.lblAddWeight.Text = "Projectile Weight";
            // 
            // txtAddWeight
            // 
            this.txtAddWeight.Location = new System.Drawing.Point(245, 137);
            this.txtAddWeight.Name = "txtAddWeight";
            this.txtAddWeight.Size = new System.Drawing.Size(119, 22);
            this.txtAddWeight.TabIndex = 13;
            // 
            // lblAddCharge
            // 
            this.lblAddCharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddCharge.Location = new System.Drawing.Point(68, 224);
            this.lblAddCharge.Name = "lblAddCharge";
            this.lblAddCharge.Size = new System.Drawing.Size(133, 23);
            this.lblAddCharge.TabIndex = 16;
            this.lblAddCharge.Text = "Charge (grams)";
            // 
            // txtAddCharge
            // 
            this.txtAddCharge.Location = new System.Drawing.Point(245, 225);
            this.txtAddCharge.Name = "txtAddCharge";
            this.txtAddCharge.Size = new System.Drawing.Size(119, 22);
            this.txtAddCharge.TabIndex = 15;
            // 
            // lblAddPrimer
            // 
            this.lblAddPrimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddPrimer.Location = new System.Drawing.Point(68, 303);
            this.lblAddPrimer.Name = "lblAddPrimer";
            this.lblAddPrimer.Size = new System.Drawing.Size(133, 23);
            this.lblAddPrimer.TabIndex = 18;
            this.lblAddPrimer.Text = "Primer Type";
            // 
            // txtAddPrimer
            // 
            this.txtAddPrimer.Location = new System.Drawing.Point(245, 304);
            this.txtAddPrimer.Name = "txtAddPrimer";
            this.txtAddPrimer.Size = new System.Drawing.Size(119, 22);
            this.txtAddPrimer.TabIndex = 17;
            // 
            // lblAddLength
            // 
            this.lblAddLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddLength.Location = new System.Drawing.Point(68, 386);
            this.lblAddLength.Name = "lblAddLength";
            this.lblAddLength.Size = new System.Drawing.Size(133, 23);
            this.lblAddLength.TabIndex = 20;
            this.lblAddLength.Text = "Case Length";
            // 
            // txtAddLength
            // 
            this.txtAddLength.Location = new System.Drawing.Point(245, 387);
            this.txtAddLength.Name = "txtAddLength";
            this.txtAddLength.Size = new System.Drawing.Size(119, 22);
            this.txtAddLength.TabIndex = 19;
            // 
            // btnAddAccept
            // 
            this.btnAddAccept.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnAddAccept.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAccept.Location = new System.Drawing.Point(60, 502);
            this.btnAddAccept.Name = "btnAddAccept";
            this.btnAddAccept.Size = new System.Drawing.Size(103, 41);
            this.btnAddAccept.TabIndex = 21;
            this.btnAddAccept.Text = "Accept";
            this.btnAddAccept.UseVisualStyleBackColor = false;
            this.btnAddAccept.Click += new System.EventHandler(this.btnAddAccept_Click);
            // 
            // btnAddCancel
            // 
            this.btnAddCancel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnAddCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCancel.Location = new System.Drawing.Point(261, 502);
            this.btnAddCancel.Name = "btnAddCancel";
            this.btnAddCancel.Size = new System.Drawing.Size(103, 41);
            this.btnAddCancel.TabIndex = 22;
            this.btnAddCancel.Text = "Cancel";
            this.btnAddCancel.UseVisualStyleBackColor = false;
            this.btnAddCancel.Click += new System.EventHandler(this.btnAddCancel_Click);
            // 
            // frmAddMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(429, 609);
            this.Controls.Add(this.btnAddCancel);
            this.Controls.Add(this.btnAddAccept);
            this.Controls.Add(this.lblAddLength);
            this.Controls.Add(this.txtAddLength);
            this.Controls.Add(this.lblAddPrimer);
            this.Controls.Add(this.txtAddPrimer);
            this.Controls.Add(this.lblAddCharge);
            this.Controls.Add(this.txtAddCharge);
            this.Controls.Add(this.lblAddWeight);
            this.Controls.Add(this.txtAddWeight);
            this.Controls.Add(this.lblAddName);
            this.Controls.Add(this.txtAddType);
            this.Name = "frmAddMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Ammo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAddType;
        private System.Windows.Forms.Label lblAddName;
        private System.Windows.Forms.Label lblAddWeight;
        private System.Windows.Forms.TextBox txtAddWeight;
        private System.Windows.Forms.Label lblAddCharge;
        private System.Windows.Forms.TextBox txtAddCharge;
        private System.Windows.Forms.Label lblAddPrimer;
        private System.Windows.Forms.TextBox txtAddPrimer;
        private System.Windows.Forms.Label lblAddLength;
        private System.Windows.Forms.TextBox txtAddLength;
        private System.Windows.Forms.Button btnAddAccept;
        private System.Windows.Forms.Button btnAddCancel;
    }
}