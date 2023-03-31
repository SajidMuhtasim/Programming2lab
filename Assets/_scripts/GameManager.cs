using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;


public class GameManager : MonoBehaviour 
{

  public static GameManager Instance {get; private set;}
  public Transform playerPosition;
  private playerController playerController; //Not sure if I will be needing this edit: I will
  Sprite foodSprite = Resources.Load<Sprite>("food");
  public GameObject playerObject;
  private GameData gameData;

  private int CH;

  List<EnemyMain> enemies = new List<EnemyMain> 
  {
    new Eskeleton() 
  };

  void Start() 
    {
      playerController = FindObjectOfType<playerController>();
      LoadGameData();
      CH = gameData.health;
    }
  

  void Update() 
  {
    if (Input.GetMouseButtonDown(0)) 
    {
      ShootBullet();
    }

    SaveGameData();

    CH = playerController.CurrentHealth;
    gameData.health = CH;
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

  private void SaveGameData() 
  {
    gameData.level = 1; //Placeholder level
    gameData.inventory = new int[] { 1, 2, 3 }; //3 items to pass level, number of items collected

    string json = gameData.ToEncryptedJson();
    string path = Path.Combine(Application.persistentDataPath, "GameData.dat");
    File.WriteAllText(path, json);
  }

  private void LoadGameData() 
  {
    string path = Path.Combine(Application.persistentDataPath, "GameData.dat");

    if (File.Exists(path)) 
    {
      string json = File.ReadAllText(path);
      gameData = GameData.FromEncryptedJson(json);
    } 
    else 
    {
      gameData = new GameData();
    }
  }
}




//Player health code
//Item collection code
//Score code maybe
//UI code
//Level management code
