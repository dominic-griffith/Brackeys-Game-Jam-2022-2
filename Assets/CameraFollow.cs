using UnityEngine;
using Photon.Pun;

public class CameraFollow : MonoBehaviour
{
    private GameObject[] playerObjs;
    private GameObject[] playerObjs1;
    private Transform player;

    public float smoothSpeed = 0.125f;
    public Vector3 offset;

    private bool playerFound = false;

    private void Start()
    {
        playerObjs = GameObject.FindGameObjectsWithTag("white");
        playerObjs1 = GameObject.FindGameObjectsWithTag("black");
        foreach (GameObject playerObj in playerObjs)
        {

            if (playerObj.GetComponent<PhotonView>().IsMine)
            {
                player = playerObj.transform;
                playerFound = true;
            }
        }
        foreach (GameObject playerObj in playerObjs1)
        {

            if (playerObj.GetComponent<PhotonView>().IsMine)
            {
                player = playerObj.transform;
                playerFound = true;
            }
        }

    }

    private void FixedUpdate()
    {
        if (playerFound)
        {
            Vector3 desiredPos = player.position + offset;
            Vector3 smoothedPos = Vector3.Lerp(transform.position, desiredPos, smoothSpeed);
            transform.position = smoothedPos;

            //transform.LookAt(player);
        }
            
    }
}