using ExemploConstrutores.Models;

namespace ExemploConstrutores
{
    class Progran
    {
        public delegate void Operacao(int x, int y);
        static void Main(string[] args)
        {
            Matematica m = new Matematica(10, 20);
            m.Somar();
            

             Operacao op = Calculadora.Somar;
             Operacao op = new Operacao(Calculadora.Somar);
             op += Calculadora.Subtrair;       //MultiCast = Utilização de dois métodos
            
             op.Invoke(10, 10);                //Ordem FIFO = primeiro a entrar, primeiro a sair
            
             op(10, 10); 




             const double pi = 3.14;        //valores imutáveis = valores que precisam se manter o mesmo sem alterações após a inicialização
             System.Console.WriteLine(pi);



              Data data = new Data();
              data.SetMes(2);

             data.Mes = 12;
             System.Console.WriteLine(data.Mes);

             data.ApresentarMes();
    



             Log log = Log.GetInstance();

             log.PropriedadeLog = "Teste Intancia";

             Log log2 = Log.GetInstance();
             System.Console.WriteLine(log2.PropriedadeLog);

             Aluno p1 = new Aluno("Giovanna", "Barbosa", "Teste");
             p1.Apresentar();
        }
    }

}
