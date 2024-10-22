using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : Animal
{
    private void Awake()
    {
        InitializeAnimal(100, "Dog");
    }

    private void Start()
    {
        MakeSound();
        Attack();
        TakeDamage(attackingAnimal);
    }

    public override void MakeSound()
    {
        Debug.Log($"=== {animalName} says Woof Woof!");
    }

    public override int GetRandomDamage()
    {
        return Random.Range(1, 50) + 5;
    }

    public override void Attack()
    {
        base.Attack();
        Debug.Log($"*** {animalName} is bite!");
    }
}
