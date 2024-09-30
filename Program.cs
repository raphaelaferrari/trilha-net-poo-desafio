using DesafioPOO.Models;

Smartphone iphone = new Iphone("991111111", "Iphone 15 Pro Max", "11111111", 128);
iphone.InstalarAplicativo("Twitter");
iphone.Ligar();
iphone.ReceberLigacao();

Console.WriteLine("\n");

Smartphone nokia = new Nokia("999111111", "Nokia C21 Plus", "222222222", 128);
nokia.InstalarAplicativo("Instagram");
nokia.Ligar();
nokia.ReceberLigacao();