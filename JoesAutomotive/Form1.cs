using System;
using System.Windows.Forms;

namespace JoesAutomotive
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();            
        }

        private void button1_Click(object sender, EventArgs e) => Application.Exit();

        private void btnClear_Click(object sender, EventArgs e)
        {
            //this triggers me
            ClearOilLube();
            ClearFlushes();
            ClearMisc();
            ClearOther();
            ClearFees();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            //grab total
            var total = GetTotalCharges();
            txtTotal.Text = total.ToString();

            var slChg = GetOilLubeCharges() + GetFlushCharges() + GetMiscCharges() + GetLabourCharges();
            txtServiceLabour.Text = slChg.ToString("c");
            txtParts.Text = GetPartsCharges().ToString("c");
            txtTax.Text = GetTaxCharges().ToString("c");
            txtTotal.Text = GetTotalCharges().ToString("c");
        }

        private void ClearOilLube() => ClearGroup(grpOilLube);
        private void ClearFlushes() => ClearGroup(grpFlushes);
        private void ClearMisc() => ClearGroup(grpMisc);
        private void ClearOther() => ClearGroup(grpPartsLabour);
        private void ClearFees() => ClearGroup(grpSummary);

        private double GetOilLubeCharges() => GetCharges(grpOilLube);
        private double GetFlushCharges() => GetCharges(grpFlushes);
        private double GetMiscCharges() => GetCharges(grpMisc);
        private double GetOtherCharges() => GetCharges(grpPartsLabour);
        
        private double GetTaxCharges()
        {
            var parts = GetPartsCharges();
            return parts * 0.06;
        }

        private double GetTotalCharges() => GetOilLubeCharges() + GetFlushCharges() + GetMiscCharges() + GetOtherCharges() + GetTaxCharges();
        

        private double GetPartsCharges()
        {
            double.TryParse(txt_parts.Text, out var y);
            return y;
        }

        private double GetLabourCharges()
        {
            double.TryParse(txt_labour.Text, out var y);
            return y;
        }

        private void ClearGroup(GroupBox group)
        {
            foreach (var f in group.Controls)
            {
                if (f is CheckBox l)
                    l.Checked = false;
                else if (f is TextBox t)
                    t.Text = String.Empty;
            }
        }

        private double GetCharges(GroupBox category)
        {
            var total = 0.0;
            foreach (var f in category.Controls)
            {
                if (f is CheckBox l && !string.IsNullOrEmpty(l.Tag.ToString()) && l.Checked == true)
                {
                    double.TryParse(l.Tag.ToString(), out double x);
                    total += x;
                }
                else if (f is TextBox t && t.Tag.ToString().Equals("value"))
                {
                    double.TryParse(t.Text, out double y);
                    total += y;
                }
            }
            return total;
        }
    }
}