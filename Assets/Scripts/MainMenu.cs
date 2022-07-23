using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
	public void PlayGame()
	{
		SceneManager.LoadScene("RealGame");
	}
	public void QuitGame()
	{
		Application.Quit();
	}
	public void Credits()
	{
		SceneManager.LoadScene("Credits");
	}
	public void Back()
	{
		SceneManager.LoadScene("Menu");
	}
}
