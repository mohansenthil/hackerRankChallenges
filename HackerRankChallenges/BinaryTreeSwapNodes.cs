using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRankChallenges
{
    public class BinaryTreeSwapNodes
    {

        class Node
        {
            public Node left, right;
            public readonly int data;

            public Node(int data)
            {
                this.data = data;

            }
        }

            static int[][] SwapNodes(int[][] indexes, int[] queries)
        {

            int[][] output = new int[queries.Length][];

            var binaryTree = ConstructTree(indexes);

            for (int i = 0; i < queries.Length; i++)
            {
                binaryTree = SwapNodes(binaryTree, queries[i], 1);
                output[i] = GetInOrder(new List<int>(), binaryTree).ToArray();
            }


            return output;
        }

        static Node ConstructTree(int[][] indexes)
        {
            var rootNode = new Node(1);

            var helperQueueToOrderTheNodes = new Queue<Node>();

            helperQueueToOrderTheNodes.Enqueue(rootNode);

            int totalNodes = indexes.Length;

            for (int i = 0; i < totalNodes; i++)
            {
                var nodeInTree = helperQueueToOrderTheNodes.Dequeue();

                int[] nodesTobeAdded = indexes[i];

                if (nodesTobeAdded[0] > 1)
                {
                    nodeInTree.left = new Node(nodesTobeAdded[0]);
                    helperQueueToOrderTheNodes.Enqueue(nodeInTree.left);
                }
                if (nodesTobeAdded[1] > 1)
                {
                    nodeInTree.right = new Node(nodesTobeAdded[1]);
                    helperQueueToOrderTheNodes.Enqueue(nodeInTree.right);
                }

            }

            return rootNode;
        }

        static List<int> GetInOrder(List<int> inorderList, Node root)
        {
            if (root.left != null)
            {
                GetInOrder(inorderList, root.left);
            }
            if (root != null)
            {
                inorderList.Add(root.data);
            }
            if (root.right != null)
            {
                GetInOrder(inorderList, root.right);
            }

            return inorderList;
        }


        static Node SwapNodes(Node rootNode, int queryDepth, int currentDepth)
        {
            if (currentDepth % queryDepth == 0)
            {
                var left = rootNode.left;
                var right = rootNode.right;

                rootNode.right = left;
                rootNode.left = right;
            }

            if (rootNode.left != null)
            {
                SwapNodes(rootNode.left, queryDepth, currentDepth + 1);
            }
            if (rootNode.right != null)
            {
                SwapNodes(rootNode.right, queryDepth, currentDepth + 1);
            }

            return rootNode;
        }
    }
}
