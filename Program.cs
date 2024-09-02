using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia");
Nokia nokia = new Nokia("123456789", "motog24", "19912boeb12", 32);
nokia.Ligar();
nokia.InstalarAplicativo("whatsapp");
nokia.ReceberLigacao();

Console.WriteLine("Iphone");
Iphone iphone = new Iphone("119121339", modelo: "Iphone15", "ontaoeu312", 64);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("telegram");
