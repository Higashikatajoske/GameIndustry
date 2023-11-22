using GameIndustry.Models;
using GameIndustry.Services;
using Microsoft.AspNetCore.Components;
using static GameIndustry.Shared.MainLayout;

namespace GameIndustry.Pages
{
    public partial class Counter
    {

        [Inject] SingletonService singletonService { get; set; }
        [Inject] TransientService transientService { get; set; }

        //[CascadingParameter(Name = "Color")] 
        //public string? Color { get; set; }

        //[CascadingParameter(Name = "Size")]
        //public string? Size { get; set; }

        [CascadingParameter]
        public AppStyle Styles { get; set; }

        private int currentCount = 0;

        private void IncrementCount()
        {
            currentCount++;

            singletonService.Value = currentCount;
            transientService.Value = currentCount;
        }
    }
}
