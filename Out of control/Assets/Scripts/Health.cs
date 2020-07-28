using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public float HP;
    public Slider HPBar;

    void Start()
    {
       HP = 50;
    }

    // Update is called once per frame
    void Update()
    {
        HPBar.value = HP;
        if (HP > 50)
        {
            HP = 50;
        }
        if (HP < 0)
        {
            HP = 0;
        }
        

    }
}
