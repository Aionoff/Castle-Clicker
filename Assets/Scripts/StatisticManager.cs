using UnityEngine;

public class StatisticManager : MonoBehaviour
{
    public int population;
    public int peasants;

    public int gardens;
    public int food;
    public float foodPerSec;
    public int foodPerGarden = 4;
    public int gardenCost;

    public int sawmills;
    public int wood;
    public int woodPerSawmills = 2;
    public float woodPerSec;
    public int sawmillCostPeasants = 30;
    public int sawmillCostFood = 50;

    private float timer;
    private int delayAmount;

    void Start()
    {
        population = 0;
        peasants = 0;
        food = 0;
        delayAmount = 1;
        gardens = 0;
        gardenCost = 10;
        foodPerSec = 0f;
        sawmillCostPeasants = 30;
        sawmillCostFood = 50;
}

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= delayAmount)
        {
            timer = 0f;
            UpdateFood();
            UpdateWood();
        }
    }

    public void AddPeasant()
    {
        population++;
        peasants++;
    }

    public void BuyGarden()
    {
        if (peasants >= gardenCost)
        {
            gardens++;
            peasants = peasants - gardenCost;
            gardenCost = (int)(gardenCost * 1.689);
        }
    }

    public void BuySawmills()
    {
        if (peasants >= sawmillCostPeasants && food >= sawmillCostFood)
        {
            sawmills++;
            peasants = peasants - sawmillCostPeasants;
            food = food - sawmillCostFood;            

            sawmillCostPeasants = (int)(sawmillCostPeasants * 1.689);
            sawmillCostFood = (int)(sawmillCostFood * 1.689);
        }
    }

    private void UpdateFood()
    {
        var foodIncome = gardens * foodPerGarden;

        food = food + foodIncome;
        foodPerSec = foodIncome;
    }

    private void UpdateWood()
    {
        var woodIncome = sawmills * woodPerSawmills;

        wood = wood + woodIncome;
        woodPerSec = woodIncome;
    }
}
