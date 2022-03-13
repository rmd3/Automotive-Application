
namespace D_Anjolell_6_5
{
    partial class Automotive
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkLube = new System.Windows.Forms.CheckBox();
            this.chkOil = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkTransmission = new System.Windows.Forms.CheckBox();
            this.chkRadiator = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkMuffler = new System.Windows.Forms.CheckBox();
            this.chkTire = new System.Windows.Forms.CheckBox();
            this.chkInspection = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblWarning = new System.Windows.Forms.Label();
            this.txtLabor = new System.Windows.Forms.TextBox();
            this.txtPartsCosts = new System.Windows.Forms.TextBox();
            this.lblLabor = new System.Windows.Forms.Label();
            this.lblPartsCosts = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.txtParts = new System.Windows.Forms.TextBox();
            this.txtService = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblParts = new System.Windows.Forms.Label();
            this.lblService = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkLube);
            this.groupBox1.Controls.Add(this.chkOil);
            this.groupBox1.Location = new System.Drawing.Point(169, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(220, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Oil and Lube";
            // 
            // chkLube
            // 
            this.chkLube.AutoSize = true;
            this.chkLube.Location = new System.Drawing.Point(7, 58);
            this.chkLube.Name = "chkLube";
            this.chkLube.Size = new System.Drawing.Size(143, 21);
            this.chkLube.TabIndex = 1;
            this.chkLube.Text = "Lube job ($18.00)";
            this.chkLube.UseVisualStyleBackColor = true;
            // 
            // chkOil
            // 
            this.chkOil.AutoSize = true;
            this.chkOil.Location = new System.Drawing.Point(7, 22);
            this.chkOil.Name = "chkOil";
            this.chkOil.Size = new System.Drawing.Size(158, 21);
            this.chkOil.TabIndex = 0;
            this.chkOil.Text = "Oil Change ($26.00)";
            this.chkOil.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkTransmission);
            this.groupBox2.Controls.Add(this.chkRadiator);
            this.groupBox2.Location = new System.Drawing.Point(415, 48);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(220, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Flushes";
            // 
            // chkTransmission
            // 
            this.chkTransmission.AutoSize = true;
            this.chkTransmission.Location = new System.Drawing.Point(6, 58);
            this.chkTransmission.Name = "chkTransmission";
            this.chkTransmission.Size = new System.Drawing.Size(210, 21);
            this.chkTransmission.TabIndex = 3;
            this.chkTransmission.Text = "Transmission Flush ($80.00)";
            this.chkTransmission.UseVisualStyleBackColor = true;
            // 
            // chkRadiator
            // 
            this.chkRadiator.AutoSize = true;
            this.chkRadiator.Location = new System.Drawing.Point(6, 22);
            this.chkRadiator.Name = "chkRadiator";
            this.chkRadiator.Size = new System.Drawing.Size(180, 21);
            this.chkRadiator.TabIndex = 2;
            this.chkRadiator.Text = "Radiator Flush ($30.00)";
            this.chkRadiator.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkMuffler);
            this.groupBox3.Controls.Add(this.chkTire);
            this.groupBox3.Controls.Add(this.chkInspection);
            this.groupBox3.Location = new System.Drawing.Point(169, 164);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(220, 116);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Misc";
            // 
            // chkMuffler
            // 
            this.chkMuffler.AutoSize = true;
            this.chkMuffler.Location = new System.Drawing.Point(7, 48);
            this.chkMuffler.Name = "chkMuffler";
            this.chkMuffler.Size = new System.Drawing.Size(195, 21);
            this.chkMuffler.TabIndex = 4;
            this.chkMuffler.Text = "Replace Muffler ($100.00)";
            this.chkMuffler.UseVisualStyleBackColor = true;
            // 
            // chkTire
            // 
            this.chkTire.AutoSize = true;
            this.chkTire.Location = new System.Drawing.Point(7, 75);
            this.chkTire.Name = "chkTire";
            this.chkTire.Size = new System.Drawing.Size(170, 21);
            this.chkTire.TabIndex = 3;
            this.chkTire.Text = "Tire Rotation ($20.00)";
            this.chkTire.UseVisualStyleBackColor = true;
            // 
            // chkInspection
            // 
            this.chkInspection.AutoSize = true;
            this.chkInspection.Location = new System.Drawing.Point(7, 21);
            this.chkInspection.Name = "chkInspection";
            this.chkInspection.Size = new System.Drawing.Size(152, 21);
            this.chkInspection.TabIndex = 2;
            this.chkInspection.Text = "Inspection ($15.00)";
            this.chkInspection.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblWarning);
            this.groupBox4.Controls.Add(this.txtLabor);
            this.groupBox4.Controls.Add(this.txtPartsCosts);
            this.groupBox4.Controls.Add(this.lblLabor);
            this.groupBox4.Controls.Add(this.lblPartsCosts);
            this.groupBox4.Location = new System.Drawing.Point(415, 164);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(220, 116);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Parts and Labor";
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.Location = new System.Drawing.Point(7, 22);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(173, 17);
            this.lblWarning.TabIndex = 4;
            this.lblWarning.Text = "User must enter a number";
            // 
            // txtLabor
            // 
            this.txtLabor.Location = new System.Drawing.Point(108, 74);
            this.txtLabor.Name = "txtLabor";
            this.txtLabor.Size = new System.Drawing.Size(100, 22);
            this.txtLabor.TabIndex = 3;
            this.txtLabor.Text = "0";
            // 
            // txtPartsCosts
            // 
            this.txtPartsCosts.Location = new System.Drawing.Point(108, 46);
            this.txtPartsCosts.Name = "txtPartsCosts";
            this.txtPartsCosts.Size = new System.Drawing.Size(100, 22);
            this.txtPartsCosts.TabIndex = 2;
            this.txtPartsCosts.Text = "0";
            // 
            // lblLabor
            // 
            this.lblLabor.AutoSize = true;
            this.lblLabor.Location = new System.Drawing.Point(3, 77);
            this.lblLabor.Name = "lblLabor";
            this.lblLabor.Size = new System.Drawing.Size(77, 17);
            this.lblLabor.TabIndex = 1;
            this.lblLabor.Text = "Labor Cost";
            // 
            // lblPartsCosts
            // 
            this.lblPartsCosts.AutoSize = true;
            this.lblPartsCosts.Location = new System.Drawing.Point(7, 48);
            this.lblPartsCosts.Name = "lblPartsCosts";
            this.lblPartsCosts.Size = new System.Drawing.Size(73, 17);
            this.lblPartsCosts.TabIndex = 0;
            this.lblPartsCosts.Text = "Parts Cost";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtTotal);
            this.groupBox5.Controls.Add(this.txtTax);
            this.groupBox5.Controls.Add(this.txtParts);
            this.groupBox5.Controls.Add(this.txtService);
            this.groupBox5.Controls.Add(this.lblTotal);
            this.groupBox5.Controls.Add(this.lblTax);
            this.groupBox5.Controls.Add(this.lblParts);
            this.groupBox5.Controls.Add(this.lblService);
            this.groupBox5.Location = new System.Drawing.Point(169, 295);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(466, 156);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Summary";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(143, 123);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(100, 22);
            this.txtTotal.TabIndex = 11;
            // 
            // txtTax
            // 
            this.txtTax.Location = new System.Drawing.Point(143, 91);
            this.txtTax.Name = "txtTax";
            this.txtTax.ReadOnly = true;
            this.txtTax.Size = new System.Drawing.Size(100, 22);
            this.txtTax.TabIndex = 10;
            // 
            // txtParts
            // 
            this.txtParts.Location = new System.Drawing.Point(143, 58);
            this.txtParts.Name = "txtParts";
            this.txtParts.ReadOnly = true;
            this.txtParts.Size = new System.Drawing.Size(100, 22);
            this.txtParts.TabIndex = 9;
            // 
            // txtService
            // 
            this.txtService.Location = new System.Drawing.Point(143, 28);
            this.txtService.Name = "txtService";
            this.txtService.ReadOnly = true;
            this.txtService.Size = new System.Drawing.Size(100, 22);
            this.txtService.TabIndex = 8;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(55, 126);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(75, 17);
            this.lblTotal.TabIndex = 7;
            this.lblTotal.Text = "Total Fees";
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Location = new System.Drawing.Point(33, 94);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(97, 17);
            this.lblTax.TabIndex = 6;
            this.lblTax.Text = "Tax (on parts)";
            // 
            // lblParts
            // 
            this.lblParts.AutoSize = true;
            this.lblParts.Location = new System.Drawing.Point(89, 61);
            this.lblParts.Name = "lblParts";
            this.lblParts.Size = new System.Drawing.Size(41, 17);
            this.lblParts.TabIndex = 5;
            this.lblParts.Text = "Parts";
            // 
            // lblService
            // 
            this.lblService.AutoSize = true;
            this.lblService.Location = new System.Drawing.Point(6, 31);
            this.lblService.Name = "lblService";
            this.lblService.Size = new System.Drawing.Size(124, 17);
            this.lblService.TabIndex = 4;
            this.lblService.Text = "Service and Labor";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(177, 477);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(82, 34);
            this.btnCalculate.TabIndex = 5;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(362, 477);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(82, 34);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(536, 477);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(87, 34);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Automotive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 523);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Automotive";
            this.Text = "Automotive";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.CheckBox chkLube;
        private System.Windows.Forms.CheckBox chkOil;
        private System.Windows.Forms.CheckBox chkTransmission;
        private System.Windows.Forms.CheckBox chkRadiator;
        private System.Windows.Forms.CheckBox chkMuffler;
        private System.Windows.Forms.CheckBox chkTire;
        private System.Windows.Forms.CheckBox chkInspection;
        private System.Windows.Forms.TextBox txtLabor;
        private System.Windows.Forms.TextBox txtPartsCosts;
        private System.Windows.Forms.Label lblLabor;
        private System.Windows.Forms.Label lblPartsCosts;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblParts;
        private System.Windows.Forms.Label lblService;
        private System.Windows.Forms.TextBox txtService;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.TextBox txtParts;
        private System.Windows.Forms.Label lblWarning;
    }
}

