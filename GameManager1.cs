using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameManager1 : MonoBehaviour
{
    public Score score;
    public GameObject player;
    public static GameManager1 instance;
    private void Awake() {
        instance = this;    
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
