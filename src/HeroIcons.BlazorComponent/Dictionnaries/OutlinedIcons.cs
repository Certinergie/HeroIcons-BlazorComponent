using System.Collections.Generic;
using System.Linq;
using HeroIcons.BlazorComponent.Models;

namespace HeroIcons.BlazorComponent.Dictionnaries
{
    internal static class OutlinedIcons
    {
        private static IEnumerable<Icon> _icons = new List<Icon>()
        {
            new()
            {
                Type = IconType.AcademicCap,
                Paths = new List<Path>
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
            },
            new()
            {
                Type = IconType.Adjustments,
                Paths = new List<Path>
                {
                    new()
                    {
                        D = "M12 6V4m0 2a2 2 0 100 4m0-4a2 2 0 110 4m-6 8a2 2 0 100-4m0 4a2 2 0 110-4m0 4v2m0-6V4m6 6v10m6-2a2 2 0 100-4m0 4a2 2 0 110-4m0 4v2m0-6V4",
                        StrokeLineCap = "round",
                        StrokeLineJoin = "round",
                        StrokeWidth = 2
                    }
                },
                ViewBox = "0 0 24 24"
            },
            new()
            {
                Type = IconType.Annotation,
                Paths = new List<Path>
                {
                    new()
                    {
                        D = "M7 8h10M7 12h4m1 8l-4-4H5a2 2 0 01-2-2V6a2 2 0 012-2h14a2 2 0 012 2v8a2 2 0 01-2 2h-3l-4 4z",
                        StrokeLineCap = "round",
                        StrokeLineJoin = "round",
                        StrokeWidth = 2
                    }
                } ,
                ViewBox = "0 0 24 24"
            },
            new()
            {
                Type = IconType.Archive,
                Paths = new List<Path>
                {
                    new ()
                    {
                        D = "M5 8h14M5 8a2 2 0 110-4h14a2 2 0 110 4M5 8v10a2 2 0 002 2h10a2 2 0 002-2V8m-9 4h4",
                        StrokeLineCap = "round",
                        StrokeLineJoin = "round",
                        StrokeWidth = 2
                    }
                },
                ViewBox = "0 0 24 24"
            },
            new()
            {
                Type = IconType.ArrowCircleDown,
                Paths = new List<Path>
                {
                    new()
                    {
                        D = "M15 13l-3 3m0 0l-3-3m3 3V8m0 13a9 9 0 110-18 9 9 0 010 18z",
                        StrokeLineCap = "round",
                        StrokeLineJoin = "round",
                        StrokeWidth = 2
                    }
                },
                ViewBox = "0 0 24 24"
            },
            new()
            {
                Type = IconType.ArrowCircleLeft,
                Paths = new List<Path>
                {
                    new()
                    {
                        D = "M11 15l-3-3m0 0l3-3m-3 3h8M3 12a9 9 0 1118 0 9 9 0 01-18 0z",
                        StrokeLineCap = "round",
                        StrokeLineJoin = "round",
                        StrokeWidth = 2
                    }
                },
                ViewBox = "0 0 24 24"
            },
            new()
            {
                Type = IconType.ArrowCircleRight,
                Paths = new List<Path>
                {
                    new()
                    {
                        D = "M13 9l3 3m0 0l-3 3m3-3H8m13 0a9 9 0 11-18 0 9 9 0 0118 0z",
                        StrokeLineCap = "round",
                        StrokeLineJoin = "round",
                        StrokeWidth = 2
                    }
                },
                ViewBox = "0 0 24 24"
            },
            new()
            {
                Type = IconType.ArrowCircleUp,
                Paths = new List<Path>
                {
                    new()
                    {
                        D = "M9 11l3-3m0 0l3 3m-3-3v8m0-13a9 9 0 110 18 9 9 0 010-18z",
                        StrokeLineCap = "round",
                        StrokeLineJoin = "round",
                        StrokeWidth = 2
                    }
                },
                ViewBox = "0 0 24 24"
            },
            new()
            {
                Type = IconType.ArrowDown,
                Paths = new List<Path>
                {
                    new()
                    {
                        D = "M19 14l-7 7m0 0l-7-7m7 7V3",
                        StrokeLineCap = "round",
                        StrokeLineJoin = "round",
                        StrokeWidth = 2
                    }
                },
                ViewBox = "0 0 24 24"
            },
            new()
            {
                Type = IconType.ArrowLeft,
                Paths = new List<Path>
                {
                    new()
                    {
                        D = "M10 19l-7-7m0 0l7-7m-7 7h18",
                        StrokeLineCap = "round",
                        StrokeLineJoin = "round",
                        StrokeWidth = 2
                    }
                },
                ViewBox = "0 0 24 24"
            },
            new()
            {
                Type = IconType.ArrowRight,
                Paths = new List<Path>
                {
                    new()
                    {
                        D = "M14 5l7 7m0 0l-7 7m7-7H3",
                        StrokeLineCap = "round",
                        StrokeLineJoin = "round",
                        StrokeWidth = 2
                    }
                },
                ViewBox = "0 0 24 24"
            },
            new()
            {
                Type = IconType.ArrowUp,
                Paths = new List<Path>
                {
                    new()
                    {
                        D = "M5 10l7-7m0 0l7 7m-7-7v18",
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