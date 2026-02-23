//usando
using _02_23;

Produto prod1 = new Produto();
prod1.Nome = "Celular muito do brabo";
prod1.Preco = 259.90;

Produto prod2 = new Produto("Tablet de pobre", 89.90);

//Prod1
Console.WriteLine("Nome:" + prod1.Nome); // <- cw é um atalho pra invocar isso ai, o Write bota tudo na mesma linha e o Write Line quebra
Console.WriteLine($"Preco: {prod1.Preco}"); // <- Da pra interpolar com o + ou usando o $ antes da string


//Prod2
Console.WriteLine($"Nome:{prod2.Nome}");
Console.WriteLine("Preco:" + prod2.Preco);

//Objeto de Produto 2

Produto2 prod3 = new Produto2("Capinha lendária", 23.90, 500); // <- Poderia também ser criado sem mencionar o "Produto2" pós new, desde que coloque os parametros mesmo assim
prod3.Exibir();


Console.ReadKey();
//declarando
public class Produto
{
    public Produto(){}
    public Produto(string nome, double preco)
    {
        Nome = nome;
        this.Preco = preco;
    }
    public string? Nome { get; set; }
    public double Preco { get; set; }
}
