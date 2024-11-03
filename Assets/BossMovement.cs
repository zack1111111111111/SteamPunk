using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossMovement : MonoBehaviour
{
    public float speed = 1f;
    public float yPosition = 0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            if (yPosition <= 3)
            {
                yPosition += 0.01f;
            }
            else
            {
                yPosition = 3;
            }

            transform.position = new Vector3(9.84f, yPosition, 0f);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {

            if (yPosition >= 0 )
            {
                yPosition -= 0.01f;
            }
            else
            {
                yPosition = 0;
            }

            transform.position = new Vector3(9.84f, yPosition, 0f);
        }
    }
}
