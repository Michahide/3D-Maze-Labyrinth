using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    [SerializeField] GameObject levelSelect;
    [SerializeField] GameObject menuButton;
    private void Start() {
        levelSelect.SetActive(false);
        menuButton.SetActive(true);
    }

    private void Update() {
    }

    public void BackToMainMenu(){
        SceneLoader.Load("MainMenu");
    }

    public void PlayBut(){
        levelSelect.SetActive(true);
        menuButton.SetActive(false);
    }

    public void QuitBut(){
        Application.Quit();
    }

    public void level1(){
        SceneLoader.Load("Level1");
        Debug.Log("Click level 1");
    }

    public void level2(){
        SceneLoader.Load("Level2");
        Debug.Log("Click level 2");
    }

    public void level3(){
        SceneLoader.Load("Level3");
        Debug.Log("Click level 3");
    }

    public void level4(){
        SceneLoader.Load("Level4");
        Debug.Log("Click level 4");
    }

    public void level5(){
        SceneLoader.Load("Level5");
        Debug.Log("Click level 5");
    }

    public void backBut(){
        levelSelect.SetActive(false);
        menuButton.SetActive(true);
    }

}
