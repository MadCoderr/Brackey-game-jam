﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
	private GameObject pasueMenu;
	// Start is called before the first frame update
	void Start()
	{
		DontDestroyOnLoad(gameObject);
		DontDestroyOnLoad(GameObject.Find("EventSystem"));
		pasueMenu = GameObject.Find("Pause Menu Background");
		pasueMenu.SetActive(false);
	}

	private void Update()
	{
		if (UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex != 1 || UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex != UnityEngine.SceneManagement.SceneManager.sceneCountInBuildSettings +1)
		{
			if (Input.GetKeyDown(KeyCode.Escape) || (Input.GetKeyDown(KeyCode.P)))
			{
				if (Time.timeScale == 0)
					UnPauseGame();
				else
					PauseGame();
			}
		}
	}
	public void PauseGame()
	{
		Handler.INSTANCE.ost.Pause();
		pasueMenu.SetActive(true);
		Time.timeScale = 0;
	}

	public void UnPauseGame()
	{
		Handler.INSTANCE.ost.UnPause();
		pasueMenu.SetActive(false);
		Time.timeScale = 1;
	}
}
