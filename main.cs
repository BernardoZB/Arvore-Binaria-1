using System;

class Program {
  public static void Main(string[] args) {

    Console.Write("\nAdicione uma raiz: ");
    // Cria uma nova arvore começando pela raizuma
    string input = Console.ReadLine();
    TreeNode root = new TreeNode(int.Parse(input));
    
    
    bool continuar = true;

    while (continuar) {
      root.Print();

      Console.WriteLine("\n\n**************************");
      Console.WriteLine("| Escolha uma ação:      |");
      Console.WriteLine("|   1. Adicionar         |");
      Console.WriteLine("|   2. Remover           |");
      Console.WriteLine("|   3. Achar             |");
      Console.WriteLine("|   4. Sair              |");
      Console.WriteLine("**************************\n");

      input = Console.ReadLine();
      int option = int.Parse(input);
      switch (option) {
        case 1:
          for (;;) {
            Console.Clear();
            // Desenha a arvore completa
            root.Print();
            Console.Write("\n\nAdicione um nó (digite 'voltar' para retornar): ");
            // Adiciona valores na arvore
            input = Console.ReadLine();
            if (input == "voltar") {
              break;
            }
            root.Add(int.Parse(input));
          }
          Console.Clear();
          break;
        case 2:
          Console.Clear();
          root.Print();
          Console.Write("\n\nRemover: ");
          input = Console.ReadLine();
          root.Remove(int.Parse(input));
          break;
        case 3:
          Console.Clear();
          root.Print();
          Console.Write("\nAchar: ");
          input = Console.ReadLine();
          Console.WriteLine(root.Find(int.Parse(input)) + "\n \n");
          
          break;
        case 4:
          continuar = false;
          break;
      }
    }
  }
}
