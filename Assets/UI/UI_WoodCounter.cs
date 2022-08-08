using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UI_WoodCounter : MonoBehaviour
{
    public StatisticManager statisticManager;
    public TMP_Text woodCounter;

    void Update()
    {
        woodCounter.text = $"Wood: {statisticManager.wood}, {statisticManager.woodPerSec}/s";
    }
}
