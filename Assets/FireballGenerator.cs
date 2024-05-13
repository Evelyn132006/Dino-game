using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballGenerator : MonoBehaviour
{
    public GameObject fireball;
    public float timeBTW;
    public bool canSpawn;
    public Transform pos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(canSpawn)
        {
            pos.position = new Vector3(-400, 30, Random.Range(100, 180));
            canSpawn = false;
            StartCoroutine(SpawnFireball());

        }
    }

    IEnumerator SpawnFireball()
    {
        Instantiate(fireball,pos.position,Quaternion.identity);
        yield return new WaitForSeconds(timeBTW);
        canSpawn = true;
    }
}
