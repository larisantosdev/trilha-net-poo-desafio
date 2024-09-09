using DesafioPOO.Models;

var nokia = new Nokia("1234", "Nokia", "Imei-432", 986547);

Console.WriteLine("Smartphone Nokia:");
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");

var iphone = new Iphone("9999", "Iphone", "Imei-2233", 843721);

iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");