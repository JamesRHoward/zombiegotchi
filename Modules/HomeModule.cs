using Nancy;
using ZombieGotchi.Objects;
using System.Collections.Generic;

namespace ZombieGotchi
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        List<Zombie> allZombies = Zombie.GetAll();
        return View["index.cshtml", allZombies];
      };
      Get["/zombieForm"] = _ => {
        return View["newZombie.cshtml"];
      };
      Post["/zombie/birth"] = _ => {
        Zombie newZombie = new Zombie(Request.Form["name"],Request.Form["gender"],Request.Form["formerOccupation"]);
        List<Zombie> allZombies = Zombie.GetAll();
        return View["index.cshtml", allZombies];
      };
      Post["/dayOver"] = _ => {
        List<Zombie> allZombies = Zombie.GetAll();
        foreach (var zombie in allZombies)
        {
          if (zombie.IsLiving()) {
            zombie.SetLifeSpan(zombie.GetLifeSpan()+1);
            zombie.DailyToll(zombie);
            string id = zombie.GetId().ToString();
            zombie.DailyActivities(zombie,Request.Form[id+"feed"],Request.Form[id+"play"],Request.Form[id+"romcom"]);
          }
        }
        return View["index.cshtml", allZombies];
      };
    }
  }
}
