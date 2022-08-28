using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class PlayerColor : MonoBehaviour
{
    void Start()
    {
        if (PhotonNetwork.CountOfPlayersInRooms > 1)
            this.GetComponent<SpriteRenderer>().color = Color.black;
        else
            this.GetComponent<SpriteRenderer>().color = Color.white;
    }

}
