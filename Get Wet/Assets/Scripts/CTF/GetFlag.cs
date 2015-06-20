using UnityEngine;
using System.Collections;

public class GetFlag : MonoBehaviour {

	// Use this for initialization
    private GameObject flagStealer;
    Vector3 flagPos;
    public int flag=0;
    public int MyRedScore = 0;
    public int MyBlueScore = 0;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        if (flagStealer != null)
        {
            transform.rotation = flagStealer.transform.rotation;
            
            flagPos = flagStealer.transform.position;
            flagPos.y += 5f;
            transform.position = flagPos;
        }
	
	}

    void OnTriggerEnter(Collider player)
    {

        if (player.transform.gameObject.tag == "Player")
        {
            flagStealer = player.gameObject;
            flag = 1;
            PlayerPrefs.SetInt("Flag", (flag));

        }
        if (player.transform.gameObject.tag == "BlueBase")
        {
            MyBlueScore = MyBlueScore + 1;
            PlayerPrefs.SetInt("MyBlueScore", (MyBlueScore));
            Debug.Log(PlayerPrefs.GetInt("Flag"));
            GameObject cube = GameObject.FindGameObjectWithTag("NetworkManager");
            NetworkManager n = cube.GetComponent<NetworkManager>();
            n.SpawnFlag();
            flag = 0;
            PlayerPrefs.SetInt("Flag", (flag));
            Debug.Log(PlayerPrefs.GetInt("Flag"));
            Network.Destroy(this.gameObject);
            Destroy(this.gameObject);
            //PLACE INSTRUCTION HERE
        }
        if (player.transform.gameObject.tag == "RedBase")
        {
            MyRedScore = MyRedScore + 1;
            PlayerPrefs.SetInt("MyRedScore", (MyRedScore));
            
            GameObject cube = GameObject.FindGameObjectWithTag("NetworkManager");
            NetworkManager n = cube.GetComponent<NetworkManager>();
            n.SpawnFlag();
            flag = 0;
            PlayerPrefs.SetInt("Flag", (flag));
            Debug.Log(PlayerPrefs.GetInt("Flag"));
            Network.Destroy(this.gameObject);
            Destroy(this.gameObject);

            //PLACE INSTRUCTION HERE
        }

             
    
    
    }
}
