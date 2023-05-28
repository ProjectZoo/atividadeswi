namespace Atividadeheranca2;
class Program
{
    static void Main(string[] args)
    {
        PessoaFisica contratoPessoaFisica = new PessoaFisica();
        contratoPessoaFisica.CPF = "123.456.789-00";
        contratoPessoaFisica.Idade = 30;
        PessoaJuridica contratoPessoaJuridica = new PessoaJuridica();
        contratoPessoaJuridica.CNPJ = "12.345.678/0001-00";
        contratoPessoaJuridica.inscricaoestadual = "121212121212";
        Console.WriteLine("Contrato Pessoa Física:");
        Console.WriteLine("CPF: " + contratoPessoaFisica.CPF);
        Console.WriteLine("Idade: " + contratoPessoaFisica.Idade);
        Console.WriteLine("Contrato Pessoa Jurídica:");
        Console.WriteLine("CNPJ: " + contratoPessoaJuridica);
        Console.WriteLine("Inscrição Estadual: " + contratoPessoaJuridica.inscricaoestadual);
    
    

    
    
    }
}
