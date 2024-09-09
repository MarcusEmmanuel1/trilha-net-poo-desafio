using System.IO.MemoryMappedFiles;
using System.Threading.Channels;
using DesafioPOO.Models;

Smartphone Nokia = new Nokia(numero: "1234", imei: "11111111", modelo: "Nokia C21 Plus", memoria: 128, ligado: false);
Console.WriteLine($"Smartphone Nokia modelo: {Nokia.Modelo}.");
Nokia.Ligar();
//Nokia.Desligar(); //funçao desligar o celular, por padrão vai estar desligado.
Nokia.ReceberLigacao();
Nokia.InstalarAplicativo("Whatsapp");

Smartphone Iphone = new Iphone(numero: "5678", imei: "22222222", modelo: "Iphone 15", memoria: 256, ligado: false);
Console.WriteLine($"\nSmartphone Iphone modelo: {Iphone.Modelo}.");
Iphone.Ligar();
//Iphone.Desligar(); //funçao desligar o celular, por padrão vai estar desligado.
Iphone.ReceberLigacao();
Iphone.InstalarAplicativo("Instagram");