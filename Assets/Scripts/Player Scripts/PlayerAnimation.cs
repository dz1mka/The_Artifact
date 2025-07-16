using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    [SerializeField] private Sprite[] animSprites;

    public float timeThreshold = 0.1f;

    private float timer;
    private int state = 0;

    private SpriteRenderer sr;

    private void Awake()
    {
        sr = GetComponent<SpriteRenderer>();
       
    }

    private void Update()
    {
        if(Time.time > timer)
        {
            //sr.sprite = animSprites[state % animSprites.Length];
            //state++;

            sr.sprite = animSprites[state];
            state++;

            if (state == animSprites.Length)
            {
                state = 0; // Reset the state to 0 if it exceeds the number of sprites
            }

            // If the state exceeds the number of sprites, reset it to 0
            // Reset the timer to the current time plus the threshold
            timer = Time.time + timeThreshold;
        }
    }
}
