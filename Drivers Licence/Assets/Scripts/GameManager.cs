using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public TextMeshProUGUI youLoseText;
    public bool isGameActive;
    public Button restartButton;

    // Start is called before the first frame update
    void Start()
    {
        isGameActive = true; 
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GameOver()
    {
        restartButton.gameObject.SetActive(true);
        youLoseText.gameObject.SetActive(true);
        isGameActive = false;
    }

   // private void onTriggerEnter(collider other)
    //{
    //    Destroy(gameObject);
    //    if (!gameObject.CompareTage("Death"))
     //   { GameManager.GameOver(); }
   // }

    public void RestartGame()
    {
   
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
