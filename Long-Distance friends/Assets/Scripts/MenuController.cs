using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    private GameObject Menu;
    public GameObject Chapter;
    public GameObject ESC;
    public GameObject Continue;
    public GameObject Setting;
    public GameObject Exit;
   

    // Start is called before the first frame update
    void Start()
    {
        Menu = GameObject.FindWithTag("Menu");
        Menu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void ESC_Click()
    {
        Menu.SetActive(true);
        Time.timeScale = 0; 
    }

    public void Continue_Click()
    {
        Menu.SetActive(false);
        Time.timeScale = 1;
    }

    public void Exit_Click()
    {
        Application.Quit();
    }
    public void Chapter_Click()
    {
        SceneManager.LoadScene("Play");
    }
    
}
