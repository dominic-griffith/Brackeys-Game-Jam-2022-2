using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class PlayerColor : MonoBehaviour
{
    private void Update()
    {
        if (PhotonNetwork.IsMasterClient)
            this.GetComponent<SpriteRenderer>().color = Color.white;
        else
            this.GetComponent<SpriteRenderer>().color = Color.black;
    }

}
