using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShadowCreator : MonoBehaviour
{

    public GameObject shadow;
    public float localYPosition;
    private GameObject shadowTemp;
    private float xlen;

    // Start is called before the first frame update
    void Start()
    {
        xlen = GetComponent<SpriteRenderer>().bounds.size.x;
        shadowTemp = Instantiate(shadow, new Vector3(0, 0, 0), Quaternion.identity);
        shadowTemp.transform.parent = gameObject.transform;
        shadowTemp.transform.localScale = new Vector3(xlen, 30, 1);
        shadowTemp.transform.localPosition = new Vector3(0, localYPosition, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
