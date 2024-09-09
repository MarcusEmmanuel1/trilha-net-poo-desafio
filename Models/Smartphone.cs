namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        protected string Imei { get; set; }
        public string Modelo { get; set; }
        protected int Memoria  { get; set; }
        public bool Ligado { get; set; }

        public Smartphone(string numero, string imei, string modelo, int memoria, bool ligado)
        {
            Numero = numero;
            Imei = imei;
            Modelo = modelo;
            Memoria = memoria;
            Ligado = ligado;
        }

        public void Ligar()
        {
            Ligado = true;
            Console.WriteLine("Ligando...");
        }

        public void Desligar()
        {
            Ligado = false;
            Console.WriteLine("Desligando...");
        }

        public void ReceberLigacao()
        {
            if (Ligado)
            {
                Console.WriteLine("Recebendo ligação...");
            }
            else
            {
                Console.WriteLine("Ligue o smartphone para receber a ligação.");
            }
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}