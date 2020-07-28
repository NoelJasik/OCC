using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
    public int KM;
    [SerializeField]
    Text T;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        KM = (int)transform.position.x / 10;
        T.text = KM.ToString() + " KM";
    }
}
