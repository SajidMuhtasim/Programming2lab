using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour 
{
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
}


//Player health code
//Item collection code
//Score code maybe
//UI code
//Level management code
