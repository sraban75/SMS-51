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
    public partial class StudentEntryUi : Form
    {

        public StudentEntryUi()
        {
            InitializeComponent();
        }

        private int count = 0;
        //string[] names = new string[10];
        List<string> nameList= new List<string>(); 
        private void AddButton_Click(object sender, EventArgs e)
        {
            //nameList.Add(nameTextBox.Text);

            MessageBox.Show(comboBox1.Text);

        }

        private void showButton_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < nameList.Count; i++)
            {
                MessageBox.Show(nameList[i]);
            }

            //foreach (string name in nameList)
            //{
            //    MessageBox.Show(name);
            //}
        }






    }
}
