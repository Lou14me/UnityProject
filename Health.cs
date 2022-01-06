using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Health : MonoBehaviour
{
    public int Hp = 4;
    public int damage = 2;
    private int curHp;
    public Image[] hearts;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        for(int i = 0 ; i<=hearts.Length;i++){
            if(i<curHp){
                hearts[i].enabled = true;
            }else{
                hearts[i].enabled = false;
            }
        }
        
    }
    public void BeDamage(int damage){
        curHp -= damage;
        if(curHp<=0){
            Destroy(gameObject);
        }
    }
}
