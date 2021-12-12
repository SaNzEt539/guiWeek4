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
    public partial class Form1 : Form
    {
        Class1 o;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                o = new Class1(int.Parse(tbN.Text));
                o.Input(tbArr.Text);
                o.Sort();
                labSortArr.Text = "Сортированный массив: " + o.Show();
                o.Skal = int.Parse(tbSkal.Text);
                labRes.Text = "Массив: " + o.Show();
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message, "Ошибка");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Form2 f = new Form2(o);
                f.ShowDialog();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Ошибка");
            }
            
        }
    }
}
