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
			animation.Play("tPose");
			if (!isdead)
			{
			   transform.Rotate(90,0,0);
				isdead = true;
			}


		}     
        else if ((Input.GetAxis("Horizontal") < 0) && (Input.GetButton("crouch")))
            animation.Play("crouchStrafeLeft");
         else if ((Input.GetAxis("Horizontal") > 0 ) && (Input.GetButton("crouch")))
            animation.Play("crouchStrafeRight");
        else if ((Input.GetAxis("Vertical") > 0 ) && (Input.GetButton("crouch")))
            animation.Play("crouchWalk");
        else if (Input.GetAxis("Vertical") > 0)
            animation.Play("run");
        else if (Input.GetAxis("Horizontal") > 0)
            animation.Play("strafeRight");
        else if (Input.GetAxis("Horizontal") < 0)
            animation.Play("strafeLeft");
        else if (Input.GetButton("Jump"))
            animation.Play("jump");
        else if (Input.GetButton("crouch"))
            animation.Play("crouch");
        else
            animation.Play("idle");
      
	
	}
}
