using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_manager : MonoBehaviour
{
    public GameObject[] panels;
    // Start is called before the first frame update
    void Start()
    {
        panels[1].SetActive(true);
        panels[0].SetActive(false);
        panels[2].SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void play()
    {
        panels[0].SetActive(true);
        panels[1].SetActive(false);
        panels[2].SetActive(false);
    }

    public void setting()
    {
        panels[2].SetActive(true);
        panels[0].SetActive(false);
        panels[1].SetActive(false);
    }

    public void exit()
    {
        Application.Quit();
    }

    public void menu()
    {
        panels[1].SetActive(true);
        panels[0].SetActive(false);
        panels[2].SetActive(false);
    }
}
