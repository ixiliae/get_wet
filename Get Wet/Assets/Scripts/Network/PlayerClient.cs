using UnityEngine;
using System.Collections;

public class PlayerClient : MonoBehaviour
{
    PlayerShooting shoot;
    PlayerHealth hp;
    void Start()
    {
        shoot = GetComponent<PlayerShooting>();
        hp = GetComponent<PlayerHealth>();
    }

    [RPC]
    void PlayAnimation(string anim)
    {

             GetComponent<Animation>().Play(anim);
    }

    [RPC]
    void Shoot()
    {
        shoot.PrimaryWeapon();
        Debug.Log("shot received");
    }
    [RPC]
    void Shoot2()
    {
        shoot.SecondaryWeapon();
    }


}