using UnityEngine;
using System.Collections;


public class Camera : MonoBehaviour
{
    public GameObject player;
    public float offset;
    private Vector3 playerPosition;
    public float offsetSmoothing;
    Rotate R;
    Vector3 PreviouseOffset;
    [SerializeField]
    Animator Anim;
    // Use this for initialization
    void Start()
    {
        
        R = FindObjectOfType<Rotate>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            Shake();
        }
        playerPosition = new Vector3(player.transform.position.x, transform.position.y, transform.position.z);
        playerPosition = new Vector3(playerPosition.x + offset, playerPosition.y, playerPosition.z);
        transform.position = Vector3.Lerp(transform.position, playerPosition, offsetSmoothing);
    }

    public void Shake()
    {
        Anim.SetTrigger("Shake" + Random.Range(1, 3).ToString());
    }
  

}