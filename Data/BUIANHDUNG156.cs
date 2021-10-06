using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BuiAnhDung156.Models;

    public class BUIANHDUNG156 : DbContext
    {
        public BUIANHDUNG156 (DbContextOptions<BUIANHDUNG156> options)
            : base(options)
        {
        }

        public DbSet<BuiAnhDung156.Models.PersonBAD156> PersonBAD156 { get; set; }
    }
