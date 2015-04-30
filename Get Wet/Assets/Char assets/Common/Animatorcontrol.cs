using UnityEngine;
using System.Collections;

public class Animatorcontrol : MonoBehaviour {

	// Use this for initialization
    public GameObject player;
    public float turningSpeed = 0f;
	public PlayerHealth p;
	public bool isdead = false;
    


	void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
		p = gameObject.GetComponent<PlayerHealth>();
	}
	
	// Update is called once per frame
	void Update () {
		float horizontal = Input.GetAxis("Horizontal") * turningSpeed * Time.deltaTime;
		if (p.currentHealth <= 0) {
			GetComponent<Animation>().Play("tPose");
			if (!isdead)
			{
			   transform.Rotate(90,0,0);
				isdead = true;
			}


		}     
        else if ((Input.GetAxis("Horizontal") < 0) && (Input.GetButton("crouch")))
            GetComponent<Animation>().Play("crouchStrafeLeft");
         else if ((Input.GetAxis("Horizontal") > 0 ) && (Input.GetButton("crouch")))
            GetComponent<Animation>().Play("crouchStrafeRight");
        else if ((Input.GetAxis("Vertical") > 0 ) && (Input.GetButton("crouch")))
            GetComponent<Animation>().Play("crouchWalk");
        else if (Input.GetAxis("Vertical") > 0)
            GetComponent<Animation>().Play("run");
        else if (Input.GetAxis("Horizontal") > 0)
            GetComponent<Animation>().Play("strafeRight");
        else if (Input.GetAxis("Horizontal") < 0)
            GetComponent<Animation>().Play("strafeLeft");
        else if (Input.GetButton("Jump"))
            GetComponent<Animation>().Play("jump");
        else if (Input.GetButton("crouch"))
            GetComponent<Animation>().Play("crouch");
        else
            GetComponent<Animation>().Play("idle");
      
	
	}
}
