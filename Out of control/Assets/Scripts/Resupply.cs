using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resupply : MonoBehaviour
{
    [SerializeField]
    bool ResupplyHealth;
    [SerializeField]
    bool ResupplyFuel;
    [SerializeField]
    float AmountToAdd;
    [SerializeField]
    GameObject PE;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            Instantiate(PE, transform.position, transform.rotation);
            if(ResupplyHealth)
            {
                FindObjectOfType<Health>().HP += AmountToAdd;
            }
            if (ResupplyFuel)
            {
                FindObjectOfType<FuelManager>().Fuel += AmountToAdd;
            }
            Destroy(gameObject);
        }
    }
}
