using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DIstanceBetween : MonoBehaviour
{
    [SerializeField]
    Transform PointA;
    [SerializeField]
    Transform PointB;
    Text T;
    // Start is called before the first frame update
    void Start()
    {
        T = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        float TDistance = PointA.position.x - PointB.position.x;
        int Distance = (int)TDistance / 10;
        T.text = Distance.ToString() + " KM";
    }
}
