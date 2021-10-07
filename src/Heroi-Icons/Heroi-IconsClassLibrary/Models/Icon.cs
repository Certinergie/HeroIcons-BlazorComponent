using System.Collections.Generic;

namespace Heroi_IconsClassLibrary.Models
{
    public class Icon
    {
        public IconType Type { get; set; }
        public IEnumerable<Path> Paths { get; set; }
        public string ViewBox { get; set; }
    }

    public class Path
    {
        public string D { get; set; }
        public string StrokeLineCap { get; set; }
        public string StrokeLineJoin { get; set; }
        public int StrokeWidth { get; set; } = 1;
    }

    public enum IconType
    {
        AcademicCap
    }
}