using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binary_search_tree
{
  class Program
  {
    static void Main(string[] args)
    {
      BinarySearchTree tree = new BinarySearchTree();
      tree.Add(10); // root
      tree.Add(7);
      tree.Add(4);
      tree.Add(12);
      tree.Add(14);
      tree.Add(17);
      tree.Add(15);
      tree.Add(13);

      /*Console.WriteLine(tree.root.left.data);
      Console.WriteLine(tree.root.left.left.data);
      Console.WriteLine(tree.root.right.data);
      Console.WriteLine(tree.root.right.right.data);*/
      Console.WriteLine(tree.root.right.right.left.data); // 13
      Console.WriteLine(tree.root.right.right.right.left.data); // 15
      Console.WriteLine(tree.Search(99)); // false
      Console.WriteLine(tree.Search(7)); // true 
      Console.WriteLine(tree.Search(37));
      Console.WriteLine(tree.Search(15));


      /*********************************************************************************/
      Console.ReadLine();
    }
  }
}
