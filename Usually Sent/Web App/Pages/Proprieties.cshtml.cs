using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ServiceReferenceImageManager;

namespace WebApp
{
    public class ProprietiesModel : PageModel
    {
        public interfaceClassesClient client = new interfaceClassesClient();

        public List<string> proprieties;
        public ProprietiesModel()
        {
            proprieties = new List<string>();
        }
        public async Task OnGetAsync()
        {
            proprieties = await client.GetDistinctProprietyNamesAsync();
            proprieties.Sort();
        }
    }
}