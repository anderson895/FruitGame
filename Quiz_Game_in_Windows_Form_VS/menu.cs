using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz_Game_in_Windows_Form_VS
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void EventStart(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();  // Create an instance of Form1
            form1.Show();  // Show Form1
            this.Hide();  // Hide the current form (menu.cs)
        }

        private void EventExit(object sender, EventArgs e)
        {
            Application.Exit();  // Exit the application
        }

        private void menu_Load(object sender, EventArgs e)
        {

        }
    }
}
