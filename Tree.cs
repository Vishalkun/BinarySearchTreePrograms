using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class Tree
    {
        public Node root;

        public Tree()
        {
            root = null;
        }
        public Node ReturnRoot()
        {
            return root;
        }
        public void Insert(int id)
        {
            Node node = new Node(id);
            if (root == null)
            {
                root = node;
            }
            else
            {
                Node current = root;
                Node parent;
                while (true)
                {
                    parent = current;
                    if (id < current.item)
                    {
                        current = current.leftc;
                        if (current == null)
                        {
                            parent.leftc = node;
                            return;
                        }
                    }
                    else
                    {
                        current = current.rightc;
                        if (current == null)
                        {
                            parent.rightc = node;
                            return;
                        }
                    }
                   
                }
            }

        }
        public void Display(Node root)
        { 
            if(root!=null)
            {
                Console.WriteLine(root.item + "");
                Display(root.leftc);
                Display(root.rightc);

            }
        }
        public void post(Node root)
        {
            if (root != null)
            {
                
                Display(root.leftc);
                Display(root.rightc);
                Console.WriteLine(root.item + "");
            }
        }
        public void Inorder(Node root)
        {
            if (root != null)
            {

                Display(root.leftc);
                Console.WriteLine(root.item + "");
                Display(root.rightc);
            }
        }
    }
       
    }



