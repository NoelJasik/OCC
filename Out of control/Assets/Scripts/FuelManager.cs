using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FuelManager : MonoBehaviour
{
    public float Fuel;
    [SerializeField]
    Slider FuelBar;

    // Start is called before the first frame update
    void Start()
    {
        Fuel = 100;  
    }

    // Update is called once per frame
    void Update()
    {
        if(Fuel > 100)
        {
            Fuel = 100;
        } if (Fuel < 0)
        {
            Fuel = 0;
        }
        FuelBar.value = Fuel;

    }
}
