using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UI_SawmillManager : MonoBehaviour
{
	public StatisticManager statisticManager;
	public Button buySawmillButton;
	public TMP_Text buttonText;

	void Start()
	{
		buySawmillButton.onClick.AddListener(TaskOnClick);
		buttonText.text = $"Sawmill. You have 0. Cost: 30 peas. 50 food";
	}

	void TaskOnClick()
	{
		statisticManager.BuySawmills();
		UpdateSawmillButtonText();
	}

	private void UpdateSawmillButtonText()
	{
		buttonText.text = $"Sawmill. You have {statisticManager.sawmills}. Cost: {statisticManager.sawmillCostPeasants} peas. {statisticManager.sawmillCostFood} food";
	}
}
