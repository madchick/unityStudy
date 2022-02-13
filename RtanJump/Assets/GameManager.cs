using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager I;

    public int Score = 0;

    private void Awake()
    {
        I = this;
    }

    public void WinGame()
    {
        GameOver_();
    }

    public void AddScore(int score)
    {
        Score = Score + score;
        Debug.Log(Score.ToString());
    }

    public void GameOver()
    {
        Invoke("GameOver_", 2);
    }

    void GameOver_()
    {
        SceneManager.LoadScene(0);
    }
}
