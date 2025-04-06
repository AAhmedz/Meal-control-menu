using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Meal_control_menu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.Add("Combo");
            comboBox1.Items.Add("Single");
            checkBox1.Enabled = false;
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //AnyInputChanged(sender, e);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            AnyInputChanged(sender, e);
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            AnyInputChanged(sender, e);
        }




        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
        private bool AllFieldsFilled()
        {
            bool isMealNameValid = textBox1.Text != null && textBox1.Text != "";
            bool isPhoneValid = textBox2.Text != null && textBox2.Text != "";
            bool isMealTypeValid = comboBox1.Text != null && comboBox1.Text != "";
            bool isMealSizeSelected = radioButton1.Checked || radioButton2.Checked || radioButton3.Checked;

            return isMealNameValid && isPhoneValid && isMealTypeValid && isMealSizeSelected;
        }
        private void AnyInputChanged(object sender, EventArgs e)
        {
            if (AllFieldsFilled())
            {
                checkBox1.Enabled = true;
            }
            else
            {
                checkBox1.Enabled = false;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            AnyInputChanged(sender, e);

        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            AnyInputChanged(sender, e);

        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            AnyInputChanged(sender, e);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string missingInfo = "";

            if (textBox1.Text == null || textBox1.Text == "")
                missingInfo += "- Meal name is missing\n";

            if (textBox2.Text == null || textBox2.Text == "")
                missingInfo += "- Phone number is missing\n";

            if (comboBox1.Text == null || comboBox1.Text == "")
                missingInfo += "- Meal type is not selected\n";

            if (!(radioButton1.Checked || radioButton2.Checked || radioButton3.Checked))
                missingInfo += "- Meal size is not selected\n";

            if (missingInfo != "")
            {
                MessageBox.Show("Please complete the following:\n\n" + missingInfo);
            }

            if (checkBox1.Checked)  
            {
            }
            else  
            {
                MessageBox.Show("Checkbox is unchecked!");
            }


            ///////////////////////////////////////////

            string mealInfo = "";

            mealInfo += textBox1.Text + " ";

            if (radioButton1.Checked)
            {
                mealInfo += radioButton1.Text + " ";
            }
            else if (radioButton2.Checked)
            {
                mealInfo += radioButton2.Text + " ";
            }
            else if (radioButton3.Checked)
            {
                mealInfo += radioButton3.Text + " ";
            }

            mealInfo += comboBox1.Text;

            listBox1.Items.Add(mealInfo); 
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
