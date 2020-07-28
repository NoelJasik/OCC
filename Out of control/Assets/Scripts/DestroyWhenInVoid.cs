using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyWhenInVoid : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag == "KillZone")
        {
            Destroy(gameObject, 0.5f);
        }
    }
}
