using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace visualisation_of_trees
{
    public class Field
    {
        Graphics g;
        public int count = 0;
        public Field(Graphics h)
        {
            g = h;
        }
        public void show( string text, int level, Graphics g, int nu)
        {
            Font f = new Font("Times New Roman", 12.0f);
            
            if (level==1)
            {
                g.DrawEllipse(Pens.Black, 295, 25, 25, 25);
                g.DrawString(text, f, Brushes.Black, 300, 25);
                //g.DrawLine(Pens.Black, 295, 35 , 295, 24 * (level + 1) + 15);
               // g.DrawLine(Pens.Black, 300 + nu, 24 * level, 295, 24 * (level - 1) - 15);

            }
            else
            {
               // if (nu > 295 && level >= 1) level++;
                    g.DrawEllipse(Pens.Black, 295+nu,  24 * level, 25, 25);
                    g.DrawString(text, f, Brushes.Black, 295 + nu, 2 + 24 * level);
                  //  g.DrawLine(Pens.Black, 300 + nu, 24 * level + 2, -295 / (level-1)+ 300+nu , 24*(level+1)-6);
                   // g.DrawLine(Pens.Black, 300 + nu, 24 * level + 2, nu + 295 + 295 / (level - 1) / 2, 24 * (level - 1) - 6);
                //g.DrawLine(Pens.Black, 300 + nu, 24 * level,  );

            }
            
        }
    }
}
