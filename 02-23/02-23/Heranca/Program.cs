Aluno aluno1 = new Aluno("Paulo", "511.232.123-77", "012345678910");
Console.WriteLine($"Nome:{aluno1.Nome}\n CPF: {aluno1.CPF}\n {aluno1.Ra}");

Console.WriteLine("Digite o nome do professor");
var nomeProf = Console.ReadLine();
Console.WriteLine("Digite o CPF do professor");
var CPFProf = Console.ReadLine();
Console.WriteLine("Digite a titulação do professor");
var titulacaoProf = Console.ReadLine();

Professor prof1 = new Professor(nomeProf, CPFProf, titulacaoProf);
prof1.Exibir(prof1);
Console.ReadKey();
public class Pessoa
{

    public Pessoa(string? nome, string? cpf)
    {
        Nome = nome;
        CPF = cpf;
    }

    
    public string? Nome { get; set; }
    public string? CPF { get; set; }
        

}
public class Aluno:Pessoa
{
    public Aluno(string? nome, string? cpf, string ra) : base(nome,cpf)
    {
        Ra = ra;
    }
    public string? Ra { get; set; }

}

public class Professor:Pessoa
{
    public void Exibir(Professor prof) =>
    
        Console.WriteLine($"Nome: {prof.Nome}\n Cpf: {prof.CPF}\n Titulacao: {prof.Titulacao} ");
    

    public Professor(string? nome, string? cpf, string titulacao) : base(nome, cpf)
    {
     Titulacao = titulacao;   
    }
    public string? Titulacao { get; set; }

    }