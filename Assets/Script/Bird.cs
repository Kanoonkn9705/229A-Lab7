using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : Animal
{
    private void Awake()
    {
        InitializeAnimal(100, "Angry Bird");
    }
    private void Start()
    {
        MakeSound();
        Attack();
        TakeDamage(attackingAnimal);
    }

    public override void MakeSound()
    {
        Debug.Log($"=== {animalName} screams SCREEEE!");
    }

    public override int GetRandomDamage()
    {
        return Random.Range(10, 50) * 2;
    }

    public override void Attack()
    {
        base.Attack();
        Debug.Log($"*** {animalName} is pecking!");
    }
}
