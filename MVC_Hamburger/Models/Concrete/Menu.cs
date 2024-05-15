﻿using MVC_Hamburger.Models.Abstract;
using MVC_Hamburger.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace MVC_Hamburger.Models.Concrete
{
    public class Menu : Urun
    {
        [Display(Name ="İçindekiler")]
        public string? Icerik { get; set; }
        public string? ResimYolu { get; set; }    
        
        public ICollection<SiparisMenu>? SiparisMenuler { get; set; }
    }
}
