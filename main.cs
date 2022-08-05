using System;

class Program {
  public static void Main (string[] args) {

    Console.Write("\nAdicione um nó: ");
    // Cria uma nova arvore começando pela raizuma
    TreeNode root = new TreeNode(int.Parse(Console.ReadLine()));
    
    for(;;) {
      Console.Clear();
      // Desenha a arvore completa
      root.Print();
      Console.Write("\n\nAdicione um nó: ");
      // Adiciona valores na arvore
      root.Add(int.Parse(Console.ReadLine()));
    }
  }
}