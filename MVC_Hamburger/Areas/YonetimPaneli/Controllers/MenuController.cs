﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVC_Hamburger.Areas.YonetimPaneli.Models.ViewModels;
using MVC_Hamburger.DAL;
using MVC_Hamburger.Models.Concrete;
using System;
using System.Drawing;

namespace MVC_Hamburger.Areas.YonetimPaneli.Controllers
{
    [Authorize(Roles = "Yonetici")]
    [Area("YonetimPaneli")]
    public class MenuController : Controller
    {
        private readonly HamburgerDbContext _context;

        public MenuController(HamburgerDbContext context)
        {
            _context = context;
        }


        // GET: MenuController
        public IActionResult Index()
        {
            var menuler = _context.Menuler.ToList();             
            return View(menuler);
        }

        // GET: MenuController/Details/5
        public IActionResult Details(int id)
        {
            Menu menu = _context.Menuler.FirstOrDefault(x=>x.ID==id);
            return View(menu);
        }

        // GET: MenuController/Create
        public IActionResult Create()
        {
            MenuVM menuVM = new MenuVM();   
            return View(menuVM);
        }

        // POST: MenuController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(MenuVM menuVM)
        {
            var menuEkleVM = menuVM.MenuEkle;
            if(ModelState.IsValid)
            {
                Menu menu = new Menu();
                menu.Ad = menuEkleVM.MenuAdi;
                menu.Fiyat= menuEkleVM.MenuFiyat;

                Guid guid = Guid.NewGuid();
                string dosyaAdi = guid.ToString();
                dosyaAdi += menuEkleVM.MenuResim.FileName;
                string dosyaYolu = "wwwroot/MenuResimleri/";
                menu.ResimYolu = dosyaAdi;

                FileStream fs = new FileStream(dosyaYolu + dosyaAdi, FileMode.Create);
                menuEkleVM.MenuResim.CopyTo(fs);
                fs.Close();

                _context.Menuler.Add(menu); 
                _context.SaveChanges(); 
                return RedirectToAction("Index");   

            }
            return View();  

        }

        // GET: MenuController/Edit/5
        public IActionResult Edit(int id)
        {   
            Menu menu = _context.Menuler.FirstOrDefault(x => x.ID == id);
            
            //menuVM.ResimYolu = menuVM.Menu.ResimYolu;


            return View(menu);
        }

        //POST: MenuController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int? id, Menu menu)
        {
            
            if (ModelState.IsValid)
            {
                Menu updMenu = _context.Menuler.FirstOrDefault(x => x.ID == id);
                updMenu.Ad = menu.Ad;
                updMenu.Fiyat = menu.Fiyat;
                _context.Menuler.Update(updMenu);
                _context.SaveChanges();
                return RedirectToAction("Index");

            }
            return View();
        }

        //GET: MenuController/Delete/5
        public IActionResult Delete(int id)
        {
            return View();
        }

        //POST: MenuController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
