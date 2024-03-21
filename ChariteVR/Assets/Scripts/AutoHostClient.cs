using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class AutoHostClient : MonoBehaviour
{

    [SerializeField]  NetworkManager networkManager;
    // Start is called before the first frame update
    void Start()
    {
        if(!Application.isBatchMode)
        {
            Debug.Log($" === Client Connected ===");
            networkManager.StartClient();
        } else
        {
            Debug.Log($"=== Server Starting ===");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void JoinLocal() {

        networkManager.networkAddress = "localhost";
        networkManager.StartClient();
    }
}