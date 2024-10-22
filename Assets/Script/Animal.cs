using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Animal : MonoBehaviour
{
    [SerializeField] protected Animal attackingAnimal;

    protected string animalName;
    protected int damage;

    private int health; // value: 0-100
    public int Health
    {
        get { return health; }
        set { health = Mathf.Clamp(value ,0,100); }
        /*set { if (value < 0) health = 0;
        else if (value > 100) health = 100;
        else health = value; }*/

    }

    //Abstract Method
    public abstract void MakeSound();

    public abstract int GetRandomDamage();

    //Virtual Method
    public virtual void Attack()
    {
        Debug.Log("Animal is performing basic attack.");
    }

    //Non-Abstract Method
    public void InitializeAnimal(int newHealth, string newName = "Animal")
    {
        animalName = newName;
        Health = newHealth;
        damage = GetRandomDamage();
        DisplayAnimalStatus();
    }
    public void TakeDamage(Animal atkAnimal)
    {
        /*if (atkAnimal == null) //Check have Animal ???
        {
            Debug.LogWarning($"{animalName} was attackc by a null reference!");
            return;
        }*/

        Debug.Log($">>> {atkAnimal.animalName} attack!!!");
        Health -= atkAnimal.damage;
        Debug.Log($"{animalName} took {atkAnimal.damage} damage. Remaining {Health}");

        if (Isdead()) { Debug.Log($"{animalName} is dead!"); }
    }

    public void DisplayAnimalStatus()
    {
        Debug.Log($"{name} Name: {animalName}, Health: {Health}, Damage: {damage}");
    }

    public bool Isdead()
    {
        return Health <= 0;
    }

}
