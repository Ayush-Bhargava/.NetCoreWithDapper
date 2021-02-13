using AutoMapper;
using System.Collections;
using System.Collections.Generic;

namespace DoodleBlueMappers
{
    public static class MapList
    {
        public static IEnumerable<TOutput> MapAll<TOutput>(this IMapper mapper, IEnumerable input)
        {
            var output = new List<TOutput>();

            foreach (var item in input)
            {
                output.Add(mapper.Map<TOutput>(item));
            }

            return output;
        }
    }
}
