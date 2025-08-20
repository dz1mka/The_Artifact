using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour

{

    [SerializeField]
    private Text timeText;

    public float timeToWin = 300f;

    private bool gameOver;

    private GameObject artifact;

    // Start is called before the first frame update
    void Awake()
    {
        artifact = GameObject.FindWithTag("Artifact");
    }

    // Update is called once per frame
    void Update()
    {
        if(gameOver || !artifact)
            return;

        timeToWin -= Time.deltaTime;

        if (timeToWin <= 0f)
        {
            gameOver = true;
            timeToWin = 0f;
            
            Destroy(artifact);
        }

       timeText.text = "Time remaining: " + (int)timeToWin;
    }
}
