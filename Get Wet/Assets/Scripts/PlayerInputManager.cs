using UnityEngine;

public class PlayerInputManager : MonoBehaviour
{


    new NetworkView networkView;
    public PlayerMovement playerMovement;
    public PlayerShooting pshoot;

    void Start()
    {
        networkView = GetComponent<NetworkView>();
    }

    void Update()
    {
        float move_h = Input.GetAxis("Horizontal");
        float move_v = Input.GetAxis("Vertical");


   
        playerMovement.move(move_h, move_v);


        if (Input.GetButton("Fire1"))
        {
            pshoot.PrimaryWeapon();
        }
        if (Input.GetButton("Fire2"))
        {
            pshoot.SecondaryWeapon();
        }
     }
    }