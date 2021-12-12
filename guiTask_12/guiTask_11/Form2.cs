using consoleTask_12;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace guiTask_11
{
    public partial class Form2 : Form
    {
        Class1 o;
        public Form2()
        {
            InitializeComponent();
        }
        public Form2(Class1 c)
        {
            o = c;
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {            
            try
            {                
                o = o * (int.Parse(tbS.Text));
                labArr.Text = "Массив после *: " + o.Show();
                int[] arr = (int[])o;
                o = (Class1)arr;
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Ошибка");
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {

                o = o++;
                labPP.Text = "Массив после ++: " + o.Show();
                if (!o)
                {
                    labUp.Text = "Массив не упорядочен!";
                }
                else
                {
                    labUp.Text = "Массив упорядочен!";
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Ошибка");
            }
        }
    }
}
