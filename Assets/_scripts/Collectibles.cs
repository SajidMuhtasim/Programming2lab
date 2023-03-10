using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum CollectibleType
{
    Food,
    Treasure
    // Maybe more collectibles will be added in the future
}

public class Collectibles : MonoBehaviour
{
    public CollectibleType type;
    public int value;
    public Sprite sprite;

    public void Collect()
    {
        switch (type)
        {
            case CollectibleType.Food:
                InteractWithFood();
                break;
            case CollectibleType.Treasure:
                InteractWithTreasure();
                break;
            // add more cases for other collectible types here in the future if needed
        }
    }

    private void InteractWithFood()
    {
        playerController player = FindObjectOfType<playerController>();
        if (player == null)
        {
            Debug.LogError("No player found in the scene.");
            return;
        }

        if (player.CurrentHealth == player.MaxHealth)
        {
            Debug.Log("You are already at full health.");
        }
        else
        {
            player.CurrentHealth += value;
            if (player.CurrentHealth > player.MaxHealth)
            {
                player.CurrentHealth = player.MaxHealth;
            }
            Debug.Log("You collected food and restored " + value + " health points.");
        }

        Destroy(gameObject);
    }

    private void InteractWithTreasure()
    {
        // code for what happens when player collects treasure
        Destroy(gameObject);
    }

    void OnTriggerEnter(Collider other)
{
    if (other.gameObject.CompareTag("Player"))
    {
        Debug.Log("Player collided with food!");
        InteractWithFood();
    }
}

}