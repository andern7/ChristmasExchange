using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChristmasGiftExchange
{
    public partial class Form1 : Form
    {

       createList cl;

        public Form1(createList cl)
        {     
          this.cl = cl;
          InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            cl.addPerson(fNameTextBox.Text, lNameTextBox.Text);
            fNameTextBox.Clear();
            lNameTextBox.Clear();
            resultsBox.Text = cl.currentList();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            resultsBox.Text = cl.finalList();
        }
    }
}

