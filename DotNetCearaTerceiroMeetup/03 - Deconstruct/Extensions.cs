using System;
using System.Collections.Generic;

namespace Meetup.Deconstruct
{
    public static class Extensions
    {
        public static void Deconstruct<T>(this List<T> coleção, out int count, out int capacity, out T firstItem)
            => (count, capacity, firstItem) = (coleção.Count, coleção.Capacity, coleção.Count > 0 ? coleção[0] : default);

        public static void Deconstruct(this DateTime data, out int dia, out int mes, out int ano)
            => (ano, dia, mes) = (data.Year, data.Day, data.Month);
    }
}
