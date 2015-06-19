using UnityEngine;
using System.Collections;

public class GetFlag : MonoBehaviour {

	// Use this for initialization
    private GameObject flagStealer;
    Vector3 flagPos;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        if (flagStealer != null)
        {
            flagPos = flagStealer.transform.position;
            flagPos.y += 5f;
            transform.position = flagPos;
        }
	
	}

    void OnTriggerEnter(Collider player)
    {
        
        if (player.transform.gameObject.tag == "Player")
             flagStealer = player.gameObject;
        if (player.transform.gameObject.tag == "Finish")
            Destroy(this.gameObject);

             
    
    
    }
}
