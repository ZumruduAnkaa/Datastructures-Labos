using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datastructures_ClassLibrary.NonLineairStructures
{
    public class BST
    {
        #region public area
        /// <summary>
        /// A reference to the Root node of the tree
        /// </summary>
        public BSTNode Root { get; private set; }

        /// <summary>
        /// Insert a value into the tree. Nothing will be done if the value is already present.
        /// </summary>
        /// <param name="value"></param>
        /// <returns>The node that was created</returns>
        public BSTNode Insert(int value)
        {
            //TODO: implement this method
            if (Root == null)
            {
                Root = new BSTNode(value);
                return Root;
            }

            BSTNode parent = FindNode(Root, value);

            if (parent.Value == value)
            {
                return parent;
            }

            BSTNode newNode = new BSTNode(value);

            if (value < parent.Value)
            {
                parent.Left = newNode;
            }
            else
            {
                parent.Right = newNode;
            }

            return newNode;
        }

        /// <summary>
        /// Find the specified value in the tree. 
        /// </summary>
        /// <param name="value"></param>
        /// <returns>The node with this value or NULL if the value is not present</returns>
        public BSTNode FindNode(int value)
        {
            //TODO: implement this method
            BSTNode result = FindNode(Root, value);

            if (result == null || result.Value != value)
            {
                return null;
            }

            return result;
        }

        /// <summary>
        /// Remove the specified value from the tree.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public int Remove(int value)
        {
            Root = Remove(Root, value);
            return value;
        }

        /// <summary>
        /// Erase all nodes from the tree
        /// </summary>
        public void Clear()
        {
            //TODO: implement this method;
            Root = null;
        }
        #endregion

        #region private members

        /// <summary>
        /// Remove the node with the specified value from the tree.
        /// </summary>
        /// <param name="root">The node from where to start searching</param>
        /// <param name="value"></param>
        /// <returns></returns>
        private BSTNode Remove(BSTNode root, int value)
        {
            if (root == null)
                return null;

            //First descend the tree to find the node with the specified value
            if (root.Value > value)
            {
                root.Left = Remove(root.Left, value);
                return root;
            }
            else if (root.Value < value)
            {
                root.Right = Remove(root.Right, value);
                return root;
            }

            //found the node with the requested value, let"s remove it
            if (root.Left == null) // max. 1 child
                return root.Right;
            if (root.Right == null) // max. 1 child
                return root.Left;

            var min = FindMinValue(root.Right);
            var newn = Remove(root, min);                //remove the original node
            root.Value = min;                       //take over the value
            return newn;
        }

        /// <summary>
        /// Find the smallest value below the specified node
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        private int FindMinValue(BSTNode root)
        {
            if (root == null)
                return -1;
            if (root.Left != null)
                return FindMinValue(root.Left);
            return root.Value;
        }

        /// <summary>
        /// Find the node with the specified value in the tree starting from the specified parent node
        /// This method will either return the node itself, or the parent of the node (if the node itself does not exist)
        /// </summary>
        /// <param name="parent"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        private BSTNode FindNode(BSTNode parent, int value)
        {
            BSTNode temp;

            if (parent == null)
                return parent;

            if (parent.Value == value)
                temp = parent;
            else if (parent.Value > value)
                temp = FindNode(parent.Left, value);
            else
                temp = FindNode(parent.Right, value);

            return (temp == null ? parent : temp);
        }
        #endregion

        //Oefening 2
        public int Count()
        {
            return Count(Root);
        }

        private int Count(BSTNode node)
        {
            if (node == null)
            {
                return 0;
            }

            return 1 + Count(node.Left) + Count(node.Right);
        }

        //Oefening 3
        public int Lowest()
        {
            return Lowest(Root);
        }

        private int Lowest(BSTNode node)
        {
            if (node.Left == null)
            {
                return node.Value;
            }

            return Lowest(node.Left);
        }

        //Oefening 4
        public int Height()
        {
            return Height(Root);
        }

        private int Height(BSTNode node)
        {
            if (node == null)
            {
                return 0;
            }

            return 1 + Math.Max(Height(node.Left), Height(node.Right));
        }
    }
}
