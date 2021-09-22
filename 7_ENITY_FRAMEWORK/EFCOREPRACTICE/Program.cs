using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
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
            //InsertBattle();
            //InsertNewSamuraiWithAQuote();
            //AddQuoteWithExistingSamurai();
            //fetch_data1();
            //fetch_data2();
            fetch_data_egar();

            //var quotes =_context.Quotes.ToList();
            //foreach(var s in quotes){
            //        Console.WriteLine(s.Text);
            // }
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

        public static void InsertNewSamuraiWithAQuote(){
            // working with the related data
            var samurai = new Samurai();
            samurai.Name = "Kambei Shimada";
            samurai.Quotes = new List<Quote>();
            samurai.Quotes.Add(new Quote{Text="I have Come To save you"});
            samurai.Quotes.Add(new Quote{Text="Never Gieve Up"});
            samurai.Quotes.Add(new Quote{Text="Trust and respect yourself"});
            _context.Samurais.Add(samurai);
            _context.SaveChanges();

        }

        public static void AddQuoteWithExistingSamurai(){
            var samurai = _context.Samurais.FirstOrDefault();
            samurai.Quotes = new List<Quote>();
            samurai.Quotes.Add(new Quote{Text="into the sky live or die"});
            samurai.Quotes.Add(new Quote{Text="Fight like there is no tommorow"});
            samurai.Quotes.Add(new Quote{Text="Fight with honor"});
            _context.SaveChanges();
            

        }

        public static void fetch_data1(){
            var samurai = _context.Samurais.FirstOrDefault();
            Console.WriteLine($"Samurai name {samurai.Name}");


        }

        public static void fetch_data_egar(){
            // lazy loading is turned of by default
            // so use include for join query
            var samu_with_quote = _context.Samurais.Include(s=>s.Quotes).ToList();
            foreach(var s in samu_with_quote){
                    Console.WriteLine($"Samurai Name : {s.Name}");
                    Console.WriteLine("-------------------------");
                    foreach(var c in s.Quotes){
                        Console.WriteLine($"Quotes : {c.Text}");
                    }
            }


        }





    }
}
