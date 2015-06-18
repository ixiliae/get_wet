using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 6.0F;
    public float jumpSpeed = 16.0F;
    public float gravity = 20.0F;
    private Vector3 moveDirection = Vector3.zero;
    PlayerHealth p;

    void Start()
    {
        p = gameObject.GetComponent<PlayerHealth>();
    }
    void Update()
    {
        
    }

    public void move(float h, float v)
    {
        if (p.currentHealth > 0)
        {
            CharacterController controller = GetComponent<CharacterController>();
            if (controller.isGrounded)
            {
                moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
                moveDirection = transform.TransformDirection(moveDirection);
                moveDirection *= speed;
                if (Input.GetButton("Jump"))
                    moveDirection.y = jumpSpeed;

            }
            moveDirection.y -= gravity * Time.deltaTime;
            controller.Move(moveDirection * Time.deltaTime);
        }
    }
}
