using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia");
Nokia telefone1 = new Nokia ("981430583", "AX3002", "123456", 16);
telefone1.PropiedadesSmartphone();
telefone1.Ligar();
telefone1.ReceberLigacao();
telefone1.InstalarAplicativo("Facebook");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone");
Iphone telefone2 = new Iphone("981763432", "2024XD", "987654", 128);
telefone2.PropiedadesSmartphone();
telefone2.Ligar();
telefone2.ReceberLigacao();
telefone2.InstalarAplicativo("DU Recorder");