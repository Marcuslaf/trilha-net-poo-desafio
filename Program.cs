using DesafioPOO.Models;

Console.WriteLine("=== Nokia ===");
Smartphone nokia = new Nokia("11999887766", "Nokia G60", "111222333444555", 128);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n=== iPhone ===");
Smartphone iphone = new Iphone("11777889966", "iPhone 15", "999888777666555", 256);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");