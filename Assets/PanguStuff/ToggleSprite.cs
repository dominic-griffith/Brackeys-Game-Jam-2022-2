using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleSprite : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Sprite onSprite, offSprite;
    public bool initialOn;
    public GameObject togglePrefab;
    private GameObject prefabTemp;
    
    void Start() {
        spriteRenderer.sprite = initialOn ? onSprite : offSprite;
        if (initialOn) {
            prefabTemp = Instantiate(togglePrefab, new Vector3(0, 0, 0), Quaternion.identity);
            prefabTemp.transform.parent = gameObject.transform;
            prefabTemp.transform.localPosition = new Vector3(0, 2, 0);
        }
    }

    void OnMouseDown() {
        PhotonView photonView = PhotonView.Get(this);
        photonView.RPC("HandleMouseDown", RpcTarget.All);
    }

    [PunRPC]
    void HandleMouseDown() {
        if (spriteRenderer.sprite == onSprite) {
            spriteRenderer.sprite = offSprite;
            Destroy(prefabTemp);
        } else if (spriteRenderer.sprite == offSprite) {
            spriteRenderer.sprite = onSprite;
            prefabTemp = Instantiate(togglePrefab, new Vector3(0, 0, 0), Quaternion.identity);
            prefabTemp.transform.parent = gameObject.transform;
            prefabTemp.transform.localPosition = new Vector3(0, 2, 0);
        }
    }
}
