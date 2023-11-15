using GameIndustry.Services;
using Microsoft.AspNetCore.Components;

namespace GameIndustry.Pages
{
    public partial class Counter
    {

        [Inject] SingletonService singletonService { get; set; }
        [Inject] TransientService transientService { get; set; }
        private int currentCount = 0;

        private void IncrementCount()
        {
            currentCount++;

            singletonService.Value = currentCount;
            transientService.Value = currentCount;
        }
    }
}
