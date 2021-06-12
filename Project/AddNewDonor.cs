using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class AddNewDonor : Form
    {
        function fn = new function();
        public AddNewDonor()
        {
            InitializeComponent();
        }

        private void AddNewDonor_Load(object sender, EventArgs e)
        {
            String query = "select max(did) from newDonor";
            DataSet ds = fn.getData(query);
          
            int count = int.Parse(ds.Tables[0].Rows[0][0].ToString());
            labelNewID.Text = (count+1).ToString();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtFathersName.Clear();
            txtMothersName.Clear();
            DOB.ResetText();
            txtMobileNo.Clear();
            GenderBox.ResetText();
            Email.Clear();
            BloodGroupBox.ResetText
                ();
            txtCity.Clear();
            txtAddress.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtFathersName.Text != "" && txtMothersName.Text != "" && DOB.Text != "" && txtMobileNo.Text != "" && GenderBox.Text != "" && Email.Text != "" && BloodGroupBox.Text != "" && txtCity.Text != "" && txtAddress.Text!= "")
            {
                String dname = txtName.Text;
                String fname = txtFathersName.Text;
                String mname = txtMothersName.Text;
                String dob = DOB.Text;
                Int64 mobile = Int64.Parse(txtMobileNo.Text);
                String gender = GenderBox.Text;
                String email = Email.Text;
                String bgroup = BloodGroupBox.Text;
                String city = txtCity.Text;
                String address = txtAddress.Text;


                String query="insert into newDonor (dname,fname,mname,dob,mobile,gender,email,bloodgroup,city,daddress) values ('" + dname + "','" + fname + "','" + mname + "','" + dob + "'," + mobile + ",'" + gender + "','" + email + "','" + bgroup + "','" + city + "','" + address + "')";
                fn.setData(query);


            }
            else
            {
                MessageBox.Show("Fill all Fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
     
    
    }

}
