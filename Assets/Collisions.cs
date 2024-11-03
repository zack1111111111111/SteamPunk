using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collisions : MonoBehaviour
{
    public int Life=3;
    public TextMesh scoreText;
    // Start is called before the first frame update

    private void Update()
    {
        scoreText.text = "Life: " + Life;

    }
    private void OnTriggerEnter(Collider other)
    {
        if (Life > 0)
        {
            if (other.gameObject.tag == "hitter")
            {
                //print("Enter");
                UpdateScore();
            }
        }
        
        
    }

    void UpdateScore()
    {
        Life--;
    }
}
