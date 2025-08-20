using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerBackpack : MonoBehaviour
{
    public int maxNumberOfFruitsToStore = 50; // Maximum number of items the backpack can hold
    public int currentNumberOfStoredFruits = 0; // Current number of items in the backpack

    [SerializeField]
    private Text backpackInfoTxt; // UI Text to display the number of stored fruits

    void Start()
    {
        // Initialize the backpack info text
        SetBackpackInfoText(0);
    }

    public void AddFruits(int amount)
    {
       currentNumberOfStoredFruits += amount;
       if (currentNumberOfStoredFruits > maxNumberOfFruitsToStore)
       {
           currentNumberOfStoredFruits = maxNumberOfFruitsToStore; // Cap the number of stored fruits
        }
        // Ensure the backpack does not exceed its maximum capacity
        SetBackpackInfoText(currentNumberOfStoredFruits); // Update the UI text
    }

    public int TakeFruits()
    {
        int takenFruits = currentNumberOfStoredFruits;
        currentNumberOfStoredFruits = 0; // Empty the backpack after taking fruits

        SetBackpackInfoText(currentNumberOfStoredFruits); // Update the UI text

        return takenFruits; // Return the number of fruits taken
    }

    void SetBackpackInfoText(int amount) 
    {
        backpackInfoTxt.text = "Backpack: " + amount + "/" + maxNumberOfFruitsToStore;
    }
}
