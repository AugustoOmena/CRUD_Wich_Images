using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CRUD_Wich_Images.Model;

namespace CRUD_Wich_Images.Data
{
    public class CRUD_Wich_ImagesContext : DbContext
    {
        public CRUD_Wich_ImagesContext (DbContextOptions<CRUD_Wich_ImagesContext> options)
            : base(options)
        {
        }

        public DbSet<CRUD_Wich_Images.Model.User> User { get; set; } = default!;
    }
}
