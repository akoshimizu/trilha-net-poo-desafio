using DesafioPOO.Models;

var aparelho1 =  new Nokia("132-456-789", "5.3", "123456789", 256);
var aparelho2 =  new Iphone("147-258-369", "13-Pro", "741852963", 512);

aparelho1.InstalarAplicativo(aparelho1.Numero);

aparelho2.InstalarAplicativo(aparelho2.Numero);
Console.WriteLine();

Console.Write("Nokia ");
aparelho1.Ligar();

Console.Write("IPhone ");
aparelho2.ReceberLigacao();
Console.WriteLine();

Console.Write("IPhone ");
aparelho2.Ligar();

Console.Write("Nokia ");
aparelho1.ReceberLigacao();

Console.ReadKey();