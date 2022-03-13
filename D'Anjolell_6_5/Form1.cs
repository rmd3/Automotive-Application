using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace D_Anjolell_6_5
{
    public partial class Automotive : Form
    {
        public Automotive()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Closes the program
            this.Close();
        }

        //Clears all checks in the Oil and Lube GroupBox
        private void ClearOilLube()
        {
            chkOil.Checked = false;
            chkLube.Checked = false;
        }

        //Clears all checks in the Flushes GroupBox
        private void ClearFlushes()
        {
            chkRadiator.Checked = false;
            chkTransmission.Checked = false;
        }

        //Clears all checks in the Misc GroupsBox
        private void ClearMisc()
        {
            chkInspection.Checked = false;
            chkMuffler.Checked = false;
            chkTire.Checked = false;
        }

        //Clears all text in the Parts and Labor GroupBox and put in a placeholder 0
        private void ClearOther()
        {
            txtPartsCosts.Text = "0";
            txtLabor.Text = "0";
        }

        //Clears all text in the Summary GroupBox
        private void ClearFees()
        {
            txtService.Clear();
            txtParts.Clear();
            txtTax.Clear();
            txtTotal.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //Activates the following functions to clear all info on screen
            ClearOilLube();
            ClearFlushes();
            ClearMisc();
            ClearOther();
            ClearFees();
        }

        //Function to determine total charges in Oil and Lube groupbox
        private int OilLubeCharges() 
        {
            //Declare Local Constant Variables
            int OilCharge = 26;
            int LubeJob = 18;

            //Declare Local Variables
            int OilLubeTotal = 0;

            //If statement to determine to add charge if checkbox is checked
            if (chkOil.Checked) 
            {
                OilLubeTotal += OilCharge;
            }

            //If statement to determine to add charge if checkbox is checked
            if (chkLube.Checked)
            {
                OilLubeTotal += LubeJob;
            }

            //Returns total of charges in Oil and Lube groupbox
            return OilLubeTotal;
        }

        //Function to determine total charges in Flushes groupbox
        private int FlushCharges()
        {
            //Declare Local Constant Variables
            int RadFlush = 30;
            int TransFlush = 80;

            //Declare Local Variables
            int FlushTotal = 0;

            //If statement to determine to add charge if checkbox is checked
            if (chkRadiator.Checked)
            {
                FlushTotal += RadFlush;
            }

            //If statement to determine to add charge if checkbox is checked
            if (chkTransmission.Checked)
            {
                FlushTotal += TransFlush;
            }

            //Returns total of charges in Flushes groupbox
            return FlushTotal;
        }

        //Function to determine total charges in Misc groupbox
        private int MiscCharges()
        {
            //Declare Local Constant Variables
            int InspectCharge = 15;
            int MufflerReplacement = 100;
            int TireRotation = 20;

            //Declare Local Variables
            int MiscTotal = 0;

            //If statement to determine to add charge if checkbox is checked
            if (chkInspection.Checked)
            {
                MiscTotal += InspectCharge;
            }

            //If statement to determine to add charge if checkbox is checked
            if (chkMuffler.Checked)
            {
                MiscTotal += MufflerReplacement;
            }

            //If statement to determine to add charge if checkbox is checked
            if (chkTire.Checked)
            {
                MiscTotal += TireRotation;
            }

            //Returns total of charges in Misc groupbox
            return MiscTotal;
        }

        //Function to determine total charges in Parts and Labor groupbox
        private double OtherCharges()
        {
            //Declare Local Variables
            double PartsCost;
            double LaborCost;
            double OtherTotal;

            //Gaining info from user input
            PartsCost = double.Parse(txtPartsCosts.Text);
            LaborCost = double.Parse(txtLabor.Text);

            //Totaling the costs
            OtherTotal = PartsCost + LaborCost;

            //Returns total of charges in Parts and Labor groupbox
            return OtherTotal;
        }

        //Function to determine the sales tax on parts
        private double TaxCharges()
        {
            //Declare Local Variables
            double PartsCost;
            double SalesTax;

            //Gaining info from user input
            PartsCost = double.Parse(txtPartsCosts.Text);

            //Calculating sales tax on parts
            SalesTax = .06 * PartsCost;

            //Returns tax of parts
            return SalesTax;
        }

        //Function to determine total charges of the maintenance
        private double TotalCharges()
        {
            //Declare Local Variables
            int OilLubeTotal;
            int FlushTotal;
            int MiscTotal;
            double OtherTotal;
            double SalesTax;
            double ChargeTotal;

            //Gain totals from other functions
            OilLubeTotal = OilLubeCharges();
            FlushTotal = FlushCharges();
            MiscTotal = MiscCharges();
            OtherTotal = OtherCharges();
            SalesTax = TaxCharges();

            //Totaling all totals together
            ChargeTotal = OilLubeTotal + FlushTotal + MiscTotal + OtherTotal + SalesTax;

            //Returns total of charges
            return ChargeTotal;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //Richard D'Anjolell
            //Declare Variable
            double ServiceTotal;
            double PartsTotal;
            double SalesTax;
            double MaintenanceTotal;

            //Gain necessary info from functions
            ServiceTotal = OilLubeCharges() +FlushCharges() + MiscCharges() + double.Parse(txtLabor.Text);
            PartsTotal = double.Parse(txtPartsCosts.Text);
            SalesTax = TaxCharges();
            MaintenanceTotal = TotalCharges();

            //Display info in Summary groupbox
            txtService.Text = "$ " + ServiceTotal.ToString("0.00");
            txtParts.Text = "$ " + PartsTotal.ToString("0.00");
            txtTax.Text = "$ " + SalesTax.ToString("0.00");
            txtTotal.Text = "$ " + MaintenanceTotal.ToString("0.00");
        }
    }
}
