using OOP_laba1_z3;
using System;
using System.Xml.Serialization;

class Program
{
    public static void Main(string[] args)
    {
        Tree tree = new Tree("Прадедушка Саша");
        Tree child1 = new Tree("Дедушка Серёжа", tree);
        Tree child11 = new Tree("Папа Саша", child1);
        Tree child12 = new Tree("Тётя Даша", child1);
        Tree child13 = new Tree("Дядя Витя", child1);
        Tree child111 = new Tree("Сын Миша (я)", child11);
        tree.PrintC();
    }
}
