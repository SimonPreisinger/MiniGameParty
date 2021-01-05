using MLAPI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Host : NetworkedBehaviour
{

    public void StartHost()
    {
        NetworkingManager.Singleton.StartHost();
    }
}
