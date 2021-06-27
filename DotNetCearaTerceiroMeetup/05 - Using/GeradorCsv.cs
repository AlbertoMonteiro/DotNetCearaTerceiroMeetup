using System;
using System.IO;

namespace Meetup.Using
{
    public static class GeradorCsv
    {
        public static void GerarCsv()
        {
            //var streamWriter = new StreamWriter(@"C:\temp\todo.txt");
            //using (streamWriter)
            //{
            //    streamWriter.WriteLine("1");
            //    streamWriter.WriteLine("2");
            //    streamWriter.WriteLine("3");
            //    streamWriter.WriteLine("4");
            //}

            #region Novo - Sem spoiler
            using var streamWriter = new StreamWriter(@"C:\temp\todo.txt");
            streamWriter.WriteLine("1");
            streamWriter.WriteLine("2");
            streamWriter.WriteLine("3");
            streamWriter.WriteLine("4");

            using var placebo = new Placebo();
            placebo.MandaUmOi();
            #endregion
        }

        public class Placebo : IDisposable
        {
            public Placebo() => Console.WriteLine("Classe instanciada.");

            public void MandaUmOi() => Console.WriteLine("Oi pessoal!!");

            public void Dispose() => Console.WriteLine("Dispose chamado.");
        }
    }
}
