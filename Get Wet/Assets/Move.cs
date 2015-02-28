using UnityEngine;
using System.Collections;
public class Player : MonoBehaviour
{
    public float movementSpeed = 10f;
    public float sneakSpeed = 5f;
    public float turningSpeed = 200f;
    void Update()
    {
        Move();
    }
    void Move()
    {
        bool Sneak = Input.GetButton("Crouch");
        bool Sprint = Input.GetButton("Sprint");
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        transform.Rotate(0, horizontal * turningSpeed * Time.deltaTime, 0);
        if (Sneak)
            transform.Translate(0, 0, vertical * sneakSpeed * Time.deltaTime);
        else
            transform.Translate(0, 0, vertical * movementSpeed * Time.deltaTime);
    }
}