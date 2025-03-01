﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Prueba.Models;

namespace Prueba.Data
{
    public class PruebaContext : DbContext
    {
        public PruebaContext (DbContextOptions<PruebaContext> options)
            : base(options)
        {
        }

        public DbSet<Prueba.Models.Estudiante> Estudiante { get; set; } = default!;
        public DbSet<Prueba.Models.Carrera> Carrera { get; set; } = default!;
    }
}
