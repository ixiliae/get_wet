using UnityEngine;
using System.Collections;

public class PlayerShooting : MonoBehaviour
{
    public Rigidbody projectile;
    public float speed = 20;
    public float ammo = 100;
    public float speed2 = 20;
    public float ammo2 = 10;
    public Rigidbody projectile2;
    float time = -1;
    float time2 = -1;
    PlayerManager playermanager;
    public float cooldown = 0.2f;
    NetworkView net;
    Camera here;
    int nbupdate = 0;
    void Start()
    {
        here = GameObject.FindObjectOfType<Camera>();
        net = GetComponent<NetworkView>();
        nbupdate = net.GetInstanceID();
    }
    // Update is called once per frame
    void Update()
    {

        if (net.isMine)
        {
            Ray ray = here.ScreenPointToRay(new Vector3(Screen.height / 1.05f, Screen.width / 2.7f, 0));
            Vector3 hit = ray.GetPoint(100);
            hit = new Vector3(hit.x, hit.y, hit.z);
            AimAt(nbupdate, hit);
            if (net != null)
                net.RPC("AimAt", RPCMode.Others, nbupdate, hit);
        }


    }
    [RPC]
    void AimAt(int nbupdate2, Vector3 point)
    {
        //if (nbupdate == nbupdate2)
        transform.parent.parent.parent.parent.parent.LookAt(point);

    }
    [RPC]
    public void PrimaryWeapon()
    {

        if (time <= Time.timeSinceLevelLoad)
        {
            if (ammo > 0)
            {
                Rigidbody instantiatedProjectile = Instantiate(projectile, transform.position, transform.rotation) as Rigidbody;
                time = Time.timeSinceLevelLoad;
                time = time + cooldown;
                instantiatedProjectile.velocity = transform.TransformDirection(new Vector3(0, 0, speed));
                this.GetComponent<AudioSource>().Play();
                ammo = ammo - 1f;

                if (net != null)
                {
                    net.RPC("PrimaryWeapon", RPCMode.Others);
                }
            }
            //PlayerManager.Instance.AddAmmo(0, -1);
        }
        //PlayerManager.Instance.AddAmmo(0, -1);
    }
    [RPC]
    public void SecondaryWeapon()
    {
        if (time2 <= Time.timeSinceLevelLoad)
        {
            if (ammo2 > 0)
            {
                Rigidbody instantiatedProjectile2 = Instantiate(projectile2, transform.position, transform.rotation) as Rigidbody;
                time2 = Time.timeSinceLevelLoad;
                time2 = time2 + 0.2f;
                instantiatedProjectile2.velocity = transform.TransformDirection(new Vector3(0, 0, speed2));
                this.GetComponent<AudioSource>().Play();
                ammo2 = ammo2 - 1f;
                if (net != null)
                    net.RPC("SecondaryWeapon", RPCMode.Others);
                //PlayerManager.Instance.AddAmmo2(0, -1);
            }
        }
        //PlayerManager.Instance.AddAmmo2(0, -1);
    }
}

