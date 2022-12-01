using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    public Text level_text;


    public void Start()
    {

        level_text.text = "LEVEL " + PlayerPrefs.GetInt("Current_level").ToString();
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void StartGame()
    {
        SceneManager.LoadScene("1");
        
    }
    public void NextLevel()
    {
      
        PlayerPrefs.SetInt("Current_level", PlayerPrefs.GetInt("Current_level") + 1);




        PlayerPrefs.SetInt("max_level", PlayerPrefs.GetInt("max_level") +1);




        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }
    
    public void GotoMenu()
    {
        SceneManager.LoadScene("MainF");
    }
    
}


