using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int playerScore = 0;
    public TMP_Text score;
    public GameObject GameOverScreen;


    [ContextMenu("Add Point")]
    public void addScore()
    {
        playerScore++;
        score.text = playerScore.ToString();
    }

    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameover()
    {
        GameOverScreen.SetActive(true);
    }


}
