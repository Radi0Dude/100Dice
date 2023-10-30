using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class S_StartMenu : MonoBehaviour
{
    Button startButton;


	private void Start()
	{
		startButton.GetComponent<Button>().onClick.AddListener(PressStart);
	}

	void PressStart()
	{
		SceneManager.LoadScene(sceneBuildIndex: 2);
	}


}
