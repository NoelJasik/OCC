using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ending : MonoBehaviour
{
    [SerializeField]
    GameObject player;
    Animator Anim;
    [SerializeField]
    Animator CanvasAnim;
    // Start is called before the first frame update
    void Start()
    {
        Anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            player.SetActive(false);
            Anim.SetTrigger("Start");
            CanvasAnim.SetTrigger("Start");
        }
    }
}
