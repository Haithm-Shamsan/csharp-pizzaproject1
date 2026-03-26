using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaProject1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        float GetSizePrice()
        {
            if(rbSmall.Checked)
            {
                return Convert.ToSingle(rbSmall.Tag);
            }
            else if(rbMideum.Checked)
            {
                return Convert.ToSingle(rbMideum.Tag);

            }
            else
            {
                return Convert.ToSingle(rbLarge.Tag);
            }

             

        }
        float GetCrustPrice()
        {
              Convert.ToSingle(rbThinCrust.Tag);
            if(rbThinckCrust.Checked)
            {
                return Convert.ToSingle(rbThinckCrust.Tag);
            }else
            {
               return Convert.ToSingle(rbThinCrust.Tag);
            }
           
        } 
        
        float GetToppingPrice()
        {
           
           float ToppingChoices =0;

            if(chkExtraChess.Checked)
            {
                ToppingChoices += Convert.ToSingle(chkExtraChess.Tag);
            }
            if(chkCicken.Checked)
            {
                ToppingChoices += Convert.ToSingle(chkCicken.Tag);
            }
            if(chkMashrom.Checked)
            {
                ToppingChoices += Convert.ToSingle(chkMashrom.Tag); 
            }
            if(chkOlive.Checked)
            {
                ToppingChoices +=  Convert.ToSingle(chkOlive.Tag);
            }
            if(chkOnion.Checked)
            {
                ToppingChoices += Convert.ToSingle(chkOnion.Tag);
            }
            if(chkTomito.Checked)
            {
                ToppingChoices += Convert.ToSingle(chkTomito.Tag);
            }
            return ToppingChoices;
        }
       float CalculateTotalPrice()
        {
            return ((GetSizePrice() + GetCrustPrice() + GetToppingPrice())*Convert.ToInt32(numericUpDown1.Value));
        }
        
        void UpdateTotalPrice()
        {
            

            lblTotalPrice.Text = "$" + CalculateTotalPrice().ToString();
        }
        void UpdateSize()
        {
            UpdateTotalPrice();
            if (rbSmall.Checked)
            {
                lblSize.Text = "Small";
            }else if(rbMideum.Checked)
            {
                lblSize.Text = "Mideum";
            }else
            {
                lblSize.Text = "Larg";
            }

        }
        
        void UpdateToppingPrice()
        {
            UpdateTotalPrice();
            string TotalTopping = "";
            if(chkExtraChess.Checked)
            {
                TotalTopping+= "ExtraChess";

            }
            if(chkCicken.Checked)
            {
                TotalTopping += ", Chicken";
            }
            if(chkOlive.Checked)
            {
                TotalTopping += ", Olive";

            }
            if(chkOnion.Checked)
            {
                TotalTopping += "" +
                    ", Onion";
            }
            if (chkTomito.Checked)
            {
                TotalTopping += ", Tomito";
            }
            if(chkMashrom.Checked)
            {
                TotalTopping += ", Mashrom";
            }
            lblTopping.Text = TotalTopping; 
        }
        void UpdateCrustType()
        {
            UpdateTotalPrice();

            if(rbThinCrust.Checked) 
            {
                lblCrustType.Text = "Thin";
            }else
            {
                lblCrustType.Text = "Thinck";
            }
        }

        void UpdateWhereToEat()
        {
            if (rbTakeAway.Checked)
            {
                lblWhereToEat.Text = "Take away";
            }
            else
            {
                lblWhereToEat.Text = "Eat In";
            }
        }




        void UpdateOrderSummry()
        {
            UpdateSize();
            UpdateCrustType();
            UpdateToppingPrice();
            UpdateWhereToEat();
            
        }









        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void rbMideum_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void rbLarge_CheckedChanged(object sender, EventArgs e)
        {
            GetSizePrice();
        }

        private void rbThinCrust_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrustType();
        }

        private void rbThinckCrust_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrustType();
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppingPrice();
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppingPrice();
        }

        private void label6_Click(object sender, EventArgs e)
        {
          ;
        }

        private void chkExtraChess_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppingPrice();
        }

        private void chkMashrom_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppingPrice();
        }

        private void chkTomito_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppingPrice();
        }

        private void chkOlive_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppingPrice();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void lblWhereToEat_Click(object sender, EventArgs e)
        {
           
        }

        private void rbEatIn_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereToEat();
        }

        private void rbTakeAway_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereToEat();
        }

        private void btnOrderIn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to order?", "Conform", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
            {
                MessageBox.Show("Order Placed Succssfully ","Succss",MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);

                gbSize.Enabled = false;
                gbTopping.Enabled = false;
                gbWhereToEat.Enabled = false;
                btnOrderIn.Enabled = false;
                gbCrust.Enabled = false;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            gbSize.Enabled =       true;
            gbTopping.Enabled =    true;
            gbWhereToEat.Enabled = true;
            btnOrderIn.Enabled = true;
            gbCrust.Enabled = true;

            rbMideum.Checked = true;

            rbThinCrust.Checked = true;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateOrderSummry();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();
        }
    }
}
