using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMain : MonoBehaviour
{
  public int health;
  public int damage;
  public float speed;
  protected GameManager gameManager;

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

  

    protected virtual void Start()
    {
      gameManager = GameManager.Instance;
    }

    protected virtual void Update()
    {
      // Get player position from GameManager and do a default action. Skeleton moves towards the player and attacks 
    }
}

//include codes here as default for enemies