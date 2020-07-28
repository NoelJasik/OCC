using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    [SerializeField]
    bool GoesUpAndDown;
    [SerializeField]
    bool IsPlayerBased;
    [SerializeField]
    float ChangeTime;
    float ActualTime;
    [SerializeField]
    float MoveSpeedX;
    [SerializeField]
    float MoveSpeedY;
    Rigidbody2D RB;
    [SerializeField]
    Rigidbody2D PRB;
    float ActualX;
    // Start is called before the first frame update
    void Start()
    {
        RB = GetComponent<Rigidbody2D>();
        ActualTime = ChangeTime;
        ActualX = MoveSpeedX;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(GoesUpAndDown)
        {
            if(IsPlayerBased)
            {
                if(MoveSpeedX < PRB.velocity.x)
                {
                    ActualX = PRB.velocity.x;
                } else
                {
                    ActualX = MoveSpeedX;
                }

            }
            ActualTime -= Time.deltaTime;
            if(ActualTime <= 0)
            {
                MoveSpeedY *= -1;
                ActualTime = ChangeTime;
            }
        }
           
        RB.velocity = new Vector2(ActualX, MoveSpeedY);
    }
}
