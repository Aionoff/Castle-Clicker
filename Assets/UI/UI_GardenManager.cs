using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UI_GardenManager : MonoBehaviour
{
    public StatisticManager statisticManager;
    public Button buyGardenButton;
	public TMP_Text buttonText;

	void Start()
	{
		buyGardenButton.onClick.AddListener(TaskOnClick);
		buttonText.text = $"Garden. You have 0. Cost: 10 peasants.";
	}

	void TaskOnClick()
	{
		statisticManager.BuyGarden();
		UpdateGardenButtonText();
	}

	private void UpdateGardenButtonText()
    {
		buttonText.text = $"Garden. You have {statisticManager.gardens}. Cost: {statisticManager.gardenCost} peasants.";
	}
}
