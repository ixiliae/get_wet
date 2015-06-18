using UnityEngine;

public class PlayerInputManager : MonoBehaviour
{


    new NetworkView networkView;
    public PlayerMovement playerMovement;

    void Start()
    {
        networkView = GetComponent<NetworkView>();
    }

    void Update()
    {
        float move_h = Input.GetAxis("Horizontal");
        float move_v = Input.GetAxis("Vertical");


        if (Input.GetButton("Vertical") || Input.GetButton("Horizontal"))
            playerMovement.forward(move_v, move_h);


        if (Input.GetButton("Fire1"))
        {
        }
     }
    }