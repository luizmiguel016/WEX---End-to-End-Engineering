namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public string NomeApp;
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {

        }

        /// <summary>
        /// Instalar aplicativo recebido como parâmetro
        /// </summary>
        /// <param name="nomeApp">Nome do aplicativo</param>
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo \"{nomeApp}\" no Iphone");
        }
        // TODO: Sobrescrever o método "InstalarAplicativo"
    }
}