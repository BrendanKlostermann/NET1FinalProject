
namespace AmmoReloader
{
    partial class frmReloadScreen
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
            this.btnReload = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.txtCharge = new System.Windows.Forms.TextBox();
            this.txtPrimer = new System.Windows.Forms.TextBox();
            this.txtLength = new System.Windows.Forms.TextBox();
            this.lblWeight = new System.Windows.Forms.Label();
            this.lblCharge = new System.Windows.Forms.Label();
            this.lblPrimer = new System.Windows.Forms.Label();
            this.lblLength = new System.Windows.Forms.Label();
            this.lblAmmotype = new System.Windows.Forms.Label();
            this.lblReloadAmount = new System.Windows.Forms.Label();
            this.numReloadAmount = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numReloadAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // btnReload
            // 
            this.btnReload.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnReload.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReload.Location = new System.Drawing.Point(57, 519);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(103, 41);
            this.btnReload.TabIndex = 5;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = false;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(266, 519);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(103, 41);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(266, 119);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.ReadOnly = true;
            this.txtWeight.Size = new System.Drawing.Size(119, 22);
            this.txtWeight.TabIndex = 7;
            // 
            // txtCharge
            // 
            this.txtCharge.Location = new System.Drawing.Point(266, 186);
            this.txtCharge.Name = "txtCharge";
            this.txtCharge.ReadOnly = true;
            this.txtCharge.Size = new System.Drawing.Size(119, 22);
            this.txtCharge.TabIndex = 8;
            // 
            // txtPrimer
            // 
            this.txtPrimer.Location = new System.Drawing.Point(266, 260);
            this.txtPrimer.Name = "txtPrimer";
            this.txtPrimer.ReadOnly = true;
            this.txtPrimer.Size = new System.Drawing.Size(119, 22);
            this.txtPrimer.TabIndex = 9;
            // 
            // txtLength
            // 
            this.txtLength.Location = new System.Drawing.Point(266, 330);
            this.txtLength.Name = "txtLength";
            this.txtLength.ReadOnly = true;
            this.txtLength.Size = new System.Drawing.Size(119, 22);
            this.txtLength.TabIndex = 10;
            // 
            // lblWeight
            // 
            this.lblWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeight.Location = new System.Drawing.Point(91, 118);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(133, 23);
            this.lblWeight.TabIndex = 11;
            this.lblWeight.Text = "Projectile Weight";
            // 
            // lblCharge
            // 
            this.lblCharge.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCharge.Location = new System.Drawing.Point(91, 185);
            this.lblCharge.Name = "lblCharge";
            this.lblCharge.Size = new System.Drawing.Size(133, 23);
            this.lblCharge.TabIndex = 12;
            this.lblCharge.Text = "Charge (grams)";
            // 
            // lblPrimer
            // 
            this.lblPrimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrimer.Location = new System.Drawing.Point(91, 259);
            this.lblPrimer.Name = "lblPrimer";
            this.lblPrimer.Size = new System.Drawing.Size(100, 23);
            this.lblPrimer.TabIndex = 13;
            this.lblPrimer.Text = "Primer Type";
            // 
            // lblLength
            // 
            this.lblLength.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLength.Location = new System.Drawing.Point(91, 329);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(100, 23);
            this.lblLength.TabIndex = 14;
            this.lblLength.Text = "Case Length";
            // 
            // lblAmmotype
            // 
            this.lblAmmotype.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblAmmotype.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmmotype.Location = new System.Drawing.Point(126, 21);
            this.lblAmmotype.Name = "lblAmmotype";
            this.lblAmmotype.Size = new System.Drawing.Size(190, 58);
            this.lblAmmotype.TabIndex = 15;
            this.lblAmmotype.Text = "label1";
            this.lblAmmotype.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblReloadAmount
            // 
            this.lblReloadAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReloadAmount.Location = new System.Drawing.Point(91, 435);
            this.lblReloadAmount.Name = "lblReloadAmount";
            this.lblReloadAmount.Size = new System.Drawing.Size(100, 23);
            this.lblReloadAmount.TabIndex = 16;
            this.lblReloadAmount.Text = "Amount";
            // 
            // numReloadAmount
            // 
            this.numReloadAmount.Location = new System.Drawing.Point(266, 433);
            this.numReloadAmount.Name = "numReloadAmount";
            this.numReloadAmount.Size = new System.Drawing.Size(120, 22);
            this.numReloadAmount.TabIndex = 17;
            // 
            // frmReloadScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(443, 607);
            this.Controls.Add(this.numReloadAmount);
            this.Controls.Add(this.lblReloadAmount);
            this.Controls.Add(this.lblAmmotype);
            this.Controls.Add(this.lblLength);
            this.Controls.Add(this.lblPrimer);
            this.Controls.Add(this.lblCharge);
            this.Controls.Add(this.lblWeight);
            this.Controls.Add(this.txtLength);
            this.Controls.Add(this.txtPrimer);
            this.Controls.Add(this.txtCharge);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnReload);
            this.Name = "frmReloadScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reload Information";
            this.Load += new System.EventHandler(this.frmReloadScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numReloadAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.TextBox txtCharge;
        private System.Windows.Forms.TextBox txtPrimer;
        private System.Windows.Forms.TextBox txtLength;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label lblCharge;
        private System.Windows.Forms.Label lblPrimer;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.Label lblAmmotype;
        private System.Windows.Forms.Label lblReloadAmount;
        private System.Windows.Forms.NumericUpDown numReloadAmount;
    }
}