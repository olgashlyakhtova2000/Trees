using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace visualisation_of_trees
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int c = 0;
        Graphics g;
        string date;
        Btree tree = new Btree();
        public const int coord1 = 30;
        public const int coord2 = 30;
        public string text;
        
        private void Form1_Load(object sender, EventArgs e)
        {
            g = panel1.CreateGraphics();
           
        }
        
        private void Button1_Click(object sender, EventArgs e)
        {
            date = textBox1.Text;
            textBox1.Clear();
            c++;
            int level = tree.Insert(Convert.ToInt32(date));
            int put = tree.put;
            Field a = new Field(g);
            a.show(date, level, g, put);

            if (c == 1)
            {
                  MessageBox.Show("Количество отображаемых корней ограничено в связи с заданными размерами панели (максимальная глубина будет 4)");
            }
            // else if (c==0)
            // MessageBox.Show(Convert.ToString(tree.u));
            // a.show(date, level,g,put);

        }
    }
}
