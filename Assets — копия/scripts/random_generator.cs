using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class random_generator : MonoBehaviour
{
    float x, y;
    float r = 4;
    Vector2 position;
    GameObject circle;
    public Text pi;
    public Text cases;

    float inSquare = 0;
    float inCircle = 0;
    public static float Pi_value;
    float allCases = 0;


    void Start()
    {
        r = 4;
        circle = Resources.Load("Circle", typeof(GameObject)) as GameObject;
        pi = GameObject.Find("PI").GetComponent<Text>();
        cases = GameObject.Find("allCases").GetComponent<Text>();
    }

   
    void Update()
    {
      
        x = Random.Range(-r, r);
        y = Random.Range(-r, r);
        position = new Vector3(x, y);
        float dist = Mathf.Sqrt(x * x + y * y );
        GameObject cloneCircle = Instantiate(circle, position, Quaternion.identity);
        if (dist >r)

        {
            inSquare++;
            


        }
        else
        {
            inCircle++;
            cloneCircle.GetComponent<Renderer>().material.color = Color.blue;

        }
       
        allCases = inSquare + inCircle;
        Pi_value = 4 * inCircle / (inSquare + inCircle);
        cases.text = "Cases = " + allCases;
        pi.text = "PI = " + Pi_value ;
        

        Debug.Log(allCases);
    }

   
}

//mecacnel chapery //
//guynery nuyny linum//
// sheghman ////
//caval
// align

