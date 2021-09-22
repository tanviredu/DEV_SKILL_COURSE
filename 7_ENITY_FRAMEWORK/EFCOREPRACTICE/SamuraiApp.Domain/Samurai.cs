using System;
using System.Collections.Generic;
namespace EFCOREPRACTICE.SamuraiApp.Domain
{
    public class Samurai
    {
        public int Id {get;set;}
        public string Name {get;set;}
        public List<Quote> Quotes{get;set;} = new List<Quote>();
        public Clan Clan {get;set;}
        public Horse Horse {get;set;}
        public List<SamuraiBattle> SamuraiBattles{get;set;} = new List<SamuraiBattle>();
        
    }
}