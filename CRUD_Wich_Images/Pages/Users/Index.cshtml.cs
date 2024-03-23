using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CRUD_Wich_Images.Data;
using CRUD_Wich_Images.Model;

namespace CRUD_Wich_Images.Pages.Users
{
    public class IndexModel : PageModel
    {
        private readonly CRUD_Wich_Images.Data.CRUD_Wich_ImagesContext _context;

        public IndexModel(CRUD_Wich_Images.Data.CRUD_Wich_ImagesContext context)
        {
            _context = context;
        }

        public IList<User> User { get;set; } = default!;

        public async Task OnGetAsync()
        {
            User = await _context.User.ToListAsync();
        }
    }
}
