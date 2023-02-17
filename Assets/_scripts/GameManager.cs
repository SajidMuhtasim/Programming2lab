using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour 
{

  public static GameManager Instance {get; private set;}
  public Transform playerPosition;


  List<EnemyMain> enemies = new List<EnemyMain> 
  {
    new Eskeleton()
    
  };

  void Update() 
  {
    if (Input.GetMouseButtonDown(0)) 
    {
      ShootBullet();
    }
  }

  void ShootBullet() 
  {
    //Code to shoot bullet
  }

  private void Awake()
  {
    if (Instance == null)
    {
      Instance = this;
    }
    else
    {
      Destroy(gameObject);
    }
  }
}



//Player health code
//Item collection code
//Score code maybe
//UI code
//Level management code
