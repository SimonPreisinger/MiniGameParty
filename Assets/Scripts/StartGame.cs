using MLAPI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : NetworkedBehaviour
{

    [SerializeField] GameObject server;
    [SerializeField] GameObject client;
    // Start is called before the first frame update
    void Start()
    {
        if(Application.platform == RuntimePlatform.WindowsPlayer)
        {
            Debug.Log("Windows platform => Start Server");
            NetworkingManager.Singleton.StartServer();
            return;
        }

        if(Application.platform == RuntimePlatform.Android)
        {
            Debug.Log("Android platform => Start Client");
            NetworkingManager.Singleton.StartClient();
        }
    }

}
