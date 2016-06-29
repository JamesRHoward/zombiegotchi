using System.Collections.Generic;

namespace ZombieGotchi.Objects
{
  public class Zombie
  {
    private int _currentTurn = 0;
    private string _name;
    private string _gender;
    private string _previousOccupation;
    private int _currentTurnAge;

    private static List<Zombie> _zombies = new List<Zombie> {};

    public Zombie (string name, string gender, string previousOccupation)
    {
      _name = name;
      _gender = gender;
      _previousOccupation = previousOccupation;
      _zombies.Add(this);
      _currentTurnAge = 0;
      // _id = _instances.Count;

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
    public string GetPreviousOccupation()
    {
      return _previousOccupation;
    }

    public void SetPreviousOccupation(string newPreviousOccupation)
    {
      _previousOccupation = newPreviousOccupation;
    }
    public string GetLifeSpan()
    {
      return _LifeSpan;
    }

    public void SetLifeSpan(string newLifeSpan)
    {
      _LifeSpan = newLifeSpan;
    }

    public static List<Zombie> GetAll()
    {
      return _zombies;
    }

    public int GetCurrentTurn()
    {
      return _currentTurn;
    }

  }
}
