using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scores : MonoBehaviour
{

	public Text score;
	public Text high;
	public static int number;

	void Start()
	{
		PlayerPrefs.DeleteAll();
		high.text = PlayerPrefs.GetInt("High Score" , 0).ToString();
	}

	void Update()
	{

		Myscore();
	}

	void Myscore()
	{

		score.text = number.ToString();

		if (number > PlayerPrefs.GetInt("High Score", 0))
		{

			PlayerPrefs.SetInt("High Score", number);
			high.text = number.ToString();
		}

	}

}
