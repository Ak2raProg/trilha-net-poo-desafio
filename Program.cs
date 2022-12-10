using DesafioPOO.Models;
// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("--Testando dispositivos que herdam a classe Smartphone-- \n");

Console.WriteLine("Smartphone Nokia: ");
Smartphone nokia = new Nokia(numero: "552231", modelo: "Modelo teste1", imei: "5463728203847", memoria: 128);
nokia.Ligar();
nokia.InstalarAplicativo("DIO");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone: ");
Smartphone iphone = new Iphone(numero: "4657389", modelo: "Modelo teste2", imei: "7583049574632", memoria: 32);
iphone.Ligar();
iphone.InstalarAplicativo("Clans of Clash");
