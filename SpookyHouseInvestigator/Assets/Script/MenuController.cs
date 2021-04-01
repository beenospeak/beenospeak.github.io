using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
	public static MenuController instance;
	public GameObject Settings;
	public GameObject Controls;
	public bool isClicked = false;

	public void SettingsClicked()
	{
		if (isClicked == false)
		{
			Settings.SetActive(true);
			isClicked = true;
		}
	}

	public void ControlsClicked()
	{
		if (isClicked == false)
		{
			Controls.SetActive(true);
			isClicked = true;
		}
	}

	public void MenuClicked()
	{
		if (isClicked == false)
		{
			SceneManager.LoadScene("Menu");
		}
	}

	public void BackClicked()
	{
		Settings.SetActive(false);
		Controls.SetActive(false);
		isClicked = false;
	}
}
