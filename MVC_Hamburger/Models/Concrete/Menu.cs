﻿using MVC_Hamburger.Models.Abstract;
using MVC_Hamburger.Models.Enums;

namespace MVC_Hamburger.Models.Concrete
{
    public class Menu : Urun
    {


        public string ResimYolu { get; set; }    
        
        public ICollection<SiparisMenu>? SiparisMenuler { get; set; }
    }
}
