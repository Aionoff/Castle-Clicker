using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UI_PopulationCounter : MonoBehaviour
{
    public StatisticManager statisticManager;
    public TMP_Text populationCounter;

    // Update is called once per frame
    void Update()
    {
        populationCounter.text = $"Population: {statisticManager.population}";
    }
}
