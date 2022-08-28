using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class SpawnPlayers : MonoBehaviour
{
    public GameObject playerPrefab;
    public GameObject playerPrefab1;
    public GameObject playerCamera;
    public Vector2 spawnLocation = new Vector2(0, 5);
    public Vector3 cameraSpawnLocation = new Vector3(0, 5, -10);

    private void Start()
    {
        if (PhotonNetwork.IsMasterClient)
            PhotonNetwork.Instantiate(playerPrefab.name, spawnLocation, Quaternion.identity);
        else
            PhotonNetwork.Instantiate(playerPrefab1.name, spawnLocation, Quaternion.identity);
        PhotonNetwork.Instantiate(playerCamera.name, cameraSpawnLocation, Quaternion.identity);
    }
}
