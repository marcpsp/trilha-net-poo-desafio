using DesafioPOO.Models;

Console.WriteLine($"Carregando informações sobre o seu smartphone ...");

Smartphone iphone = new Iphone(numero: "99999999999", modelo: "Iphone XR", imei: "356423104640317", memoria: 64);
iphone.Ligar();
iphone.InstalarAplicativo("Baidu");

Console.WriteLine($"Carregando informações sobre o seu smartphone ...");

Smartphone nokia = new Nokia(numero: "99999999998", modelo: "Nokia Tijolo", imei: "356423104640320", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Avast");