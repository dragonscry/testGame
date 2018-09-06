using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

    public GameObject balloon;
    public Vector2 spawnValues;

    [Range(1,10)]
    public int balloonCount = 1;

    public int activeBalloon;

    public Text scoreText;
    private int score;


	// Use this for initialization
	void Start () {
        score = 0;
        UpdateScore();

        StartCoroutine(SpawnWaves());
	}
	
	// Update is called once per frame
	void Update () {
        HowManyBalloons();

		
	}

    IEnumerator SpawnWaves()
    {
        while(true)
        {   
            if(balloonCount > activeBalloon)
            {
                for (int i = 0; i < balloonCount; i++)
                {
                    float multiple = 10 / balloonCount;
                    Vector2 spawnPosition = new Vector2(Random.Range(-spawnValues.x, spawnValues.x), spawnValues.y);
                    Instantiate(balloon, spawnPosition, Quaternion.identity);
                    yield return new WaitForSeconds(0.3f);
                }

            }
            else
            {
                yield return new WaitForSeconds(0.1f);
            }

        }
                

    }

    public void AddScore (int newScoreValue)
    {
        score += newScoreValue;
        UpdateScore();
    }

    void UpdateScore()
    {
        scoreText.text = "Score: " + score;
    }

    void HowManyBalloons()
    {
        activeBalloon = GameObject.FindGameObjectsWithTag("balloon").Length;
    }
    
}
