using System.Collections.Generic;
using HeroIcons.BlazorComponent.Models;

namespace HeroIcons.BlazorComponent.Demo.Pages
{
    public partial class Index
    {
        public Dictionary<string, IconType> Icons { get; set; }

        protected override void OnInitialized()
        {
            Icons = new Dictionary<string, IconType>
            {
                { "academic-cap", IconType.AcademicCap },
                { "adjustments", IconType.Adjustments },
                { "annotation", IconType.Annotation },
                { "archive", IconType.Archive },
                { "arrow-circle-down", IconType.ArrowCircleDown },
            };
        }
    }
}