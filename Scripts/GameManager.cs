/*
 * Author: Lim Kai Koon
 * Date: 30/6/24
 * Description: 
 * GameManager for score and UI
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public static GameManager instance;
    public GameObject player;

    private int currentScore = 0;

    //Does not destroy when loading scene
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else if(instance != null && instance != this)
        {
            Destroy(gameObject);
        }
    }

    public void IncreaseScore(int scoreToAdd)
    {
        currentScore += scoreToAdd;
        scoreText.text = "Score: " + currentScore.ToString();
    }
    //Destroy game manager
    public void Suicide()
    {
        Destroy(this);
    }
}
