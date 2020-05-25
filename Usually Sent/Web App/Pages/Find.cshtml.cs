using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ServiceReferenceImageManager;
using System.Web;
using WebApp.Pages;

namespace WebApp
{
    public class FindModel : PageModel
    {
        public interfaceClassesClient client = new interfaceClassesClient();
        public List<File> files { set; get; }
        public Dictionary<int, Dictionary<string, string>> fileProprieties;

        public List<byte[]> imagesBytes { set; get; }

        private Dictionary<string, string> searchParams;
        public FindModel()
        {
            files = new List<File>();
            fileProprieties = new Dictionary<int, Dictionary<string, string>>();
            searchParams = new Dictionary<string, string>();
            
        }
        public async Task OnGetAsync(string FileName,string Date,string Place,string Ocasion, string People, string Propriety)
        {
            if (FileName == null)
            {
                FileName = "";
            }
            if (Date == null)
            {
                Date = "";
            }
            else
            {
                Date = DateTime.Parse(Date).ToString("dd-MMM-yy");
            }
            if (Place == null)
            {
                Place = "";
            }
            if (Ocasion == null)
            {
                Ocasion = "";
            }
            if (People == null)
            {
                People = "";
            }
            if (Propriety != null)
            {
                searchParams.Add(Propriety, "");
            }
            searchParams.Add("FileName", FileName);
            searchParams.Add("DateCreated", Date);
            searchParams.Add("Place", Place);
            searchParams.Add("Ocasion", Ocasion);
            searchParams.Add("People", People); 
            Dictionary<string, string> da = new Dictionary<string, string>();
            var foundFiles = await client.SearchFilesAsync(searchParams);
            var allFiles = foundFiles.Item1.Concat(foundFiles.Item2);
            allFiles = allFiles.OrderBy( q => q.FileName).ToList();
            foreach (var item in allFiles)
            {
                files.Add(item);
                Dictionary<string,string> prop = await client.GetFileProprietiesAsync(item.FileId);
                prop.Remove("FileName");
                prop.Remove("DateCreated");
                prop.Remove("People");
                prop.Remove("Place");
                prop.Remove("Ocasion");
                fileProprieties.Add(item.FileId, prop);
            }

        }
         
    }
}