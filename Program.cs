namespace BinarySearchTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            Tree tree = new Tree();
            tree.Insert(56);
            tree.Insert(13);
            tree.Insert(70);
            Console.WriteLine("Pre-order traversal :root-left-right");
            tree.Display(tree.ReturnRoot());
            Console.WriteLine("Post-order traversal left-right-root");
            tree.Display(tree.ReturnRoot());
            Console.WriteLine("In-order traversal left-root-right");
            tree.Display(tree.ReturnRoot());
        }
    }
}