using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
	public Button pause, continuee, bckmenu, empt;
	public GameObject ui;

	void Update()
	{
		Button btn = pause.GetComponent<Button>();
		btn.onClick.AddListener(paus);
		Debug.Log(Time.time);
	}

	void paus()
	{
		if (!ui.activeSelf)
		{

			ui.SetActive(true);
			Time.timeScale = 0;
		}

		Button btn = continuee.GetComponent<Button>();
		btn.onClick.AddListener(Continue_game);

		//Button btn1 = bckmenu.GetComponent<Button>();
		//btn.onClick.AddListener(slider_menu);

	}

	void Continue_game()
	{

		ui.SetActive(false);
		Time.timeScale = 1;
	}
	/*
	void slider_menu()
	{
		SceneManager.loadScene("Slider Menu");
	}*/
}