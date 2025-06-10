using DesafioPOO.Models;

// Especificações do celular Nokia, junto com método ligar e instalar 
Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "123456", modelo: "Modelo 1", imei: "111111111", memoria: 64);
nokia.ExibirEspecificacoes();
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

// Especificações do celular Nokia, junto com método ligar e instalar 
Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero: "4987", modelo: "Modelo 2", imei: "222222222", memoria: 128);
iphone.ExibirEspecificacoes();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");