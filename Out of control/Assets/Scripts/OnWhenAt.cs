using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnWhenAt : MonoBehaviour
{
    [SerializeField]
    GameObject ThingToTurnOn;
    [SerializeField]
    bool HealthBased;
    [SerializeField]
    int WhenItTurns;
    Counter C;
    Health H;
        // Start is called before the first frame update
    void Start()
    {
        ThingToTurnOn.SetActive(false);
        C = FindObjectOfType<Counter>();
        H = FindObjectOfType<Health>();
    }

    // Update is called once per frame
    void Update()
    {
        if(!HealthBased)
        {
            if (C.KM >= WhenItTurns)
            {
                ThingToTurnOn.SetActive(true);
            }
            else
            {
                ThingToTurnOn.SetActive(false);
            }
        } else
        {
            if (H.HP <= WhenItTurns)
            {
                ThingToTurnOn.SetActive(true);
            }
            else
            {
                ThingToTurnOn.SetActive(false);
            }
        }
       
    }
}
