using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GeoController : MonoBehaviour
{
    // string 
    // int, float
    string hello = "hello";

    int numOne = 5;
    int numTwo = 6;

    float numThree = 7.5f;

    // Start is called before the first frame update
    void Start()
    {
        //NumOne = numOne + numTwo;
        // numOne += numTwo;
        // numOne = 5 + 6
        // numOne++;
        // numOne + 1
    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log(hello);
        // numOne++;
        //Debug.Log(numOne);

        transform.position += new Vector3(0.005f, 0, 0);

        if (Input.GetKeyDown(KeyCode.W))
        {
            transform.position += new Vector3(0, 1, 0);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.position += new Vector3(1, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            transform.position += new Vector3(0, -1, 0);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.position += new Vector3(-1, 0, 0);
           
        }
    }  


}
