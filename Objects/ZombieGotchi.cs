using System.Collections.Generic;

namespace ZombieGotchi.Objects
{
  public class Zombie
  {
    private int _currentTurn = 0;
    private string _name;
    private string _gender;
    private string _formerOccupation;
    private int _lifeSpan;

    private static List<Zombie> _zombies = new List<Zombie> {};

    public Zombie (string name, string gender, string formerOccupation)
    {
      _name = name;
      _gender = gender;
      _formerOccupation = formerOccupation;
      _zombies.Add(this);
      _lifeSpan = 0;
      this.GetCurrentTurn();

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

    public static List<Zombie> GetAll()
    {
      return _zombies;
    }

    public int GetCurrentTurn()
    {
      return _currentTurn;
    }

    public void PassTurn()
    {
      // _currentTurn ++;
      foreach (var zombie in _zombies)
      {
        zombie.SetLifeSpan(zombie.GetLifeSpan() + 1);
      }
    }

  }
}
