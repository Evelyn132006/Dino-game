using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float speed;
    public float minZ;
    public float maxZ;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.A))
        {
            if(transform.position.z>=minZ)
            {
                transform.position = transform.position + new Vector3(0, 0, -speed);
            }
            
        }
        if (Input.GetKey(KeyCode.D))
        {

            if (transform.position.z <= maxZ)
            {
                transform.position = transform.position + new Vector3(0, 0, speed);
            }
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag=="fireball")
        {
            Debug.Log("a murit");
            SceneManager.LoadScene("Deatscreen");
        }
    }
}
