namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string imei, string modelo, int memoria, bool ligado) : base(numero, imei, modelo, memoria, ligado)
        {
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            if (Ligado)// checa se o smartphone ta ligado
            {
                Console.WriteLine($"Instalando Aplicativo '{nomeApp}' de App Store.");
            }
            else
            {
                Console.WriteLine("Ligue o smartphone para instalar o aplicativo."); 
            }
        }
    }
}