using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class SpawnPlayers : MonoBehaviour
{
    public GameObject playerPrefab;
    public GameObject playerCamera;
    public Vector2 spawnLocation = new Vector2(0, 5);
    public Vector3 cameraSpawnLocation = new Vector3(0, 5, -10);

    private void Start()
    {
        PhotonNetwork.Instantiate(playerPrefab.name, spawnLocation, Quaternion.identity);
        PhotonNetwork.Instantiate(playerCamera.name, cameraSpawnLocation, Quaternion.identity);
    }
}
