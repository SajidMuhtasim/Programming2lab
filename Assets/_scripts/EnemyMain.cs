using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMain
{
    public int health;
    public int damage;

  public virtual void TakeDamage(int damage) 
    {
        health -= damage;

        if(health <= 0) 
        {
            Die();
        }
    } 

  public virtual void Die() 
  {
    // Remove the enemy from the game after a certain amount of time
    //Destroy(gameObject, 3f);

  }

}

//include codes here as default for enemies