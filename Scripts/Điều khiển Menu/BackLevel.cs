using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackLevel : MonoBehaviour
{
	public void BackToMenu()
	{
		Application.LoadLevel("LevelMenu");
	}
	public void Level5()
	{
		Application.LoadLevel("5");
	}
}
