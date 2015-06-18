using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    const float sprintSpeed = 15f;
    const float sneakSpeed = 5f;
    const float rotationSpeed = 200f;
    public float speed = 6.0F;
    public float jumpSpeed = 16.0F;
    public float gravity = 20.0F;
    Animator animator;
    new NetworkView networkView;
    private Vector3 moveDirection = Vector3.zero;
    PlayerHealth p;
    void Start()
    {
        animator = GetComponent<Animator>();
        networkView = GetComponent<NetworkView>();

    }

    void Move(float v, float h, string anim_f)
    {
        

        if (networkView != null)
            networkView.RPC("PlayAnimation", RPCMode.Others);


            CharacterController controller = GetComponent<CharacterController>();

                moveDirection = new Vector3(v, 0, h);
                moveDirection = transform.TransformDirection(moveDirection);
                moveDirection *= speed;
                if (Input.GetButton("Jump"))
                    moveDirection.y = jumpSpeed;
           
            controller.Move(moveDirection * Time.deltaTime);
        }
    

    public void forward(float amount, float amount2)
    {
        this.transform.Translate(0, 0, amount * speed * Time.deltaTime);
            Move(amount, amount2, "run");

    }

}