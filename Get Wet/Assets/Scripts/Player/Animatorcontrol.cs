using UnityEngine;
using System.Collections;

public class Animatorcontrol : MonoBehaviour {

	// Use this for initialization
    public GameObject player;
    public float turningSpeed = 0f;
    


	void Start () {
        player = GameObject.FindGameObjectWithTag("Player");	
	}
	
	// Update is called once per frame
	void Update () {
        float horizontal = Input.GetAxis("Horizontal") * turningSpeed * Time.deltaTime;
        if ((Input.GetAxis("Horizontal") < 0) && (Input.GetButton("crouch")))
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
