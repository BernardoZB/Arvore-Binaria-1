
using System;

class Program
{
    public static void Main(string[] args)
    {
        // Cria uma nova arvore começando pela raizuma
        TreeNode root = new TreeNode(13);
        // Adiciona valores na arvore
        root.Add(5);
        root.Add(15);
        root.Add(33);
        root.Add(1);
        root.Add(3);
        root.Add(2);
        root.Add(0);
        // Desenha a arvore completa
        root.Print();

    }
}