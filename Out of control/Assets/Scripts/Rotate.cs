using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    Camera C;
    Rigidbody2D RB;
    // Start is called before the first frame update
    void Start()
    {
        C = FindObjectOfType<Camera>();
        RB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
        

                
        if (RB.rotation > 0 || RB.rotation < -180)
        {
            Debug.Log("Left");
            C.offset = -11.3f;
        }
        else
        {
            Debug.Log("Right");
            C.offset = 11.3f;
        }
       
    }
}
