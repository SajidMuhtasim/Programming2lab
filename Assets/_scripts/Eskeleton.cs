using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eskeleton : EnemyMain 
{
  public Eskeleton() 
    {
      health = 100;
      damage = 10;
      speed = 5;
    }

  public override void Die() 
  {
    // Overriding die method for Eskeleton. For example, playing a specific death animation
    //GetComponent<Animator>().SetTrigger("Die");
  }

  protected override void Update()
  {
    base.Update();

    // Use the player's position to move the skeleton towards the player
    if (gameManager.playerPosition != null)
      {
        Vector3 direction = (gameManager.playerPosition.position - transform.position).normalized;
        transform.position += direction * speed * Time.deltaTime;
      }
  }
}



