//instanciar =  valores pré-definidos\\ c# define construtor padrão
namespace ExemploConstrutores.Models
{
    public class Pessoa
    {
        private readonly string name = "Gi";  //proteção de campos contra alteração em qualquer momento do código que não seja na inicialização/construtor
        private readonly string sobrenome;
        public Pessoa()     //construtor : atalho "ctor" : mesmo nome da classe e sem retorno(vazio)
        {
            name = string.Empty;
            sobrenome = string.Empty;
        }
        
        public Pessoa(string nome, string sobrenome)
        {
            this.name = nome;
            this.sobrenome = sobrenome;
            System.Console.WriteLine("Construtor classe pessoa!");
        }

        public void Apresentar()
        {
            System.Console.WriteLine($"Olá meu nome é: {name} {sobrenome}");      
        }
    }
}
