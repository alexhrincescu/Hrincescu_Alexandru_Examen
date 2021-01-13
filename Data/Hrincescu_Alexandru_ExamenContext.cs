using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Hrincescu_Alexandru_Examen.Models;

namespace Hrincescu_Alexandru_Examen.Data
{
    public class Hrincescu_Alexandru_ExamenContext : DbContext
    {
        public Hrincescu_Alexandru_ExamenContext (DbContextOptions<Hrincescu_Alexandru_ExamenContext> options)
            : base(options)
        {
        }

        public DbSet<Hrincescu_Alexandru_Examen.Models.JocuriVideo> JocuriVideo { get; set; }
    }
}
