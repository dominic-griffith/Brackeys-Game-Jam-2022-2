using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using TMPro;

public class ConnectToServer : MonoBehaviourPunCallbacks
{
    public TMP_InputField userName;
    public GameObject loading;

    public void OnClickConnect()
    {
        if(userName.text.Length >= 1)
        {
            PhotonNetwork.NickName = userName.text;
            loading.SetActive(true);
            Debug.Log("Connecting to server");
            PhotonNetwork.GameVersion = "0.0.1";
            PhotonNetwork.AutomaticallySyncScene = true;
            PhotonNetwork.ConnectUsingSettings();
        }
    }

    public override void OnConnectedToMaster()
    {
        Debug.Log("Connected to server");
        //PhotonNetwork.JoinLobby();
        SceneLoader.GetInstance().OfflineLoadSceneByName("Lobby");
    }

    //public override void OnJoinedLobby()
    //{
    //    SceneLoader.GetInstance().OfflineLoadSceneByName("Lobby");
    //}

    public override void OnDisconnected(DisconnectCause cause)
    {
        Debug.Log("Disconnect from server because: " + cause.ToString());   
    }
}
