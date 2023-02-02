using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoBehavior : MonoBehaviour
{
    public float speed;
    public Vector3 direction;
    public float damage;
    public float sizeChanger;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("El disparo har� " + damage + " de da�o");
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate( direction * speed * Time.deltaTime);

        if (Input.GetKey(KeyCode.Space))
        {
            transform.localScale = transform.localScale * sizeChanger;
        }

    }
}
