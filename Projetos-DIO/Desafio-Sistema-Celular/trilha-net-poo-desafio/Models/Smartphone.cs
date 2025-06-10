namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama
        private string Modelo { get; set; }

        private string IMEI { get; set; }

        private int Memoria { get; set; }

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }

        /// <summary>
        /// 
        /// </summary>
        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        /// <summary>
        /// 
        /// </summary>
        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public void ExibirEspecificacoes()
        {
            Console.WriteLine("=== Especificações do Smartphone ===");
            Console.WriteLine($"Numero: {Numero}");
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"IMEI: {IMEI}");
            Console.WriteLine($"Memoria: {Memoria}");
        }

        /// <summary>
        /// Instalar aplicativo recebido por parâmetro
        /// </summary>
        /// <param name="nomeApp">Nome do aplicativo</param>
        public abstract void InstalarAplicativo(string nomeApp);
    }
}