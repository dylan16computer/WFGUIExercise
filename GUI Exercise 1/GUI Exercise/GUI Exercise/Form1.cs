using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Exercise
{
    public partial class Form1 : Form
    {
        List<Details> peopleList = new List<Details>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblOutput.Text = null;
        }

        private void lblOutput_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Details person1 = new Details();
            person1.FName = txtBoxFrstNme.Text;
            person1.LName = txtBoxLstNme.Text;
            person1.Age = int.Parse(txtBoxAge.Text);
            peopleList.Add(person1);
            txtBoxFrstNme = null;
            txtBoxLstNme = null;
            txtBoxAge = null;
            lblOutput.Text = "New record created and added";
        }

        private void txtBoxFrstNme_TextChanged(object sender, EventArgs e)
        {
            lblOutput.Text = null;
        }

        private void txtBoxLstNme_TextChanged(object sender, EventArgs e)
        {
            lblOutput.Text = null;
        }

        private void txtBoxAge_TextChanged(object sender, EventArgs e)
        {
            lblOutput.Text = null;
        }
    }
}
