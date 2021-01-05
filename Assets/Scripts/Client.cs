using MLAPI;
using MLAPI.Messaging;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Client : NetworkedBehaviour
{
    public void StartClient()
    {
        NetworkingManager.Singleton.StartClient();
    }

    [ServerRPC(RequireOwnership = false)]
    void SayHelloToServer()
    {
    }

}
