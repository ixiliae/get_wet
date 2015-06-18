using UnityEngine;

public class NetworkManager : MonoBehaviour
{
    const string typeName = "Get Wet";
    const string gameName = "Get Wet room";

    public GameObject playerPrefab;
    public GameObject mainCam;
    void Awake()
    {
        MasterServer.ipAddress = "127.0.0.1";
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
        SpawnPlayer(-2, 0, 0);
    }

    void OnConnectedToServer()
    {
        SpawnPlayer(2, 0, 0);
    }

    void SpawnPlayer(float x, float y, float z)
    {
        GameObject player = Network.Instantiate(playerPrefab, new Vector3(x, y, z), Quaternion.identity, 0) as GameObject;
        player.AddComponent<PlayerInputManager>();
        player.AddComponent<PlayerNetworking>();

        
        WoWcamera cam =Instantiate<GameObject>(mainCam).GetComponent<WoWcamera>();
        
        cam.target = player.transform;
        cam.here = mainCam.GetComponent<Camera>();
        cam.weapon = player.transform.Find("Bip01/Bip01 Pelvis/Bip01 Spine/Bip01 Spine1/Bip01 Neck/Bip01 R Clavicle/Bip01 R UpperArm/Bip01 R Forearm/bazooka");
    }
}