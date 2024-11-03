using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System.IO.Ports;

public class PeopleMovement : MonoBehaviour
{
    public SerialPort serial = new SerialPort("\\\\.\\COM9", 9600);
    private string ArduinoString;
    public float ArduinoFloat;
    public float scaleDistance = 1;
    private bool serialState;
    // Start is called before the first frame update
    void Start()
    {
        serial.Open();
        //Debug.Log("VLX Active");
        serialState = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (serialState == true)
        {
            ArduinoString = serial.ReadLine();
            float.TryParse(ArduinoString, out ArduinoFloat);
            transform.position = new Vector3(transform.position.x, 0.255f + (ArduinoFloat), transform.position.z);
            //Debug.Log("Distance is"+ArduinoFloat);
        }
    }
}
