using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject gameOverPanel;
    [SerializeField] TMP_Text timerCount;
    [SerializeField] Hole hole;
    [SerializeField] float timer;

    private void Start() {
        gameOverPanel.SetActive(false);
    }

    private void Update() {
        if (hole.Entered && !gameOverPanel.activeInHierarchy)
        {
            gameOverPanel.SetActive(true);
        }
        if(!gameOverPanel.activeInHierarchy)
        {
            timer += Time.deltaTime;
        }
        timerCount.text = "Time: " + timer;
    }

    public void BackToMainMenu(){
        SceneLoader.Load("MainMenu");
    }

    public void PlayAgain(){
        SceneLoader.ReloadLevel();
    }

    public void PlayNext(){
        SceneLoader.LoadNextLevel();
    }

    public void QuitBut(){
        Application.Quit();
    }

}
