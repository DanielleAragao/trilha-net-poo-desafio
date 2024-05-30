using DesafioPOO.Models;


// implementado

Console.WriteLine("Nokia: ");
Smartphone n = new Nokia (numero: "153695", modelo: "Modelo 1", imei: "8888", memoria: 32);
n.Ligar();
n.InstalarAplicativo("Facebook");

Console.WriteLine("Iphone: ");
Smartphone i = new Iphone (numero: "5454", modelo: "Modelo 2", imei: "3333", memoria: 64);
n.Ligar();
n.InstalarAplicativo("Instagram");