using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure.Tree
{
    public class NLinkNode
    {
        public NLinkNode()
        {
            var a = new TreeNode("A");
            var b = new TreeNode("B");
            var c = new TreeNode("C");
            var d = new TreeNode("D");

            a.Links[0] = b;
            a.Links[1] = c;
            a.Links[2] = d;

            b.Links[0] = new TreeNode("E");
            b.Links[1] = new TreeNode("F");

            c.Links[0] = new TreeNode("G");

            d.Links[0] = new TreeNode("H");
            d.Links[1] = new TreeNode("I");


            for (int i = 0; i < a.Links.Length; i++)
            {
                Console.WriteLine(a.Links[i].Data);
            }
        }
    }
}
