using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Tree
{
    public class TreeNode
    {
        public object Data { get; set; }
        public TreeNode[] Links { get; private set; }
        public List<TreeNode> DynamicLinks { get; private set; }

        public TreeNode(object data, int maxDegree = 3)
        {
            Data = data;
            Links = new TreeNode[maxDegree];
            DynamicLinks = new List<TreeNode>();
        }

    }
}
