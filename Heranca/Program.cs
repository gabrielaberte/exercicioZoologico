using Heranca;

//Animal animal = new Animal();
//Console.WriteLine($"{animal.ConsultarAnimal("arara", "ave")}");
Zoologico zoologico = new Zoologico();
Arara arara = new Arara();
Andorinha andorinha = new Andorinha();
Console.WriteLine($"Sou uma {arara.NomeAnimal}, {zoologico.ConsultarAnimal(arara)}. Atenção! {arara.LevantarVoo()}"); 
Console.WriteLine($"Sou uma {andorinha.NomeAnimal}, {zoologico.ConsultarAnimal(andorinha)}. Atenção! {andorinha.LevantarVoo()}");

Tubarao tubarao = new Tubarao();
Console.WriteLine($"Sou uma {tubarao.NomeAnimal}, {zoologico.ConsultarAnimal(tubarao)}. Atenção! {tubarao.NadarPraCima(1)}");