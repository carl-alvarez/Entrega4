using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestruirAmmo : MonoBehaviour
{
    public float destroTimer = 4f;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, destroTimer);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
