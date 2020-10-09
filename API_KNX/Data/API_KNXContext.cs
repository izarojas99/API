using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using API_KNX.Models;

namespace API_KNX.Data
{
    public class API_KNXContext : DbContext
    {
        public API_KNXContext (DbContextOptions<API_KNXContext> options)
            : base(options)
        {
        }

        public DbSet<API_KNX.Models.Album> Album { get; set; }

        public DbSet<API_KNX.Models.Artista> Artista { get; set; }
    }
}
