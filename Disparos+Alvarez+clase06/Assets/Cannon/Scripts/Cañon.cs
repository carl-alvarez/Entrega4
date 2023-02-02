using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cañon : MonoBehaviour
{
    public GameObject AmmoInstiate;
    

    public Transform spawnPoint;

    public float instaTimer = 3f;

    public float instaResetTimer = 3f;

    public void Start()
    {


    }
    private void Update()
    {
        
     TimedShot();
        

    }

    private void TimedShot()
    {
        instaTimer -= Time.deltaTime;
        if (instaTimer <= 0)
        {
            Instantiate(AmmoInstiate, spawnPoint.position, transform.rotation);
            Debug.Log("Disparo realizado");

            instaTimer = instaResetTimer;
        }
    }

   

}
