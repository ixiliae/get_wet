using UnityEngine;
using System.Collections;

public class turretShootbullet : MonoBehaviour
{
    public Rigidbody projectile;
    public float speed = 20;
    public GameObject projectile2;
    public GameObject player;
    public Transform leader;
    int i = 0;


    void Start()
    {
        
        player = GameObject.FindGameObjectWithTag("Player");

    }
    // Update is called once per frame
    void Update()
    {
        if (i % 5 == 0)
        {
            Rigidbody instantiatedProjectile = Instantiate(projectile, transform.position, transform.rotation) as Rigidbody;
            instantiatedProjectile.rotation = Quaternion.Euler(90, 0, 0);
            transform.Rotate(0, 150 * Time.deltaTime, 0);
            i++;
        }
        
    }
}