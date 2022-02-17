namespace ExemploConstrutores.Models
{
    public class Log 
    {
        private static Log _log;
        public string PropriedadeLog { get; set; }

        private Log()   //contrutor privado = evitar uma instância da classe
        {
            
        }

        public static Log GetInstance()
        {
            if (_log == null)     // se = log nulo
            {
                _log = new Log();   //criar nova instância
            }
            return _log;
        }
    }
}
