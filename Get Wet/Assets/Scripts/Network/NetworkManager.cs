using UnityEngine;

public class NetworkManager : MonoBehaviour
{
    const string typeName = "Get Wet";
    const string gameName = "Get Wet room";

    public GameObject playerPrefab;
    public GameObject mainCam;
    
    public GameObject WhiteBa = GameObject.Find("whiteBazooka");
    public GameObject BlackBa = GameObject.Find("blackBazooka");
    public GameObject WhiteGr = GameObject.Find("whiteGrenade");
    public GameObject BlackGr = GameObject.Find("blackGrenade");
    public GameObject WhiteShot = GameObject.Find("whiteShotgun");
    public GameObject BlackShot = GameObject.Find("blackShotgun");
    public GameObject AmyCac = GameObject.Find("MagicAmyCac");
    public GameObject AmySniper = GameObject.Find("MagicAmySniper");
    public int SavedChar = 1;
    public int SavedSpawn = 0;
    public int SavedWeapon = 1;
    GameObject player;

    void Awake()
    {
        MasterServer.ipAddress = "127.0.0.1";
       // SavedChar = PlayerPrefs.GetInt("SelectedCharacter");
       // SavedSpawn = PlayerPrefs.GetInt("SelectedSpawn");
       // SavedWeapon = PlayerPrefs.GetInt("SelectedWeapon");
    }

    void Start()
    {
        NetworkConnectionError err = Network.InitializeServer(4, 25000, !Network.HavePublicAddress());

        if (err == NetworkConnectionError.NoError)
            MasterServer.RegisterHost(typeName, gameName);
        else
            MasterServer.RequestHostList(typeName);
    }

    void OnMasterServerEvent(MasterServerEvent msEvent)
    {
        if (msEvent == MasterServerEvent.HostListReceived)
        {
            HostData[] hostList = MasterServer.PollHostList();
            if (hostList.Length != 0)
                Network.Connect(hostList[0]);
            else
                MasterServer.RequestHostList(typeName);
        }
    }

    void OnServerInitialized()
    {
        SpawnPlayer(500, 27, 560);
    }

    void OnConnectedToServer()
    {
        SpawnPlayer(490,27, 550);
    }

    void SpawnPlayer(float x, float y, float z)
    {
        //GameObject player = Network.Instantiate(playerPrefab, new Vector3(x, y, z), Quaternion.identity, 0) as GameObject;
        #region spawning
        if (SavedChar == 1)
        {
            if (SavedWeapon <= 1)
            {
                player = Network.Instantiate(WhiteBa, new Vector3(x, y, z), Quaternion.identity, 0) as GameObject;
            }

            if (SavedWeapon == 2)
            {
               player = Network.Instantiate(WhiteGr, new Vector3(x, y, z), Quaternion.identity, 0) as GameObject;
            }

            if (SavedWeapon == 3)
            {
                 player = Network.Instantiate(WhiteShot, new Vector3(x, y, z), Quaternion.identity, 0) as GameObject;
            }
        }
        if (SavedChar == 2)
        {
            if (SavedWeapon == 1)
            {
                 player = Network.Instantiate(BlackBa, new Vector3(x, y, z), Quaternion.identity, 0) as GameObject;
            }

            if (SavedWeapon == 2)
            {
                player = Network.Instantiate(BlackGr, new Vector3(x, y, z), Quaternion.identity, 0) as GameObject;
            }

            if (SavedWeapon == 3)
            {
                 player = Network.Instantiate(BlackShot, new Vector3(x, y, z), Quaternion.identity, 0) as GameObject;
            }
        }

        if (SavedChar == 3)
        {
            if (SavedWeapon <= 1)
            {
                player = Network.Instantiate(AmyCac, new Vector3(x, y, z), Quaternion.identity, 0) as GameObject;
            }

            if (SavedWeapon == 2)
            {
                 player = Network.Instantiate(AmySniper, new Vector3(x, y, z), Quaternion.identity, 0) as GameObject;
            }
        }
        

        #endregion

        player.AddComponent<PlayerInputManager>();
        player.AddComponent<PlayerNetworking>();

        
        WoWcamera cam =Instantiate<GameObject>(mainCam).GetComponent<WoWcamera>();
        cam.target = player.transform;
        cam.here = mainCam.GetComponent<Camera>();
        cam.weapon = player.transform.Find("Bip01/Bip01 Pelvis/Bip01 Spine/Bip01 Spine1/Bip01 Neck/Bip01 R Clavicle/Bip01 R UpperArm/Bip01 R Forearm/bazooka");
    }
}