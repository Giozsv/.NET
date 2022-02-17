namespace ExemploConstrutores.Models
{
    public class Calculadora
    {
        //Delegate
        public delegate void DelegateCalculadora();
        
        //Evento
        public static event DelegateCalculadora EventoCalculadora;      //evento = outros obj. podem se inscrevem 
        public static void Somar(int x, int y)
        {
            if (EventoCalculadora != null)      //caso inscrito = executá=lo
            {
                System.Console.WriteLine($"Adição: {x + y}");   
                EventoCalculadora();
            }
            else 
            {
                System.Console.WriteLine("Nenhum Inscrito");
            }
        }
        public static void Subtrair(int x, int y)
        {
            System.Console.WriteLine($"Subtração: {x - y}");
        }
    }
}
