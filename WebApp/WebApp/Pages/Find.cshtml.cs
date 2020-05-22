using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ServiceReferenceImageManager;

namespace WebApp
{
    public class FindModel : PageModel
    {
        public interfaceClassesClient client = new interfaceClassesClient();
        public List<File> files { set; get; }
        public List<byte[]> imagesBytes { set; get; }

        public FindModel()
        {
            files = new List<File>();
        }
        public async Task OnGetAsync()
        {
            Dictionary<string, string> da = new Dictionary<string, string>();
            var images = await client.SearchFilesAsync(da);
            foreach (var item in images.Item1)
            {
                files.Add(item);
                
          
                
            }
        }
    }
}