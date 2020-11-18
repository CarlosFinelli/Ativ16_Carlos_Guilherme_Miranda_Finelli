using System;
using System.Collections.Generic;
using System.Text;

namespace QuestaoB
{
    class Produto
    {
        public String Nome { get; set; }
        public int Quantidade { get; set; }
        public double Preco { get; set; }

        public double setPreco { set { Preco = value; } }

        public int setQtd { set { Quantidade = value; } }

        public double ValorTotalEmEstoque { get { return Preco * Quantidade; } }

        public int AdicionarProduto { set { Quantidade += value; } }

        public int RemoverProdutos { set { Quantidade -= value; } }
    }
}
