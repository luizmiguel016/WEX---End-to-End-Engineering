using System.Reflection.PortableExecutable;

namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
            
        }
        public string NomeApp { get; set; }
        
        /// <summary>
        /// Instalar algum aplicativo recebido como parâmetro
        /// </summary>
        /// <param name="nomeApp">Nome do aplicativo</param>
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo \"{nomeApp}\" no Nokia");
        }
    }
}