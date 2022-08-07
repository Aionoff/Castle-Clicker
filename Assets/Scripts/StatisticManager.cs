using UnityEngine;

public class StatisticManager : MonoBehaviour
{
    public int population;
    public int peasants;
    public int food;
    public float foodPerSec;
    public int gardens;

    public int gardenCost;

    private float timer;
    private int delayAmount;

    void Start()
    {
        population = 0;
        peasants = 0;
        food = 100;
        delayAmount = 1;
        gardens = 0;
        gardenCost = 10;
        foodPerSec = 0f;
    }

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= delayAmount)
        {
            timer = 0f;
            UpdateFood();
        }
    }

    public void AddPeasant()
    {
        population++;
        peasants++;
    }

    public void BuyGarden()
    {
        if(peasants >= gardenCost)
        {
            gardens++;
            peasants = peasants - gardenCost;
            gardenCost = (int)(gardenCost * 1.689);
        }
    }

    private void UpdateFood()
    {
        var foodIncome = gardens * 10;
        var foodOutcome = (int)(population / 10);

        food = food + foodIncome;
        food = food - foodOutcome;
        foodPerSec = foodIncome - foodOutcome;
    }
}
