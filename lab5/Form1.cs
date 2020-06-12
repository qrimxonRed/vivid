using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Text.RegularExpressions;

namespace lab5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = ParseBid(txt1.Text);
        }
        private string ParseBid(string bidtext)
        {
            double Bid;
            var x = Regex.Match(bidtext, @"([-+]?[0-9]*\.?[0-9]+)");
            bool flag = true;
            if (x.Success)
            {
                if (x.Groups[1].Value != bidtext)
                {
                    if (!bidtext.StartsWith("$ ") && !bidtext.StartsWith("$") && !bidtext.EndsWith(" dollars")) flag = false;

                }

                if (x.NextMatch().Success) flag = false;

                if (flag)
                {
                    Bid = Convert.ToDouble(x.Groups[1].Value);
                    if (Bid <= 10)
                    {
                        return "Bid must be at least $10";
                    }
                    return "Bid of $" + Bid + " accepted!";
                }
                else
                    return "Invalid Bid";
            }
            else
            {
                return "Invalid Bid";
            }
        }

    }
    }

