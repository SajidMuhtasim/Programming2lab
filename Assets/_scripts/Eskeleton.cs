using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eskeleton : EnemyMain 
{
  public Eskeleton() 
    {
        health = 100;
        damage = 10;
    }

  public override void Die() 
  {
    // Overriding die method for Eskeleton. For example, playing a specific death animation
    //GetComponent<Animator>().SetTrigger("Die");
  }
}



