using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTreeUC1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Binary Search Tree Program.");
            BinaryTree binarytree = new BinaryTree();

            binarytree.Add(56);
            binarytree.Add(30);
            binarytree.Add(70);

            Console.Write("\n Inorder result : ");
            binarytree.TraverseInorder(binarytree.root);
            Console.WriteLine();

            Console.Write("\n Post-order result : ");
            binarytree.TraversePostorder(binarytree.root);
            Console.WriteLine();

            Console.Write("\n Pre-order result : ");
            binarytree.TraversePreorder(binarytree.root);
            Console.WriteLine();
            Console.ReadKey();
        }
        
    }
}
