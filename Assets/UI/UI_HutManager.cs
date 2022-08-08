using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UI_HutManager : MonoBehaviour
{
	public StatisticManager statisticManager;
	public Button buyHutButton;
	public TMP_Text buttonText;

	void Start()
	{
		buyHutButton.onClick.AddListener(TaskOnClick);
		buttonText.text = $"Hut. You have 0. Cost: 200 food, 50 wood";
	}

	void TaskOnClick()
	{
		statisticManager.BuyHut();
		UpdateHutButtonText();
	}

	private void UpdateHutButtonText()
	{
		buttonText.text = $"Hut. You have {statisticManager.huts}. Cost: {statisticManager.hutCostFood} food, {statisticManager.hutCostWood} wood";
	}
}
