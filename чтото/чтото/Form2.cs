using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace чтото
{
    public partial class Form2 : Form
    {
        Random random = new Random();
        int secretNumber;
        int attemps = 0;
        public Form2()
        {
            InitializeComponent();
            secretNumber = random.Next(1,101);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number;
            if (int.TryParse(textBox1.Text, out number))
            {
                attemps++;
                if (number < secretNumber)
                {
                    label2.Text = "Загадочное число больше";
                }
                else if (number > secretNumber)
                {
                    label2.Text = "Загадачнное число меньше";
                }
                else if (number == secretNumber)
                {
                    label2.Text = "Вы угадали!";
                }

                label1.Text = "Попыток: " + attemps;
            }
            else
            {
                MessageBox.Show("Введите целое число!");
            }
        
    
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
