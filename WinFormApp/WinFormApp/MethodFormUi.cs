using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormApp
{
    public partial class MethodFormUi : Form
    {
        string _firstName = "";
        string _lastName = "";
        public MethodFormUi()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            string firstName = firstNameTextBox.Text;
            string lastName = lastNameTextBox.Text;


            AddStudentInfo(firstName, lastName);
        }


        public void AddStudentInfo(string firstName, string lastName)
        {
            _firstName = firstNameTextBox.Text;
            _lastName = lastNameTextBox.Text;
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            string fullName = GetFullName();


            MessageBox.Show(fullName);
        }

        public string GetFullName()
        {
            return _firstName + " " + _lastName;
        }

        
        
    }
}
