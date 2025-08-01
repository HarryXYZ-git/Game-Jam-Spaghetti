using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoupColouriser : MonoBehaviour
{
    public Material soupMat;
    private float red, blue, green;
    private int theColourValue;
    // Start is called before the first frame update
    void Start()
    {
        theColourValue = Random.Range(1, 5);
        if(theColourValue == 1)
        {
            red = Random.Range(200, 255);
            blue = Random.Range(0, 127);
            green = Random.Range(0, 127);
            Debug.Log(1);
            soupMat.color = new Color(red, 0, 0);
        }
        if (theColourValue == 2)
        {
            green = Random.Range(200, 255);
            blue = Random.Range(0, 127);
            red = Random.Range(0, 127);
            Debug.Log(2);
            soupMat.color = new Color(0, green, 0);
        }
        if (theColourValue == 3)
        {
            red = Random.Range(0, 127);
            blue = Random.Range(200, 255);
            green = Random.Range(0, 127);
            Debug.Log(3);
            soupMat.color = new Color(0, 0, blue);
        }
        if (theColourValue == 4)
        {
            red = Random.Range(200, 255);
            green = Random.Range(127, 255);
            Debug.Log(4);
            soupMat.color = new Color(red, green, 0);
        }
        if (theColourValue == 5)
        {
            red = Random.Range(200, 255);
            blue = Random.Range(200, 255);
            Debug.Log(5);
            soupMat.color = new Color(red, 0, blue);
        }
        Debug.Log(red);
        Debug.Log(green);
        Debug.Log(blue);
    }

}
