using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InGameController : MonoBehaviour
{
    private bool state;
    private GameObject Menu;
    public GameObject ESC;
    public GameObject Continue;
    public GameObject Settings;
    public GameObject Exit;
    public GameObject Clear_Menu;
    public GameObject Clear_Next;

    private void Awake()
    {
        Menu = GameObject.FindWithTag("Menu");
    }
    void Start()
    {
        Menu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {


    }

    public void ESC_Click()
    {
        
        Menu.SetActive(true);
        Time.timeScale = 0; //게임 일시정지
    }

    public void Continue_Click()
    {
        Time.timeScale = 1;
        Menu.SetActive(false);
    }

    public void Settings_Click()
    {

    }
    public void Exit_Click()
    {
        SceneManager.LoadScene("Menu");
    }
    public void Clear_Menu_Click()
    {
        SceneManager.LoadScene("Menu");
        Time.timeScale = 1;

    }

}
