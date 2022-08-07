using UnityEngine;

public class CastleObject : MonoBehaviour
{
    public StatisticManager statisticManager;

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            statisticManager.AddPeasant();
        }
    }
}
