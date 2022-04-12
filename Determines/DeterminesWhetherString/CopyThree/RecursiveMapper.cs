using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyThree
{
    public static class RecursiveMapper
    {
        public static TreeB Map(TreeA tree)
        {
            if (tree == null) { return null; }
            var copy = new TreeB
            {
                Paiload = tree.Paiload,
                LeftBranch = Map(tree.LeftBranch),
                RightBranch = Map(tree.RightBranch)
            };
            return copy;
        }
    }
}
