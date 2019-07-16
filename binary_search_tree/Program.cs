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
      tree.Add(10);
      tree.Add(7);
      tree.Add(4);
      tree.Add(12);
      tree.Add(14);

      Console.WriteLine(tree.root.left.data);
      Console.WriteLine(tree.root.left.left.data);
      Console.WriteLine(tree.root.right.data);
      Console.WriteLine(tree.root.right.right.data);
      Console.WriteLine(tree.Search(99));
      Console.WriteLine(tree.Search(7));


      /*********************************************************************************/
      Console.ReadLine();
    }
  }
}
