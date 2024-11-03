using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : MonoBehaviour
{
    public BossMovement Script;
    public float BossPosition;
    public float LaunchPosition;
    public float LaunchXPosition = 10.5f;
    public float FlyTimer=0f;
    
    // Start is called before the first frame update
    void Start()
    {
        LaunchPosition = 0f;
        LaunchXPosition = 10.5f;
    }

    // Update is called once per frame
    void Update()
    {
        //public float missileYPosition = script.yPosition;
        BossPosition = Script.yPosition;
        //transform.position = new Vector3(5.31f, BossPosition, 0f);

        if (LaunchPosition == 0f)
        {
            transform.position = new Vector3(10.5f, BossPosition, 0f);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            LaunchPosition = Script.yPosition;
            Debug.Log(LaunchPosition);
        }

        if (LaunchPosition != 0f)
        {
            LaunchXPosition = LaunchXPosition - 0.1f;
            transform.position = new Vector3(LaunchXPosition, LaunchPosition, 0f);
            FlyTimer += Time.deltaTime;
        }

        if (FlyTimer > 1.5f)
        {
            FlyTimer = 0f;
            LaunchPosition = 0f;
            LaunchXPosition = 10.5f;
        }

    }
}
