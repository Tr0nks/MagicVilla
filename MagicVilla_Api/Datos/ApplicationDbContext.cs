using MagicVilla_Api.Modelos;
using Microsoft.EntityFrameworkCore;

namespace MagicVilla_Api.Datos
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Villa> Villas { get; set; }
    }
}
