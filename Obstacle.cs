using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    // Start is called before the first frame update
    public int damage = 1;
    public float moveSpeed=2f;
    public int scorePoint = 10;
    private float spriteHeight;
    private float spriteEdgePosTop;
    public bool CounterClockwise = false;
    public int health;
    void Start()
    {
        SpriteRenderer spriteRenderer = GetComponentInChildren<SpriteRenderer>();
        spriteHeight = spriteRenderer.sprite.bounds.size.y*gameObject.transform.GetChild(0).transform.localScale.y;
        GetComponentInChildren<Animator>().SetBool("CounterClockwise",CounterClockwise);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down*moveSpeed*Time.deltaTime);

        spriteEdgePosTop = transform.position.y+spriteHeight/2;
        if(spriteEdgePosTop<=Camerainfo.instance.CameratEdgeBtm){
            Destroy(gameObject,2f);
        }
    }
    private void OnCollisionEnter2D(Collision2D other) {
        if(other.collider.tag=="Player"){

            Destroy(gameObject);
        }    
    }
    public void BeDamage(int damage){
        health -= damage;
        if(health<=0){
            GameManager1.instance.player.gameObject.GetComponent<Health>().BeDamage(damage);
            Destroy(gameObject);
        }
    }
}
