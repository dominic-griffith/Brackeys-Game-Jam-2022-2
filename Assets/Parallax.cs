using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    private float length, startPosition;
    public GameObject camera;
    public float parallaxEffect;

    void Start()
    {
        startPosition = transform.position.x;
        length = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    void FixedUpdate()
    {
        float cameraTravel = (camera.transform.position.x * (1 - parallaxEffect)); 
        float dist = (camera.transform.position.x * parallaxEffect);
        transform.position = new Vector3(startPosition + dist, transform.position.y, transform.position.z);
        if (cameraTravel > startPosition + length) {
            startPosition += length;
        } else if (cameraTravel < startPosition - length) {
            startPosition -= length;
        }
    }
}
