using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class level_loader : MonoBehaviour
{
    public Button btn, btn2;
    public GameObject lockk;

    void Start()
    {
        btn.onClick.AddListener(() => {
            SceneManager.LoadScene("Game");
        });
    }

}
