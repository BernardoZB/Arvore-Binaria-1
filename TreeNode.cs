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
            Console.Write(" SAE: ");
            // Desenha a arvore da esquerda recursivamente
            sae.Print();
        }

        // Desenha os valor daquele nó
        Console.Write($"<{data}.");

        // Caso a arvore da direita não esteja vazia
        if (sad != null)
        {
            Console.Write(" SAD: ");
            // Desenha a arvore da direita recursivamente
            sad.Print();
        }

        Console.Write(">");
    }

    // Função para procurar um valor na arvore
    public bool Find(int key)
    {
        // Caso encontre o valor, retorna verdadeiro
        if (key == data)
        {
            return true;
        }

        // Variável que vai armazenar o resultado da busca na arvore esquerda
        bool left = false;
        // Variável que vai armazenar o resultado da busca na arvore direita
        bool right = false;

        // Caso a arvore da esquerda não esteja vazia
        if (sae != null)
        {
            // Procura o valor na arvore da esquerda, recursivamente
            left = sae.Find(key);
        }

        // Caso a arvore da direita não esteja vazia
        if (sad != null)
        {
            // Procura o valor na arvore da direita, recursivamente
            right = sad.Find(key);
        }

        // Retorna o valor das variáveis da esqurda e direita
        return left || right;
    }

    // Função para retornar a altura da arvore
    public int Altura()
    {
        // Caso não tenha arvores na esquerda nem na direita
        if (sae == null && sad == null)
        {
            // Retorna zero, ou seja, a folha
            return 0;
        }
        // Caso tenha sub-arvores (troncos)
        else
        {
            //  Variável que armazena a altura da arvore esquerda, recursivamente
            int hsae = (sae != null ? sae.Altura() : -1);
            //  Variável que armazena a altura da arvore direita, recursivamente
            int hsad = (sad != null ? sad.Altura() : -1);
            // Compara qual a maior altura, soma a raiz e retorna o resultado
            return 1 + Math.Max(hsae, hsad);
        }
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

    // Função para remover um valor na árvore
    public TreeNode Remove(int key)
    {
        // Caso o valor a ser removido seja o do nó atual
        if (key == data)
        {  
            // Caso seja uma folha (não tenha sub-arvores direitas nem esquerdas)
            if (sae == null && sad == null)
            {
              // Anula o nó
              return null;
            }

            // Caso não tenha filhos na esqueda
            if (sae == null)
            {  
              // Torna o nó atual na arvore direita
                return sad;
            }

            // Caso não tenha filhos na edireita
            if (sad == null)
            {  
              // Torna o nó atual na arvore esquerda
                return sae;
            }

            // Caso tenha ambos os filhos,
            // cria um nó herdeiro que vai receber o nó filho da esquerda
            TreeNode herdeiro = sae;

            // Enquanto o nó herdeiro tenha filhos na direita
            while (herdeiro.sad != null)
            {
                // O nó herdeiro é substitudo pelo nó na sua esquerda
                herdeiro = herdeiro.sad;
            }

            // Cria uma variável temporária que vai receber o valor do nó herdeiro
            int tempData = herdeiro.data;
            // Remove o nó herdeiro
            Remove(herdeiro.data);
            //  Sla
            data = tempData;
            // Finaliza a execução
            return this;
        }
        // Caso o valor a ser removido não esteja no nó atual
        else
        {  
          // Caso o valor a ser procurado seja menor que o valor do nó atual
          // e tenha uma sub-arvore esquerda
            if (key < data && sae != null)
            {
              // Procura o valor na sub-arvore esquerda
                sae = sae.Remove(key);
            }
            // Caso o valor a ser procurado seja maior que o valor do nó atual
            // e tenha uma sub-arvore direita
            else if (key >= data && sad != null)
            {
              // Procura o valor na sub-arvore direita
                sad = sad.Remove(key);
            }
            // Finaliza a execução caso não exista o valor na arvore
            return this;
        }
    }
}