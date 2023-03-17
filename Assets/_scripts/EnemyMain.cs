using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMain : MonoBehaviour
{
  public int health;
  public int damage;
  public float speed;
  public float attackDelay = 2f;

  private bool _isAttacking = false;

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
    private IEnumerator Attack(playerController player)
    {
        _isAttacking = true;

        while (player != null && player.CurrentHealth > 0)
        {
          player.CurrentHealth -= damage;
          yield return new WaitForSeconds(attackDelay);
        }

        _isAttacking = false;
    }

    private void OnTriggerEnter(Collider other)
    {
      if (!_isAttacking && other.CompareTag("Player"))
      {
        playerController player = other.GetComponent<playerController>();
        if (player != null)
        {
          StartCoroutine(Attack(player));
        }
      }
    }
    
}

//include codes here as default for enemies