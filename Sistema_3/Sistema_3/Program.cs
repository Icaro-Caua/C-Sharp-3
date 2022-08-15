using System;
using System.Globalization;



namespace Sistema_3 {
    class Program { 
        static void Main(string[] args) {

            Produto p = new Produto();


            Console.WriteLine("Entre com os Dados do Produto:");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();

            Console.Write("Preço:");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quatidade do Estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados do Produto:" + p);


            Console.WriteLine();
            Console.WriteLine("Digite o número de produtos a ser adicionado:");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProduto(qte);
            Console.WriteLine("Dados Atualizados:" + p);



            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser Removido do estoque:");
            qte = int.Parse(Console.ReadLine());
            p.RomoverProduto(qte);
            Console.WriteLine("Dados Atualizados!" + p);
        }
    }
}