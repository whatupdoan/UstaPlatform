using System.Collections;

namespace UstaPlatform.Domain
{
    public class Route : IEnumerable<(int X, int Y)>
    {
        private readonly List<(int X, int Y)> _duraklar = new();

        public void Add(int X, int Y)
        {
            _duraklar.Add((X, Y));
        }

        public IEnumerator<(int X, int Y)> GetEnumerator() => _duraklar.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
