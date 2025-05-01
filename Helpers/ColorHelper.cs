using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facultate.Helpers
{
    public static class ColorHelper
    {
        private static readonly Dictionary<string, Color> _map = new();

        public static Color GetColorForDepartment(string dept)
        {
            if (_map.TryGetValue(dept, out var c)) return c;
            var rnd = new Random();
            var newColor = Color.FromArgb(
                rnd.Next(50, 230),
                rnd.Next(50, 230),
                rnd.Next(50, 230));
            _map[dept] = newColor;
            return newColor;
        }
    }
}
