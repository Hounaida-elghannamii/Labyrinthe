using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ss : MonoBehaviour
{
    public GameObject menu_panel;
    public GameObject levels_panel;
    public GameObject[] levels;
    int max_level = 1;
    //PlayerPrefs===tahfid data f mobile
    void Start()
    {
       // restb();
     //PlayerPrefs.DeleteAll();
     //PlayerPrefs.DeleteAll();
     
        if (PlayerPrefs.HasKey("max_level"))
        {
            max_level = PlayerPrefs.GetInt("max_level");
        }
        else
        {
            PlayerPrefs.SetInt("max_level", 1);
        }
        for (int i=1;i<=levels.Length;i++)
        {
            levels[i - 1].transform.GetChild(0).GetComponent<Text>().text = i.ToString();
            if (i<=max_level) {
                //this level unclocked
                Debug.Log("this level " + i + " Unclocked");
                levels[i - 1].transform.GetChild(1).gameObject.SetActive(false);
                



            }
            else
            {
                //this level clocked
                Debug.Log("this level " + i + " clocked");
                levels[i - 1].transform.GetChild(0).GetComponent<Text>().color = Color.grey;
                Destroy(levels[i - 1].GetComponent<Button>());
                levels[i - 1].transform.GetChild(1).gameObject.SetActive(true);
            }
        }
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
    public void ShowLevels()
    {
        
        levels_panel.SetActive(true);
        menu_panel.SetActive(false);
        
    }
    public void ShowMenu()
    {
        levels_panel.SetActive(false);
        menu_panel.SetActive(true);
    }
    public void GotoGame(int level_num)
    {
       
            PlayerPrefs.SetInt("Current_level", level_num);
        SceneManager.LoadScene(level_num);



    }
        public void Quit()
    {
        Application.Quit(); 
    }
   public void restv()
    {
        PlayerPrefs.DeleteAll();
    }

}
