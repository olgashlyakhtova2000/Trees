using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace visualisation_of_trees
{
    public class Node
    {
        public int key;
        public Node left;
        public Node right;

        public Node(int x)
        {
            key = x;
        }
    }
}
