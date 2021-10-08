using System.Collections.Generic;

namespace HeroIcons.BlazorComponent.Models
{
    public class Icon
    {
        public IconType Type { get; set; }
        public IEnumerable<Path> Paths { get; set; }
        public string ViewBox { get; set; }
    }
}