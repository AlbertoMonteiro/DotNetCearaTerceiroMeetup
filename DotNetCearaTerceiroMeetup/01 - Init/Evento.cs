using System;
using System.Collections.Generic;
using System.IO;

namespace Meetup.Init
{
    public class Evento
    {
        public string Nome { get; init; }
        public DateTime Data { get; init; }
        public string Organizador { get; init; }
        public Dictionary<int, string> Notas { get; } = new();
    }
}
