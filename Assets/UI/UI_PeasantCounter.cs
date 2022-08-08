using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UI_PeasantCounter : MonoBehaviour
{
    public StatisticManager statisticManager;
    public TMP_Text peasantCounter;

    void Update()
    {
        peasantCounter.text = $"Peasants: {statisticManager.peasants}, {statisticManager.peasantsPerSec}/s" ;
    }
}
