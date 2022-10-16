using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PiValue : MonoBehaviour
{   float pi= 3.141592f;
    Text piValue;
    Text newEarthRad;
    Text deviate;
    int radius = 6371;
    float deviation;
    // Start is called before the first frame update
    void Start()
    {
        piValue = GameObject.Find("piValue").GetComponent<Text>();
        newEarthRad = GameObject.Find("newEarthLen").GetComponent<Text>();
        deviate = GameObject.Find("deviation").GetComponent<Text>();
        piValue.text = "Pi = " + random_generator.Pi_value;
        newEarthRad.text = ( 2 * random_generator.Pi_value * 6371) + "km";
       // newEarthRad.text = (0.75f * random_generator.Pi_value * Mathf.Pow(radius, 3)) + "km^3";

        deviation = 100 - random_generator.Pi_value * 100 / pi;
        if (deviation < 0)
            {
            deviation = -deviation;
            }
        Debug.Log("sheghum"+deviation);
        deviate.text = "Deviation is " + deviation + "%";


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
