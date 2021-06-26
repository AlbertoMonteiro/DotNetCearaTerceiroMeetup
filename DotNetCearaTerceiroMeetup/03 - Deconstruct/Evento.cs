using System;

namespace Meetup.Deconstruct
{
    public class Evento
    {
        public string Nome { get; init; }
        public DateTime Data { get; init; }
        public string Organizador { get; init; }

        public void Deconstruct(out string nome, out DateTime data, out string organizador)
            => (nome, data, organizador) = (Nome, Data, Organizador);
    }
}
