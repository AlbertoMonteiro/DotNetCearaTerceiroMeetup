using Meetup.Deconstruct; //joga lá em cima!!
using Meetup.Tuple;

const string VERDE_NEGRITO = "\x1B[0;1;5;32m";
const string RESET = "\x1B[0m";
System.Console.WriteLine($"{VERDE_NEGRITO}Bem vindo ao 3º meetup do grupo dotnet Ceará{RESET}");


#region 01 - Init
//var evento = new Evento()
//{
//    Nome = "dotnet ceará 3º meetup",
//    Data = new System.DateTime(2021, 6, 26),
//    Organizador = "Davi Holanda"
//};

//evento.Nome = "dotnet ceará 2º meetup";
#endregion

#region 02 - Tuple
System.Console.WriteLine("Executa tuplas?");
var key = System.Console.ReadKey();
if (key.Key != System.ConsoleKey.Y)
    return;
System.Console.Clear();

var (soma, subtração, multiplicação, divisão) = Calculadora.OperacoesBasicas(5, 5);
System.Console.WriteLine($"{VERDE_NEGRITO}O valor da soma é: {soma}{RESET}");
System.Console.WriteLine($"{VERDE_NEGRITO}O valor da subtração é: {subtração}{RESET}");
System.Console.WriteLine($"{VERDE_NEGRITO}O valor da multiplicação é: {multiplicação}{RESET}");
System.Console.WriteLine($"{VERDE_NEGRITO}O valor da divisão é: {divisão}{RESET}");
#endregion

#region 03 - Deconstruct
System.Console.WriteLine("Executa Deconstruct?");
key = System.Console.ReadKey();
if (key.Key != System.ConsoleKey.Y)
    return;
System.Console.Clear();
System.Console.WriteLine("\x1B[0;1;5;31mDescomenta o código da region!!" + RESET);
System.Collections.Generic.List<int> inteiros = new() { 1 };

var (total, capacidade, primeiro) = inteiros;
System.Console.WriteLine($"{VERDE_NEGRITO}Total de elementos: {total}, capacidade: {capacidade}, primeiro: {primeiro}{RESET}");

System.Collections.Generic.List<string> nomes = new() { "Alberto", "Monteiro" };

var (_, capacity, _) = nomes;
System.Console.WriteLine($"{VERDE_NEGRITO}Total de elementos: não pedi o count, capacidade: {capacity}, dessa vez não pedi o primeiro{RESET}");

var (dia, mes, ano) = System.DateTime.Now;
System.Console.WriteLine($"{VERDE_NEGRITO}Hoje é dia {dia} do mês {mes} do ano {ano}{RESET}");
#endregion

#region 04 - Records
System.Console.WriteLine("Executa Records?");
key = System.Console.ReadKey();
if (key.Key != System.ConsoleKey.Y)
    return;
System.Console.Clear();
var palestra = new Meetup.Records.Palestra("C# como você nunca viu", "Alberto Monteiro");
var outraPalestra = new Meetup.Records.Palestra("C# como você nunca viu", "Alberto Monteiro");

System.Console.WriteLine($"{VERDE_NEGRITO}E ai, esses records são iguais? {palestra == outraPalestra}{RESET}");

var algumEvento = new Meetup.Init.Evento() { Nome = "dotnet ceará 3º meetup", Data = new System.DateTime(2021, 6, 26), Organizador = "Davi Holanda" };
var outroEvento = new Meetup.Init.Evento() { Nome = "dotnet ceará 3º meetup", Data = new System.DateTime(2021, 6, 26), Organizador = "Davi Holanda" };

System.Console.WriteLine($"{VERDE_NEGRITO}E ai, esses classes(instancias) são iguais? {algumEvento == outroEvento}{RESET}");

var mapster = new Meetup.Records.Palestra("Mapster: Uma alternativa", "Ynoa Pedro");

System.Console.WriteLine($"{VERDE_NEGRITO}E agora? {palestra == mapster}{RESET}");

var mapster2 = mapster with
{
    Palestrante = "Alberto Monteiro",
    Titulo = "C# como você nunca viu"
};

System.Console.WriteLine($"{VERDE_NEGRITO}E agora? {palestra == mapster2}{RESET}");

//evento.Nome = "dotnet ceará 2º meetup"; 
#endregion

#region 05 - Using
System.Console.WriteLine("Executa Using?");
key = System.Console.ReadKey();
if (key.Key != System.ConsoleKey.Y)
    return;
System.Console.Clear();
Meetup.Using.GeradorCsv.GerarCsv();
#endregion

#region 06 - Pattern Matching
System.Console.WriteLine("Executa Pattern Matching?");
key = System.Console.ReadKey();
if (key.Key != System.ConsoleKey.Y)
    return;
System.Console.Clear();

object[] objetos =
{
    "valor",
    1,
    new Meetup.Records.Palestra("Titulo", "Alguém"),
    new Meetup.Records.Palestra("Titulo", "Alberto Monteiro")
};

System.Console.WriteLine($"{VERDE_NEGRITO}PM UM{RESET}");
foreach (var item in objetos)
    Meetup.Pattern_Matching.PatternMatching.Um(item);

System.Console.WriteLine($"{VERDE_NEGRITO}PM DOIS{RESET}");
foreach (var item in objetos)
    Meetup.Pattern_Matching.PatternMatching.Dois(item);
Meetup.Pattern_Matching.PatternMatching.Dois(true);

System.Console.WriteLine($"{VERDE_NEGRITO}PM TRÊS{RESET}");
foreach (var item in objetos)
    Meetup.Pattern_Matching.PatternMatching.Três(item);

System.Console.WriteLine($"{VERDE_NEGRITO}PM QUATRO{RESET}");
Meetup.Pattern_Matching.PatternMatching.Quatro();

System.Console.WriteLine($"{VERDE_NEGRITO}PM CINCO{RESET}");
Meetup.Pattern_Matching.PatternMatching.Cinco();

System.Console.WriteLine($"{VERDE_NEGRITO}PM SEIS{RESET}");
Meetup.Pattern_Matching.PatternMatching.Seis();

System.Console.WriteLine($"{VERDE_NEGRITO}PM SETE{RESET}");
Meetup.Pattern_Matching.PatternMatching.Sete();
#endregion