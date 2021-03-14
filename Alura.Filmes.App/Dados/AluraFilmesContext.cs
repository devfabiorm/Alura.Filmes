﻿using Alura.Filmes.App.Negocio;
using Microsoft.EntityFrameworkCore;

namespace Alura.Filmes.App.Dados
{
    class AluraFilmesContext : DbContext
    {
        public DbSet<Ator> Atores { get; set; }
        public DbSet<Filme> Filmes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=AluraFilmes;Trusted_connection=true;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AtorConfiguration());
            modelBuilder.ApplyConfiguration(new FilmeConfiguration());
        }
    }
}
