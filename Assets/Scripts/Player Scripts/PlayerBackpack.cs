using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBackpack : MonoBehaviour
{
    public int maxNumberOfFruitsToStore = 50; // Maximum number of items the backpack can hold
    public int currentNumberOfStoredFruits = 0; // Current number of items in the backpack

    public void AddFruits(int amount)
    {
       currentNumberOfStoredFruits += amount;
       if (currentNumberOfStoredFruits > maxNumberOfFruitsToStore)
       {
           currentNumberOfStoredFruits = maxNumberOfFruitsToStore; // Cap the number of stored fruits
        }
    }

    public int TakeFruits()
    {
        int takenFruits = currentNumberOfStoredFruits;
        currentNumberOfStoredFruits = 0; // Empty the backpack after taking fruits
        return takenFruits; // Return the number of fruits taken
    }
}
