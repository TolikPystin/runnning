using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Timeline;

public class Gamemaneger : MonoBehaviour

{
    public int lives = 2;
    public int coins = 0;
    public TextMeshProUGUI textLives;
    public TextMeshProUGUI textcoins;
    public GameObject loseponel;
    public GameObject winponel;
    



    public void Gameover()
    {
        Debug.Log("gameover");
       loseponel.gameObject.SetActive(true);
        Time.timeScale = 0f;
    }

    


    public void Restartgame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); // перезапуск игры
        Time.timeScale = 1f;
    }




    public void UpdateGui()
    {
        textLives.text = "lives: " + lives.ToString(); 
        textcoins.text = "coins: " + coins.ToString();
    }


    void Start()
    {
        loseponel.gameObject.SetActive(false);
        winponel.gameObject.SetActive(false);
        

        UpdateGui();

    }


    public void WinGame()
    {
        winponel.gameObject.SetActive(true);
        Time.timeScale = 0f;
    }
}