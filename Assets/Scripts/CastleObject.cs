using UnityEngine;
using UnityEngine.EventSystems;

public class CastleObject : MonoBehaviour
{
    public StatisticManager statisticManager;

    void OnMouseDown()
    {
        statisticManager.AddPeasant();
    }
}
