using System;

class TreeNode
{
  // Declaração de variáveis
  // Armazena um numero
  public int data;
  // Armazena a arvore da direita
  public TreeNode sad;
  // Armazena a arvore da esquerda
  public TreeNode sae;

  // Cria a estrutura da folha
  public TreeNode(int data)
  {
    // Recebe um numero e armazena ele
    this.data = data;
  }

  // Cria a estrutura dos nós intermediários
  public TreeNode(int data, TreeNode sae, TreeNode sad)
  {
    // Recebe um numero e armazena ele
    this.data = data;
    // Recebe a arvore da direita e armazena
    this.sad = sad;
    // Recebe a arvore da esquerda e armazena
    this.sae = sae;
  }

  // Função que desenha a árvore completa
  public void Print()
  {
    // Caso a arvore da esquerda não esteja vazia
    if (sae != null)
    {
      // Desenha a arvore da esquerda recursivamente
      sae.Print();
    }

    // Desenha os valor daquele nó
    Console.Write($"<{data}.");

    // Caso a arvore da direita não esteja vazia
    if (sad != null)
    { 
      // Desenha a arvore da direita recursivamente
      sad.Print();
    }

    Console.Write(">");
  }

  // Função para adicionar um novo valor na árvore
  public void Add(int key)
  {
    // Caso o valor que vai ser adicionado seja menor que a raiz,
    // então passa o valor para a esquerda
    if (key < data)
    {
      // Caso a esquerda não tenha folhas
      if (sae == null)
      {
        // Cria um nó novo, passa o valor, e adiciona ele como folha esquerda
        sae = new TreeNode(key);
      }
      // Caso não esteja
      else
      {
        // Passa o valor para ser adicionado em algum lugar na arvore esquerda,
        // recursivamente
        sae.Add(key);
      }
    }
    // Valor maior que a raiz, então vai ser adicionado na direita
    else
    {
      // Caso a direita não tenha folhas
      if (sad == null)
      {
        // Cria um nó novo, passa o valor, e adiciona ele como folha direita
        sad = new TreeNode(key);
      }
      // Caso não esteja
      else
      {
        // Passa o valor para ser adicionado em algum lugar na arvore esquerda,
        // recursivamente
        sad.Add(key);
      }
    }
  }
}