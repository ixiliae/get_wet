using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour
{
    public float turnSmoothing = 15f;   // A smoothing value for turning the player.
    public int speed = 6;  



    void Awake()
    {

    }


    void FixedUpdate()
    {
        // Cache the inputs.
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");


        MovementManagement(h, v);
    }


    void Update()
    {
        // Cache the attention attracting input.
    }


    void MovementManagement(float horizontal, float vertical)
    {
        Vector3 targetDirection = new Vector3(horizontal, 0f, vertical);
        
    }




}