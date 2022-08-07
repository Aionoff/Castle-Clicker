using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UI_FoodCounter : MonoBehaviour
{
    public StatisticManager statisticManager;
    public TMP_Text foodCounter;

    void Update()
    {
        foodCounter.text = $"Food: {statisticManager.food}, {statisticManager.foodPerSec}/s";
    }
}
