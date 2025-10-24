using Fantasy.Frontend.Repositories;
using Fantasy.Shared.Entites;
using Microsoft.AspNetCore.Components;

namespace Fantasy.Fronted.Pages.Countries
{
    public partial class CountriesIndex
    {
        [Inject] private IRepository Repository { get; set; } = null!;
        private List<Country>? Countries { get; set; }
    }
}