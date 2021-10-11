using System.Collections.Generic;
using HeroIcons.BlazorComponent.Demo.Services;
using HeroIcons.BlazorComponent.Models;
using Microsoft.AspNetCore.Components;

namespace HeroIcons.BlazorComponent.Demo.Pages
{
    public partial class Index
    {
        [Inject]
        public ClipboardService ClipboardService { get; set; }
        
        public Dictionary<string, IconType> Icons { get; set; }
        
        private void Callback(IconType iconType)
        {
            ClipboardService.WriteTextAsync($"<IconComponent IconType=\"IconType.{iconType}\"/>");
        }
        

        protected override void OnInitialized()
        {
            Icons = new Dictionary<string, IconType>
            {
                { "academic-cap", IconType.AcademicCap },
                { "adjustments", IconType.Adjustments },
                { "annotation", IconType.Annotation },
                { "archive", IconType.Archive },
                { "arrow-circle-down", IconType.ArrowCircleDown },
                { "arrow-circle-left", IconType.ArrowCircleLeft },
                { "arrow-circle-right", IconType.ArrowCircleRight },
                { "arrow-circle-up", IconType.ArrowCircleUp },
                { "arrow-down", IconType.ArrowDown },
                { "arrow-left", IconType.ArrowLeft },
                { "arrow-right", IconType.ArrowRight },
                { "arrow-up", IconType.ArrowUp },
            };
        }
    }
}