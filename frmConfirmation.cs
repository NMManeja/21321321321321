using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maneja
{
    public partial class frmConfirmation : Form
    {
        public frmConfirmation()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            lblStudentNo.Text = StudentInformationClass.SetStudentNo.ToString();
            lblName.Text = StudentInformationClass.SetFullName;
            lblProgram.Text = StudentInformationClass.SetProgram;
            lblBirthday.Text = StudentInformationClass.SetBirthDay;
            lblGender.Text = StudentInformationClass.SetGender;
            lblContactNo.Text = StudentInformationClass.SetContactNo.ToString();
            lblAge.Text = StudentInformationClass.SetAge.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblBirthday_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lblGender_Click(object sender, EventArgs e)
        {


        }

        private void lblContactNo_Click(object sender, EventArgs e)
        {

        }
    }
}
