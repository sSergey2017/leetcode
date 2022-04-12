using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyThree
{
    public static class QueueMapper
    {
        public static TreeB Map(TreeA tree)
        {
            if (tree == null) { return null; }
            var mapQueue = new Queue<(TreeA, TreeB)>();
            var copy = new TreeB();
            mapQueue.Enqueue((tree, copy));
            while (mapQueue.TryDequeue(out var nodes))
            {
                var (nodeA, nodeB) = nodes;
                nodeB.Paiload = nodeA.Paiload;

                if(nodeA.LeftBranch != null)
                {
                    nodeB.LeftBranch = new TreeB();
                    mapQueue.Enqueue((nodeA.LeftBranch, nodeB.LeftBranch));
                }

                if (nodeA.RightBranch != null)
                {
                    nodeB.RightBranch = new TreeB();
                    mapQueue.Enqueue((nodeA.RightBranch, nodeB.RightBranch));
                }
            }
            return copy;
        }
    }
}
