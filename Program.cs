using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Nokia Papai:");
Smartphone nokia = new Nokia("13213131", "Nokia 12", "IMEI1323131", 128);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Bíblia Sagrada");


Console.WriteLine("\nIphone Papai:");
Smartphone iphone = new Iphone("1232134", "Iphone 8", "IMEI99129321", 32);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Bíblia Sagrada Plus");