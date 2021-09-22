using System;
using System.Collections.Generic;
namespace EFCOREPRACTICE.SamuraiApp.Domain
{
    public class Samurai
    {
        public int Id {get;set;}
        public string Name {get;set;}
        public List<Quote> Quotes = new List<Quote>();
        public Clan Clan {get;set;}
        
    }
}