using EFCore.DAL.DataAccess;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Linq;

namespace EFCore.Web.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly PeopleContext _db;

        public IndexModel(ILogger<IndexModel> logger,PeopleContext db)
        {
            _logger = logger;
            _db = db;

        }

        

        public void OnGet()
        {
            // LoadSampleData(); json dosyasından database'e kayıt atma

            var people = _db.People.Include(x => x.Addresses).Include(x => x.EmailAdresses)
                //.ToList()
                //.Where(x => ApprovedAge(x.Age));   bu satırları açıp alttaki iki satırı kapa farka bak
                .Where(x => x.Age>=18 && x.Age<=65)
                .ToList();
        }

        private bool ApprovedAge(int age)
        {
            return (age >= 18 && age <= 65);
        }

        //  Json dosyasından database'e kayıt atma
        //private void LoadSampleData()
        //{
        //    if (_db.People.Count() == 0)
        //    {
        //        string file = System.IO.File.ReadAllText("db.json");
        //        var people = JsonSerializer.Deserialize<List<Person>>(file);
        //        _db.AddRange(people);
        //        _db.SaveChanges();
        //    }
        //}
    }
}
