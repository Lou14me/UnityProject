using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour
{
    // Start is called before the first frame update
    private int score;
    private Text scoreText;
    public float timeBetweenToAdd = 0.5f;
    private float timeToAdd;
    void Start()
    {
        scoreText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time>=timeToAdd){
            score++;
            scoreText.text=score.ToString();
            timeToAdd = Time.time+timeBetweenToAdd;
            
        }
    }
    public void AddScore(int point){
        score += point;
        scoreText.text = score.ToString();
    }
}
