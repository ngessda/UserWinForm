using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace User
{
    public partial class Form1 : Form
    {
        UserRepository userRepos = new UserRepository();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "" && textBox2.Text != "")
            {
                if(textBox1.Text[0] != ' ' 
                    && textBox1.Text[textBox1.Text.Length - 1] != ' ' 
                    && textBox2.Text[0] != ' ' 
                    && textBox2.Text[textBox2.Text.Length - 1] != ' ')
                {
                    ClassUser classUser = new ClassUser()
                    {
                        Id = -1,
                        Username = textBox1.Text,
                        Password = textBox2.Text
                    };
                    userRepos.Save(classUser);
                    listBox1.Items.Add(classUser);
                }
                else
                {
                    MessageBox.Show("Пошел нахуй");
                }
            }
            else
            {
                MessageBox.Show("Пошел нахуй");
            }
        }
    }
}
