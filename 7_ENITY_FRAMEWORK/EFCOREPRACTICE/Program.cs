using System;
using System.Collections.Generic;
using System.Linq;
using EFCOREPRACTICE.SamuraiApp.Domain;
using EFCOREPRACTICE.SamuraiApp.Data;
namespace EFCOREPRACTICE
{
    class Program
    {
        private static SamuraiContext _context = new SamuraiContext();
        static void Main(string[] args)
        {
            
            //InsertMultipleSamurai();
            //InsertVarious();
            //getAllSamurai();
            //QueryFilters();
            //UpdateQuery();
            //DeleteQuery();
            InsertBattle();
        }

        public static void InsertMultipleSamurai(){
            var samurai1 = new Samurai{Name="Sampson"};
            var samurai2 = new Samurai{Name="Tasa"};
            _context.Samurais.AddRange(samurai1,samurai2);
            _context.SaveChanges();
        }

        public static void InsertVarious(){
            var samurai = new Samurai{Name="hasnat"};
            var clan = new Clan{ClanName="Imperial Clan"};
            _context.AddRange(samurai,clan);
            _context.SaveChanges();
        }
        
        public static void getAllSamurai(){
            var samurais = _context.Samurais.ToList();
            Console.WriteLine($"Samurai Count is {samurais.Count}");

        }

        public static void QueryFilters(){
            
            var samurai = _context.Samurais.Where(x=>x.Name=="Sampson").FirstOrDefault();
            Console.WriteLine($"Samurai Name {samurai.Name}");

        }

        public static void UpdateQuery(){
            var samurai = _context.Samurais.Where(x=>x.Name=="Sampson").FirstOrDefault();
            samurai.Name = "Samson Doggy";
            _context.SaveChanges();

        }

        public static void DeleteQuery(){
            var samurai  = _context.Samurais.Where(s=>s.Id==1).FirstOrDefault();
            Console.WriteLine($"Name : {samurai.Name}");
            _context.Samurais.Remove(samurai);
            _context.SaveChanges();


        }

        public static void InsertBattle(){
            var battle = new Battle();
            battle.Name = "world war 2";
            battle.StartDate = new DateTime(2010,12,23);
            battle.EndDate = new DateTime(2012,12,23);
            _context.Battles.Add(battle);
            _context.SaveChanges();

        }

    }
}
