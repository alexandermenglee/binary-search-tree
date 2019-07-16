using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binary_search_tree
{
  /*
   * Create new node
   * Starting at the root, if no root - the root is now the new node
   * If there is a root, check if newNode is greater or less than root
   * - if greater than root - check root.Right for null, if not null reapeat
   * - if less than roon - check root.Left for null, if null - insert node there and break from loop 
   */
  class BinarySearchTree
  {
    public Node root;
    public BinarySearchTree()
    {
      root = null;
    }

    public void Add(int value)
    {
      Node tempNode = new Node(value);
      Node currenParentNode;

      if(root == null)
      {
        root = tempNode;
        return;
      }
      else
      {
        // point currenParentNode at root node bc this reference will keep changing
        currenParentNode = root;

        while (true)
        {
          if(tempNode.data <= currenParentNode.data)
          {
            if(currenParentNode.left == null)
            {
              currenParentNode.left = tempNode;
              break;
            }
            else
            {
              currenParentNode = currenParentNode.left;
            }
          }
          else if(tempNode.data > currenParentNode.data)
          {
            if(currenParentNode.right == null)
            {
              currenParentNode.right = tempNode;
              break;
            }
            else
            {
              currenParentNode = currenParentNode.right;
            }
          }
        }

      }
    }

    public bool Search(int value)
    {
      // if value = root.data return true

      // if value is less than root
      // search to the left
        // 
      // else search to the right
        //

      Node currentParent;

      if(value == root.data)
      {
        return true;
      }

      currentParent = root;

      while (true)
      {
        if(value < currentParent.data)
        {
          if (currentParent.left != null)
          {
            if (currentParent.left.data == value)
            {
              return true;
            }
            else currentParent = currentParent.left;
          }
          else return false;
        }
        else
        {
          if(currentParent.right != null)
          {
            if (currentParent.right.data == value)
            {
              return true;
            }
            else currentParent = currentParent.right;
          }
          else return false;
        }
      }

      return false;
    }

  }
}
