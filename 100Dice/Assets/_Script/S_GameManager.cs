using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class S_GameManager : MonoBehaviour
{
	List<int> PlayerScores = new List<int>();

	public Button DiceThrow, nextPlayerButton;

	private void Start()
	{
		DiceThrow.GetComponent<Button>().onClick.AddListener(ThrowDice);

		nextPlayerButton.GetComponent<Button>().onClick.AddListener(NextPlayer);
	}

	void ThrowDice()
	{

	}
	void NextPlayer()
	{

	}

}
