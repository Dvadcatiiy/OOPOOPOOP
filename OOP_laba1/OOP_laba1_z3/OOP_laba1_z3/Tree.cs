using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_laba1_z3
{
    internal class Tree
    {
        public string Value { get; set; }
        public List<Tree> Child { get; set; }
        public Tree(string value)
        {
            this.Value = value;
            Child = new List<Tree>();
        }
        public Tree(string value, Tree tree)
        {
            this.Value = value;
            Child = new List<Tree>();
            tree.Child.Add(this);
        }
        public void NewKid(Tree kid)
        {
            Child.Add(kid);
        }
        public void PrintC()
        {
            if (Child.Count > 0)
            {
                Console.WriteLine($"\nПотомки {Value}: ");
                for (int i = 0; i < Child.Count; i++)
                {
                    Console.WriteLine(Child[i].Value);
                }
                for (int i = 0; i < Child.Count; i++)
                {
                    Child[i].PrintC();
                }
            }
        }
    }
}

