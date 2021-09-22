using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using EFCOREPRACTICE.SamuraiApp.Domain;

namespace EFCOREPRACTICE.SamuraiApp.Data
{
    public class SamuraiContext:DbContext
    {
        private readonly string _connectionString;

        public SamuraiContext()
        {
            _connectionString = ConnectionStringReader.ConnectionString2;
            
        }
        public DbSet<Samurai>Samurais {get;set;}
        public DbSet<Quote>Quotes {get;set;}
        public DbSet<Clan> Clans {get;set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            //optionsBuilder.UseSqlServer(_connectionString);
            optionsBuilder.UseSqlite(_connectionString);
            base.OnConfiguring(optionsBuilder);
        }
        
    }
}