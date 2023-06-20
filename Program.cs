using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula09EstoqueDeProdutosTer200623
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> produtos = new List<string> { "pepsi", "fanta" };

            Console.WriteLine("Bem-vindo ao Conradito Store");
            Console.WriteLine("");

            while (true)
            {
                Console.WriteLine("digite '1' para cadastrar ou '2' para listar");
                string resposta = Console.ReadLine();
                
                if (resposta == "1")
                {
                    Console.WriteLine("Digite o nome do produto: ");
                    string produto = Console.ReadLine();

                    if (produtos.Contains(produto)) //if (produtos.Contains( é o codigo que mostra oque contem dentro de uma lista, e depois vem o nome da variavel
                                                    //que esta guardada na variavel PRODUTO nesse caso
                    {
                        Console.WriteLine("Este item já existe na lista...");
                    }
                    else // Se o produto não parar no if (Se ele n existir) ele cai para o else, que é, cadastrar ((( produtos.Add(produto); )))
                    {
                        produtos.Add(produto);
                        Console.WriteLine("Produto adicionado!");
                    }
                                                    


                        ///produtos.Add(produto);
                        // A minha lista de produtos está adicionando um produto (o produto que a pessoa digitou)
                        //Se tem uma lista no plural, coloca o produto no singular


                    
                }
                else
                {
                    string texto = "";
                    int contador = 0; //Começa pelo item 0 que é o primeiro item da lista


                    

                    while (contador < produtos.Count) //enquanto o contador (que é 0) for menor que o produto.Count (que ta contando os produtos) ele roda
                    {
                        //Console.WriteLine($"Nome do produto: {produtos[ contador]}"); //supondo que temos 3 itens, o contador fala que tem 3 itens (0,1,2) depois que roda
                        //ele joga produtos para posição 2
                        //Aumentou novamente, ele sai do looping sozinho porque o 3 não tem, ai ele sai
                        
                        
                        texto += produtos[contador] + " , ";
                        contador++;
                    }

                    texto = texto.Substring(0, texto.Length - 2);
                    //[0] => pespi
                    //[1] => pespi
                    //texto => pespi, famta.....
                    Console.WriteLine(texto);
                
                
                }



            }

            Console.ReadKey();


        }
    }
}
