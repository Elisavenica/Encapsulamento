using System.Globalization;

namespace Course
{
    class Produto
    {
        // Definindo campos privados
        private string _nome;
        private double _preco;
        private int _quantidade;

        // Construtor padrão
        public Produto()
        {
            _quantidade = 5; // Definindo valor padrão para quantidade
        }

        // Construtor com parâmetros
        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }

        // Construtor com nome e preço, quantidade com valor padrão 5
        public Produto(string nome, double preco)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = 5;
        }

        // Método para retornar o nome
        public string GetNome()
        {
            return _nome;
        }

        // Método para definir o nome
        public void SetNome(string nome)
        {
            if (nome != null && nome.Length > 1)
                _nome = nome;
        }

        public double GetPreco()
        {
            return _preco;
        }

        public int GetQuantidade()
        {
            return _quantidade;
        }


        // Método para calcular o valor total em estoque
        public double ValorTotalEmEstoque()
        {
            return _preco * _quantidade;
        }

        // Método para adicionar quantidade ao estoque
        public void AdicionarProdutos(int quantidade)
        {
            _quantidade += quantidade;
        }

        // Método ToString para representar o objeto como uma string
        public override string ToString()
        {
            return _nome
                + " , $ "
                + _preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + _quantidade
                + " unidades, Total: $ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
