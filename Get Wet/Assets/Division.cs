using UnityEngine;
using System.Collections;

public class Division : MonoBehaviour {
		public float bulletLife = 10.0f;
        public int mamamama = 2;
		public GameObject prefab;
		public float speed = 5f;
        public Rigidbody[] gos;
        float x = Random.Range(-50, 50);
        float y = Random.Range(-50, 50);
        public int i = 0;
        void Start()
        {
            gos = new Rigidbody[5];
            
            /*Debug.Log("sukmadick"); 
            Rigidbody instantiatedProjectile = Instantiate(prefab, transform.position, transform.rotation) as Rigidbody;
            
            Debug.Log("2");
            Rigidbody instantiatedProjectile2 = Instantiate(prefab, transform.localPosition + new Vector3(0,20,0), transform.rotation) as Rigidbody;
            Debug.Log("3");
            Rigidbody instantiatedProjectile3 = Instantiate(prefab, transform.localPosition + new Vector3(20, 0, 0), transform.rotation) as Rigidbody;
            Debug.Log("4");
            instantiatedProjectile.velocity = transform.TransformDirection(new Vector3(0, 0, 10));
            Debug.Log("5");
            instantiatedProjectile2.velocity = transform.TransformDirection(new Vector3(0, 10, 10));
            Debug.Log("6");
            instantiatedProjectile3.velocity = transform.TransformDirection(new Vector3(10, 0, 10));*/
        }
		void Update()
		{
            if (i < gos.Length)
            {
                Debug.Log("1");
                Rigidbody clone = Instantiate(prefab, transform.position, Quaternion.Euler(x, y, 0)) as Rigidbody;
                clone.AddForce(transform.forward * 10);
                gos[i] = clone;
                i++;
            
            }
		}
       
		void OnTriggerEnter(Collider col)
		{
            
                
            
			if (col.tag == "Player")
			{
				PlayerHealth p = col.GetComponent<PlayerHealth>();
				p.TakeDamage(20);
			}
			else
			{
				EnemyHealth e = col.GetComponent<EnemyHealth>();
				e.TakeDamage(20);
			}
			
			Destroy(gameObject, 0);
		}
	}

	