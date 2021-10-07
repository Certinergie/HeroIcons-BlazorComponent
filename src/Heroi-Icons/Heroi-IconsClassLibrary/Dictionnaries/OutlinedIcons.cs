using System.Collections.Generic;
using System.Linq;
using Heroi_IconsClassLibrary.Models;

namespace Heroi_IconsClassLibrary.Dictionnaries
{
    internal static class OutlinedIcons
    {
        private static IEnumerable<Icon> _icons = new List<Icon>()
        {
            new()
            {
                Type = IconType.AcademicCap,
                Paths = new List<Path>()
                {
                    new()
                    {
                        D = "M12 14l9-5-9-5-9 5 9 5z",
                        StrokeLineCap = null,
                        StrokeLineJoin = null,
                        StrokeWidth = 1
                    },
                    new()
                    {
                        D = "M12 14l6.16-3.422a12.083 12.083 0 01.665 6.479A11.952 11.952 0 0012 20.055a11.952 11.952 0 00-6.824-2.998 12.078 12.078 0 01.665-6.479L12 14z",
                        StrokeLineCap = null,
                        StrokeLineJoin = null,
                        StrokeWidth = 1
                    },
                    new ()
                    {
                        D = "M12 14l9-5-9-5-9 5 9 5zm0 0l6.16-3.422a12.083 12.083 0 01.665 6.479A11.952 11.952 0 0012 20.055a11.952 11.952 0 00-6.824-2.998 12.078 12.078 0 01.665-6.479L12 14zm-4 6v-7.5l4-2.222",
                        StrokeLineCap = "round",
                        StrokeLineJoin = "round",
                        StrokeWidth = 2
                    }
                },
                ViewBox = "0 0 24 24"
            }
        };

        internal static Icon GetOutlinedIcon(this IconType iconType)
        {
            return _icons.FirstOrDefault(x => x.Type == iconType);
        }
    }
}