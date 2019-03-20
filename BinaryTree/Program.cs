using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree BT = new BinaryTree();

            BT.Search(100,BT.root);
            BT.Insert(50);
            BT.Insert(37);
            BT.Insert(76);
            BT.Search(36,BT.root);
            BT.Search(38, BT.root);
            BT.Search(75, BT.root);
            BT.Search(77, BT.root);
            BT.Search(50, BT.root);
            BT.Search(76, BT.root);
            Console.ReadLine();
        }
    }
}
