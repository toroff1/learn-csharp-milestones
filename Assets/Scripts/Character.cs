using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour


{

    public string charName = "Tim";
    public int level = 0;


    public Character(string name, int level)
    {
        charName = name;
        this.level = level;

    }

    public void PrintStatsInfo()
    {
        Debug.LogFormat("{0}, Level {1}", charName, level);
    }



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

public struct Weapon
{
    
    
    
    public string weaponName;
    public int damage;

    public Weapon(string name, int damage)
    {
        weaponName = name;
        this.damage = damage;
    }
}

public class Paladin: Character
{
    Weapon weapon;

    public Paladin(string name, int level, Weapon weapon) : base(name, level)
    {
        charName = name;
        this.level = level;
        this.weapon = weapon;
    }
}
