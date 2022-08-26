using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    private float xlen, xStartPos, yStartPos;
    public GameObject camera;
    public float xParallaxEffect, yParallaxEffect;

    void Start()
    {
        xStartPos = transform.position.x;
        xlen = GetComponent<SpriteRenderer>().bounds.size.x;
        yStartPos = transform.position.y;
    }

    void FixedUpdate()
    {
        // x-axis
        float xCameraTravel = (camera.transform.position.x * (1 - xParallaxEffect)); 
        float xDist = (camera.transform.position.x * xParallaxEffect);
        transform.position = new Vector3(xStartPos + xDist, transform.position.y, transform.position.z);
        if (xCameraTravel > xStartPos + xlen) {
            xStartPos += xlen;
        } else if (xCameraTravel < xStartPos - xlen) {
            xStartPos -= xlen;
        }

        // y-axis
        float yDelta = camera.transform.position.y - yStartPos;
        float yDist = (yDelta * yParallaxEffect);
        transform.position = new Vector3(transform.position.x, yStartPos + yDist, transform.position.z);
    }
}
