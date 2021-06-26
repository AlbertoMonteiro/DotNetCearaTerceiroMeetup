namespace Meetup.Tuple
{
    public static class Calculadora
    {
        public static (int soma, int subtração, int multiplicação, int divisão) OperacoesBasicas(int a, int b)
            => (a + b, a - b, a * b, a / b);
    }
}
