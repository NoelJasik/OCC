using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetTrueOnStart : MonoBehaviour
{
    [SerializeField]
    GameObject ThingToSet;
    // Start is called before the first frame update
    void Awake()
    {
        ThingToSet.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
