using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string result = "";
            string phrase = txtString.Text.Trim();
            string[] words = phrase.Split(' ');
            label1.Text = SortWords(phrase);

        }

        private string SortWords(string phrase)
        { 
      
        Array.Sort(words);
                foreach (string str in words)
                {
                    result = result + " " + str;
                }
            return newResult;
    
        }
    }
}

