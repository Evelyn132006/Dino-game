using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballScript : MonoBehaviour
{
    public float speed;
    public float maxX;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + new Vector3(speed, 0, 0);
        if(transform.position.x>maxX)
        {
            Destroy(gameObject);
        }
    }
}