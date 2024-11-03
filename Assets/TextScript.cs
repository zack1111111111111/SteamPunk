using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextScript: MonoBehaviour
{
    public Collisions Script;
    // Start is called before the first frame update
    // timer variables
    public TextMesh timerText; // Reference to our Unity Text
    public float gameTimer = 30f; //30 seconds for game timer

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        gameTimer -= Time.deltaTime;

        if (gameTimer > 0f)
        {
            timerText.text = "Time Left: " + Mathf.Floor(gameTimer);
        }
        else
        {
            timerText.text = "Challenger Win!";
        }

        if (Script.Life == 0)
        {
            timerText.text = "Boss Win!";
        }

    }
}
