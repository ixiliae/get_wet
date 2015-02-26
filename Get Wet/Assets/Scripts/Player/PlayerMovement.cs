using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float Speed = 6f;

    Vector3 movement;
    Animator anim;
    Rigidbody playerRigidbody;
    int floorMask;
    float camRaylength = 100f;
    public float rotateSpeed = 5;
    Vector3 offset;

    void Awake()
    {
        floorMask = LayerMask.GetMask("Floor");
        anim = GetComponent<Animator>();
        playerRigidbody = GetComponent<Rigidbody>();
    }
    void FixedUpdate()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        Move(h, v);
    }
    void Move(float h, float v)
    {
       
        float x = rotateSpeed * Input.GetAxis ("Mouse X");
        // Rotation around the Euler angles
        float pitch = -Input.GetAxis("Mouse Y") * rotateSpeed * Time.deltaTime;
        float yaw = Input.GetAxis("Horizontal") * rotateSpeed * Time.deltaTime;
        float roll = -Input.GetAxis("Mouse X") * rotateSpeed * Time.deltaTime;
        Vector3 rotation = new Vector3(pitch, yaw, roll);
        rotation = Vector3.Lerp(Vector3.zero, rotation, Time.deltaTime * rotateSpeed); // Smooth...
        // PHYSICS - nah
        //Vector3 rotation = new Vector3(roll, yaw, pitch); // rigidbody rotation wants the angles in a different order...?
        //transform.rigidbody.AddTorque(rotation);
        transform.Rotate(rotation);
        movement.Set(h, 0f, v);
        movement = movement.normalized * Speed * Time.deltaTime;
        playerRigidbody.MovePosition(transform.position + movement);
    }


}