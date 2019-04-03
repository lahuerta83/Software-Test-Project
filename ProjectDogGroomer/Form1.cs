using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectDogGroomer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Queue<dog> dogline = new Queue<dog>();
        private void adddog_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(dogname.Text))
                return;
            dogline.Enqueue(new dog(dogname.Text));
            dogname.Text = "";
            RedoList();
        }
        private void RedoList()
        {
            int num = 1;
            line.Items.Clear();
            foreach (dog Dog in dogline)
            {
                line.Items.Add(num + " . " + Dog.Dogname);
                num++;
            }
            if (dogline.Count > 0)
            {
                groupBox1.Enabled = true;
                dog currentdog = dogline.Peek();
                if (checkBox1.Checked == true)
                {
                    textBox2.Text = currentdog.Dogname + " gets a " +
                    comboBox1.Text + " and a nail trim.";
                }
                else
                    textBox2.Text = currentdog.Dogname + " gets a " +
                    comboBox1.Text;
            }
        
            else
            {
                    groupBox1.Enabled = false;
                    textBox2.Text = "";
            }
        }

        private void nextdog_Click(object sender, EventArgs e)
        {
            if (dogline.Count > 0)
            {
                dog nextdogline = dogline.Dequeue();
                nextdogline.Beinggroom();
                textBox2.Text = "";
                RedoList();
            }
            else
            return;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dogline.Count == 0) return;
            string typestring = comboBox1.Text;
            Dogservices typeofgroom;
            switch (typestring)
            {
                case "fullgroom":
                    typeofgroom = Dogservices.fullgroom;
                    break;
                case "partialgroom":
                    typeofgroom = Dogservices.partialgroom;
                    break;
                case "Bath":
                    typeofgroom = Dogservices.Bath;
                    break;
                case "oatmealbath":
                    typeofgroom = Dogservices.oatmealbath;
                    break;
            }
        
         RedoList();
        }
    }
}
