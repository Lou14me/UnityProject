using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundTiling : MonoBehaviour
{
    // Start is called before the first frame update
    public float moveSpeed = 1f;

    private float SpirteHeight;
    private bool hasTopBoddy = false;
    void Start()
    {
        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
        SpirteHeight = spriteRenderer.sprite.bounds.size.y * transform.localScale.y;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * moveSpeed * Time.deltaTime);

        float spriteEdgePosBottom = transform.position.y - SpirteHeight / 2;
        if (spriteEdgePosBottom <= Camerainfo.instance.CameratEdgeBtm && hasTopBoddy == false)
        {
            //創建一個新圖片
            makeNewSprite();
        }
        float spriteEdgePosTop = transform.position.y + SpirteHeight / 2;
        if (spriteEdgePosTop <= Camerainfo.instance.CameratEdgeBtm)
        {
            Destroy(gameObject, 3f);
        }
    }
    void makeNewSprite()
    {
        Vector3 newPos = new Vector3(transform.position.x, transform.position.y+ SpirteHeight, transform.position.z);
        Transform newSpirte = Instantiate(transform, newPos, transform.rotation);
        newSpirte.parent = transform.parent;
        hasTopBoddy = true;
    }
}
