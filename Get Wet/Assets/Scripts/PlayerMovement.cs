using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 6.0F;
    public float jumpSpeed = 16.0F;
    public float gravity = 20.0F;
    private Vector3 moveDirection = Vector3.zero;
    PlayerHealth p;
    string anim;
    NetworkView net;
    void Start()
    {
        p = gameObject.GetComponent<PlayerHealth>();
        net = GetComponent<NetworkView>();
    }
    void Update()
    {
        
    }

    public void move(float h, float v, float jump)
    {
        if (p.currentHealth > 0)
        {
            CharacterController controller = GetComponent<CharacterController>();
            if (controller.isGrounded)
            {
                moveDirection = new Vector3(h, 0, v);
                moveDirection = transform.TransformDirection(moveDirection);
                moveDirection *= speed;
                if (jump >0)
                    moveDirection.y = jumpSpeed;
                
            }
            if (v > 0)
                anim = "run";
            else if (h > 0)
                anim = "strafeRight";
            else if (h < 0)
                anim = "strafeLeft";
            else if (jump > 0)
                anim = "jump";
            else
                anim = "idle";

            GetComponent<Animation>().Play(anim);
           if (net != null)
                net.RPC("PlayAnimation", RPCMode.Others, anim);
            moveDirection.y -= gravity * Time.deltaTime;
            controller.Move(moveDirection * Time.deltaTime);
        }
    }
}
