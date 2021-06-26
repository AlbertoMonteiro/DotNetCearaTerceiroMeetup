using Meetup.Records;
using System;
using System.Linq.Expressions;
using System.Reflection;

namespace Meetup.Pattern_Matching
{
    public static class PatternMatching
    {
        public static void Um(object valor)
        {
            if (valor is string str)
                Console.WriteLine($"é uma string {str}");
            else if (valor is int @int)
                Console.WriteLine($"é uma inteiro {@int}");
            else if (valor is Palestra palestra)
                Console.WriteLine($"é uma palestra {palestra}, viu que record já tem o ToString implementando mostrando os valores? legal né!!");
        }

        public static void Dois(object valor)
        {
            var mensagem = valor switch
            {
                string str => $"é uma string {str}",
                int @int => $"é uma inteiro {@int}",
                Palestra palestra => $"é uma palestra {palestra}, viu que record já tem o ToString implementando mostrando os valores? legal né!!",
                _ => "Vixe, sei o que é isso não"
            };

            Console.WriteLine(mensagem);
        }

        public static void Três(object valor)
        {
            var mensagem = valor switch
            {
                string str => $"é uma string {str}",
                int @int => $"é uma inteiro {@int}",
                Palestra palestra when palestra.Palestrante == "Alberto Monteiro" => $"essa palestra é arretada",
                Palestra palestra => $"é uma palestra {palestra}, viu que record já tem o ToString implementando mostrando os valores? legal né!!",
                _ => "Vixe, sei o que é isso não"
            };

            Console.WriteLine(mensagem);
        }

        public static void Quatro()
        {
            var httpStatusCode = 201;

            //                httpStatusCode >= 200 && httpStatusCode <= 299
            Console.WriteLine(httpStatusCode is >= 200 and <= 299
                ? "Ai sim viu, deu certo, graças a Deus!!"
                : "Lascou, lá vem problema 😒");
        }

        public static void Cinco()
        {
            Palestra[] palestras =
            {
                new("Resiliencia com Polly", "Davi Holanda"),
                new("Criando testes com NUnit e Moq", "Gleryston Matos")
            };

            foreach (var palestra in palestras)
            {
                //if ((palestra.Palestrante == "Davi Holanda" || palestra.Palestrante == "Gleryston Matos") palestra.Titulo.Length > 0)
                if (palestra is { Palestrante: "Davi Holanda" or "Gleryston Matos", Titulo: { Length: > 0 } titulo })
                    Console.WriteLine($"Esse ai se preocupa com qualidade viu!!! Saca só a palestra top: {titulo}");
            }
        }

        public static void Seis()
        {
            Palestra palestra = new("Resiliencia com Polly", "Davi Holanda");
            var informações = (true, palestra.Titulo, palestra.Palestrante);

            var mensagem = informações switch
            {
                (true, _, _) => "Vixe, a palestra já passou",
                (_, var titulo, var palestrante) => $"A palestra: {titulo} do {palestrante} ainda vai acontecer"
            };
            Console.WriteLine(mensagem);
        }

        public static void Sete(string tituloPalestra = "C# como você nunca viu")
        {
            Expression<Func<Palestra, bool>>[] filtros =
            {
                palestra => palestra.Titulo == tituloPalestra,
                palestra => "C# como você nunca viu" == tituloPalestra,
            };

            foreach (var filtro in filtros)
            {
                if (filtro.Body is BinaryExpression
                    {
                        NodeType: ExpressionType.Equal,
                        Left: MemberExpression { Member: { Name: nameof(Palestra.Titulo) } } or ConstantExpression,
                        Right: MemberExpression
                        {
                            Member: FieldInfo { Name: "tituloPalestra" } member,
                            Expression: ConstantExpression constantExpression
                        }
                    } && member.GetValue(constantExpression.Value) is "C# como você nunca viu")
                {
                    Console.WriteLine("O filtro está certinho");
                }
            }
        }
    }
}
