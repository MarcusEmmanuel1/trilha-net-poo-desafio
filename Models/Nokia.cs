using System.Threading.Channels;

namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string imei, string modelo, int memoria, bool ligado) : base(numero, imei, modelo, memoria, ligado)
        {
        }
        public override void InstalarAplicativo(string nomeApp)
        {
            if (Ligado) //checa se o smartphone ta ligado
            {
                Console.WriteLine($"Instalando Aplicativo '{nomeApp}' de Play Store.");
            }
            else
            {
                Console.WriteLine("Ligue o smartphone para instalar o aplicativo."); 
            }
        }
    }
}