using UnityEngine;
using System.Collections;

public class Mitrailllette : MonoBehaviour
{

    // Use this for initialization
    public float bulletLife = 10.0f;
    private GameObject player;
    PlayerHealth p;



    // Update is called once per frame
    void Update()
    {

        Destroy(gameObject, bulletLife);

    }

    void OnTriggerEnter(Collider col)
    {
        player = col.gameObject;

        p = col.gameObject.GetComponent<PlayerHealth>();
        p.TakeDamage(5);
        Destroy(gameObject, 0);
    }
}