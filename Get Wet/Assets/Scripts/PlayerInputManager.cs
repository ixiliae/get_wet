using UnityEngine;

public class PlayerInputManager : MonoBehaviour
{


    new NetworkView networkView;
    PlayerMovement playerMovement;
    PlayerShooting pshoot;
    PlayerHealth hp;
    Transform player;
    GameObject cam;
    void Start()
    {
        networkView = GetComponent<NetworkView>();
        pshoot = GetComponentInChildren<PlayerShooting>();
        playerMovement = GetComponent<PlayerMovement>();
        GameObject cam = GameObject.Find("Main Camera 1(Clone)");
        Transform player = cam.GetComponent<WoWcamera>().target;
        hp = player.gameObject.GetComponent<PlayerHealth>();
        
    }

    void Update()
    {
        
        float move_h = Input.GetAxis("Horizontal");
        float move_v = Input.GetAxis("Vertical");
        float jump = Input.GetAxis("Jump");


        
        playerMovement.move(move_h, move_v, jump);

        if (hp.currentHealth > 0)
        {
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
    }