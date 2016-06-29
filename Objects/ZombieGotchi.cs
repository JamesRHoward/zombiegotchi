using System.Collections.Generic;
using System.Threading;

namespace ZombieGotchi.Objects
{
  public class Zombie
  {
    private int _currentTurn = 0;

    private string _name;
    private string _gender;
    private string _formerOccupation;
    private int _lifeSpan;
    private int _happiness;
    private int _hunger;
    private bool _living;
    private string VALUETEST;

    private int _id;
    private static List<Zombie> _zombies = new List<Zombie> {};

    public Zombie (string name, string gender, string formerOccupation)
    {
      _name = name;
      _gender = gender;
      _formerOccupation = formerOccupation;
      _zombies.Add(this);
      _id = _zombies.Count;
      _lifeSpan = 0;
      _happiness = 100;
      _hunger = 100;
      _living = true;
      VALUETEST = "";
    }

    public string GetVALUETEST()
    {
      return VALUETEST;
    }

    public void SetVALUETEST(string value)
    {
      VALUETEST = value;
    }

    public bool IsLiving()
    {
      return _living;
    }

    public string GetName()
    {
      return _name;
    }

    public void SetName(string newName)
    {
      _name = newName;
    }
    public string GetGender()
    {
      return _gender;
    }

    public void SetGender(string newGender)
    {
      _gender = newGender;
    }
    public string GetFormerOccupation()
    {
      return _formerOccupation;
    }

    public void SetFormerOccupation(string newFormerOccupation)
    {
      _formerOccupation = newFormerOccupation;
    }
    public int GetLifeSpan()
    {
      return _lifeSpan;
    }

    public void SetLifeSpan(int newLifeSpan)
    {
      _lifeSpan = newLifeSpan;
    }

    public int GetHappy()
    {
      return _happiness;
    }
    public void SetHappy(int newLevelOfHappiness)
    {
      _happiness = newLevelOfHappiness;
    }

    public int GetHungerLevel()
    {
      return _hunger;
    }
    public void SetHungerLevel(int newHungerLevel)
    {
      _hunger = newHungerLevel;
    }

    public int GetId()
    {
      return _id;
    }

    public static List<Zombie> GetAll()
    {
      return _zombies;
    }

    public static Zombie Find(int searchId)
      {
        return _zombies[searchId-1];
      }




    public void DailyToll(Zombie sleepyZombie)
    {
      // Random rnd = new Random();
      // int levelOfHappinessLost = rnd.Next(1, 16);
      int previousHappiness = sleepyZombie.GetHappy();
      if (previousHappiness < 11) {
        previousHappiness = 11;
      }
      sleepyZombie.SetHappy(previousHappiness - 11);
      sleepyZombie.SetHungerLevel(sleepyZombie.GetHungerLevel() - 15);
      if (sleepyZombie.GetHungerLevel() <= 0)
      {
        _living = false;
      }
    }
    public void DailyActivities(Zombie daytimeZombie, string feedValue, string playValue, string romcomValue)
    {
      daytimeZombie.SetVALUETEST(feedValue);
      if (feedValue == "success" && daytimeZombie.IsLiving())
      {
        daytimeZombie.SetHungerLevel(daytimeZombie.GetHungerLevel()+16);
      }
      if (playValue == "success" && daytimeZombie.IsLiving())
      {
        daytimeZombie.SetHappy(daytimeZombie.GetHappy()+9);
      }
      if (romcomValue == "success" && daytimeZombie.IsLiving())
      {
        daytimeZombie.SetHappy(daytimeZombie.GetHappy()-13);
      }
    }
  }
}
