using CombatApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CombatApp.Controllers
{
    public class HomeController : Controller
    {

        [HttpGet]
        public IActionResult Index()
        {
            var Protag = new Character();
            Protag.HP = 15;
            Protag.SkillPoints = 10;
            ViewBag.Win = true;
            return View(Protag);

            
        }
        [HttpPost]
        public IActionResult Index(Character Protag)
        {

            Protag.SkillPoints += 1;
            Protag.Level += 1;

            var Enemy = new Character();


            Enemy.HP = 99;
            Enemy.Attack = 99;
            Enemy.Defense = 99;

            if (Protag.Combat(Enemy) == 0)
            {
                ViewBag.Win = true;
            }else
            {
                ViewBag.Win = false;
            }
            return View(Protag);
        }

    }
}
