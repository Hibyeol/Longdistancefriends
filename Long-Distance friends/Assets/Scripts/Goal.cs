using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public GameObject goal;
    // Start is called before the first frame update
    void Start()
    {
        goal.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            goal.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
