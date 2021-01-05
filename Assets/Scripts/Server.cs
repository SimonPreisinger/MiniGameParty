using MLAPI;
using MLAPI.Messaging;
using MLAPI.Spawning;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Server : NetworkedBehaviour
{
    [SerializeField]
    TextMeshProUGUI debugText;


    public void StartServer()
    {
        NetworkingManager.Singleton.StartServer();
    }


    public void printConnectedClients()
    {
        foreach(MLAPI.Connection.NetworkedClient client in NetworkingManager.Singleton.ConnectedClients.Values)
        {
            Debug.Log(client.ClientId);
            debugText.text += client.ClientId;
        }
        
    }

    
    public void InvokeClientRPCOnEveryone()
    {
        InvokeClientRpcOnEveryone(MyClientRPC);
        debugText.text = "InvokeClientRPCOnEveryone";
    }


    [ClientRPC]
    private void MyClientRPC()
    {
        GameObject go = Instantiate(NetworkingManager.Singleton.NetworkConfig.NetworkedPrefabs[1].Prefab, Vector3.zero, Quaternion.identity);
        go.GetComponent<NetworkedObject>().Spawn();
    } 


}
