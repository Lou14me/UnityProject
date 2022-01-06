using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Start is called before the first frame update
    public float moveSpeed=5f;
    public int damage = 1;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up*moveSpeed*Time.deltaTime);
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.tag=="bulletRed"){
            Debug.Log("Hit bullet");
            other.gameObject.GetComponent<Obstacle>().BeDamage(damage);
            Destroy(gameObject);
        }   
    }
}
