using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;


namespace Oleo.Models
{
    public class Blend 
    {  
        public int BlendId { get; set; }
        public string BlendNume { get; set; }
        public string Ulei1 { get; set; }
        public string Ulei2 { get; set; }
        public string Ulei3 { get; set; }
        public string Cant1 { get; set; }
        public string Cant2 { get; set; }
        public string Cant3 { get; set; }
        public string Utilizare { get; set; }

        public Blend(int blendId, string blendNume, string ulei1, string ulei2, string ulei3, string cant1, string cant2,string cant3, string utilizare)
        {
            BlendId = blendId;
            BlendNume = blendNume;
            Ulei1 = ulei1;
            Ulei2 = ulei2;
            Ulei3= ulei3;
            Cant1 = cant1;
            Cant2 = cant2;
            Cant3 = cant3;
            Utilizare = utilizare;
        }
        
        public Blend()
        {

        }
    }
}

