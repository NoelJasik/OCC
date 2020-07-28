using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField]
    float MaxVelocity;
    [SerializeField]
    float AccelerationSpeed;
    [SerializeField]
    float BurstSpeed;
    [SerializeField]
    float BPS;
    [SerializeField]
    GameObject Burst;
    [SerializeField]
    Transform BurstSpawner;
    bool IsSpawned;
    FuelManager FM;
    Health HP;
    [SerializeField]
    bool CanBeHit;
    float IH;
    [SerializeField]
    GameObject PE;
    [SerializeField]
    GameObject DeathScreen;
    [SerializeField]
    AudioSource DamageSound;
    Camera C;

    // Start is called before the first frame update
    void Start()
    {

        C = FindObjectOfType<Camera>();
        HP = GetComponent<Health>();
        FM = GetComponent<FuelManager>();
        BurstSpeed = BPS;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame

    void Update()
    {
        if (rb.velocity.x > 10)
        {
            CanBeHit = true;
        } else
        if (rb.velocity.x < -10)
        {
            CanBeHit = true;
        } else
        {
            CanBeHit = false;
                }
        
        IH = Input.GetAxis("Horizontal") * -3;
       
        
        BurstSpeed -= Time.deltaTime;
     
        if(HP.HP == 0)
        {
            HP.HPBar.value = 0;
            Instantiate(PE, transform.position, transform.rotation);
            DeathScreen.SetActive(true);
            gameObject.SetActive(false);
        }

           
        if(rb.velocity.x > MaxVelocity)
        {
            rb.velocity = new Vector2(MaxVelocity, rb.velocity.y);
        }
        if (rb.velocity.x < MaxVelocity * -1)
        {
            rb.velocity = new Vector2(MaxVelocity * -1, rb.velocity.y);
        }
       
    }
    private void FixedUpdate()
    {
        if (FM.Fuel > 0 && IH != 0f)
        {
            transform.Rotate(0, 0, IH);
        }
        else if (IH != 0f)
        {
            transform.Rotate(0, 0, IH / 3);
        }
        if (IH != 0 && FM.Fuel > 0)
        {
            FM.Fuel -= 0.02f;
        }
        if (BurstSpeed < 0 && FM.Fuel != 0)
        {

            if (!IsSpawned)
            {
                Instantiate(Burst, BurstSpawner);
                IsSpawned = true;
            }
            FM.Fuel -= 0.2f;
            rb.AddForce(transform.up * AccelerationSpeed);
            if (BurstSpeed < -0.5)
            {
                Stop();
            }

        }
        else if (BurstSpeed < 0 && FM.Fuel <= 0)
        {
            HP.HP -= 0.2f;
            if(!IsSpawned)
            {
                DamageSound.Play();
                IsSpawned = false;
            }
                if (BurstSpeed < -0.5)
            {
                Stop();
            }
        }
    }

    void Stop()
    {
        BurstSpeed = BPS;
        IsSpawned = false;
    }
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.collider.tag == "Asteroid")
        {
          if(CanBeHit)
            {
                C.Shake();
                DamageSound.Play();
                HP.HP -= 5;
            }
           
        }
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if(other.tag == "KillZone")
        {
            C.Shake();
            DamageSound.Play();
            HP.HP -= 1;
        }
    }
   
}
