using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class PlayerColor : MonoBehaviour
{
    PhotonView view;

    private void Update()
    {
        view = GetComponent<PhotonView>();
        if(view.IsMine)
            view.RPC("ChangeColor", RpcTarget.AllBuffered, null);
    }

    [PunRPC]
    private void ChangeColor()
    {
        if (PhotonNetwork.IsMasterClient)
            this.GetComponent<SpriteRenderer>().color = Color.white;
        else
            this.GetComponent<SpriteRenderer>().color = Color.black;  
    }

}
