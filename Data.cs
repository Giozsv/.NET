namespace ExemploConstrutores.Models
{
    public class Data
    {
        private int mes;   //sem alteração externa
        private bool mesValido;

        public int GetMes()
        {
            return this.mes;
        }

        public void SetMes(int mes)
        {
            if(mes > 0 && mes <= 12)
            {
                this.mes = mes;
                this.mesValido = true;
            }
        }
        public int Mes    ///modificar p/ colocar validações
        {
            get
            {
                return this.mes;
            }

            set
            {
                if (value > 0 && value <= 12){
                    this.mes = value;
                    this.mesValido = true;
                }
            }
        }
        public void ApresentarMes()
        {
            if(this.mesValido)
            {
                System.Console.WriteLine(this.mes);
            }
            else
            {
                System.Console.WriteLine("Mes Invalido");   //atalho = cw
            }
        }
    }
}
