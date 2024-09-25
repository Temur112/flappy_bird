using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class logicManagerScript : MonoBehaviour
{
    public int playerScore;
    public Text scoreText;
    public AudioSource src;
    public AudioClip flap, point, die;

    public GameObject gameOverScreen;

    [ContextMenu("Increase Score")]
    public void addScore(int scoreToAdd){
        playerScore = playerScore + scoreToAdd;
        scoreText.text = playerScore.ToString();
    }

    public void restartGame(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver(){
        gameOverScreen.SetActive(true);
    }

    public void flapSound(){
        src.clip = flap;
        src.Play();
    }

    public void dieSound(){
        src.clip = die;
        src.Play();
    }

    public void getPoint(){
        src.clip = point;
        src.Play();
    }
}
