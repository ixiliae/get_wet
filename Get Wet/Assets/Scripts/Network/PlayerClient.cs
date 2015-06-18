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
    void UseActive()
    {
        shoot.PrimaryWeapon();
    }
    [RPC]
    void UseActive2()
    {
        shoot.SecondaryWeapon();
    }
    [RPC]
    void Die()
    {
        hp.Death();
    }

}