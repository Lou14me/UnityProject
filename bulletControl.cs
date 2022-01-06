using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletControl : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform[] muzzles;
    public GameObject[] bullet;
    public float bulletShootTime = 500;
    private float nextShootTime;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            Shoot();
        }
    }
    void Shoot(){
        if(Time.time>=nextShootTime){
            CreateBullet();
            nextShootTime = Time.time+bulletShootTime/1000;
        }
    }
    void CreateBullet(){
        for(int i=0;i<=muzzles.Length;i++){
            GameObject bulletObj = bullet[Random.Range(0,bullet.Length)];
            Instantiate(bulletObj,muzzles[i].position,muzzles[i].rotation);
        }
    }
}
