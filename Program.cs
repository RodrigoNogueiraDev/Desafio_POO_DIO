using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Celular Nokia");
Smartphone nokia = new Nokia(numero: "61982288581", modelo: "Nokia", imei: "12345678", memoria: 256);
Console.WriteLine(nokia.Numero);
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Instagran");

Console.WriteLine();

Console.WriteLine("Celular Iphone");
Smartphone iphone = new Iphone(numero: "61985812275", modelo: "Iphone", imei: "55555555", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Whats");
