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
    public class DetailsModel : PageModel
    {
        private readonly CRUD_Wich_Images.Data.CRUD_Wich_ImagesContext _context;

        public DetailsModel(CRUD_Wich_Images.Data.CRUD_Wich_ImagesContext context)
        {
            _context = context;
        }

        public User User { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.User.FirstOrDefaultAsync(m => m.ID == id);
            if (user == null)
            {
                return NotFound();
            }
            else
            {
                User = user;
            }
            return Page();
        }
    }
}
