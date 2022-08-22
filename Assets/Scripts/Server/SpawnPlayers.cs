using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class SpawnPlayers : MonoBehaviour
{
    public GameObject playerPrefab;
    public Vector2 spawnLocation = new Vector2(0, 5);

    private void Start()
    {
        PhotonNetwork.Instantiate(playerPrefab.name, spawnLocation, Quaternion.identity);
    }
}
