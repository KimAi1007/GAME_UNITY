using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Codestart : MonoBehaviour
{
	public void PlayerGame()
	{
		Application.LoadLevel("1");
	}
	public void BackToMenu()
	{
		Application.LoadLevel("LevelMenu");
	}
}
