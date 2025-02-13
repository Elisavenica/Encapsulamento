using System.Globalization;

using System.Globalization;

namespace Course
{
    class Produto
    {
        private string _nome;
        private double _preco;
        private int _quantidade;

        public Produto()
        {
            _quantidade = 5;
        }
        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }
        public Produto(string nome, double preco)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = 5;
        }
        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != null && value.Length > 1)
                    _nome = value;
            }
        }

       // public
        public double GetPreco()
        {
            return _preco;
        }
        public int GetQuantidade()
        {
            return _quantidade;
        }
        public double ValorTotalEmEstoque()
        {
            return _preco * _quantidade;
        }
        public void AdicionarProdutos(int quantidade)
        {
            _quantidade += quantidade;
        }
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



