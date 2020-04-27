using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace visualisation_of_trees
{
    public class Btree
    {
        public int put = 0;
        public Node root;
        public int u = 1;
        public int Insert(int x)
        {
            u = 1;
            put = 0;
            if (root == null)
                root = new Node(x);
            else
            {
               u = insert(root, x);
                
            }
                
            return u;
        }
        private int insert(Node p, int x)
        {
            
            u++;
            if (x < p.key)
            {
                put -= 295/u;
                if (p.left == null)
                {
                    p.left = new Node(x);
               
                }   
                else
                {
                    
                    insert(p.left, x);

                }

            }
            else
            {

                put += 295/u;
                if (p.right == null)
                {
                    p.right = new Node(x);

                }
                else
                {

                    insert(p.right, x);
                }
                
            }
            return u;    
            
        }
        //public int Print()
        //{
        //    int u = 0;
        //    if (root != null)
        //        print(root, 0, u);
        //    return u;
        //}
        //private int print(Node p, int shift, int u)
        //{
        //    u++;
        //    if (p.right != null)
        //        print(p.right, shift + 1,u);

        //    for (int i = 0; i != shift; i++)
        //        Console.Write("  ");
        //    Console.WriteLine(p.key);

        //    if (p.left != null)
        //        print(p.left, shift + 1,u);
        //    return u;

        //}
        public int GetMaxRec()
        {
            if (root != null)
                return findMax(root).key;
            else
                return -1;
        }
        private Node findMax(Node p)
        {
            return p.right != null ? findMax(p.right) : p;
        }
        public void ChangeTree()
        {
            root = buildTree(root);
        }
        private Node buildTree(Node p)
        {
            var nodes = new List<Node>();
            store(p, nodes);
            return build_from_nodes(nodes, 0, nodes.Count - 1);
        }
        private void store(Node p, List<Node> nodes)
        {
            if (p == null)
                return;
            store(p.left, nodes);
            nodes.Add(p);
            store(p.right, nodes);
        }
        private Node build_from_nodes(List<Node> nodes,  int start, int end)
        {
            if (start > end)
                return null;
            int mid = (start + end) / 2;
            Node p = nodes[mid];
            p.left = build_from_nodes(nodes, start, mid - 1);
            p.right = build_from_nodes(nodes, mid + 1, end);
            return p;
        }

        public int Height()
        {
            return height(root);
        }
        private int height(Node p)
        {
            if (p == null)
                return 0;
            return 1 + Math.Max(height(p.left), height(p.right));
        }
        //public override string ToString() => tostr(root).Item2;
        //private (int, string) tostr(Node p)
        //{
        //    return (1, "\n");
        //}

        public void Print2()
        {
            Console.WriteLine(tostr(root));
        }
        private string tostr(Node p)
        {
            if (p == null)
                return "\n";
            return "";
        }
    }

}
