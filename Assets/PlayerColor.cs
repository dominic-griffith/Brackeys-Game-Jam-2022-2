using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;


public class PlayerColor : MonoBehaviour
{
    

    private void Start()
    {
        ChangeColor();
    }

    private void ChangeColor()
    {
        if (PhotonNetwork.IsMasterClient)
            GetComponent<SpriteRenderer>().color = Color.white;
        else
            GetComponent<SpriteRenderer>().color = Color.black;  
    }

}
