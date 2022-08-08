using UnityEngine;
using UnityEngine.EventSystems;

public class CastleObject : MonoBehaviour
{
    public StatisticManager statisticManager;
    public Transform canvas;
    public IncreasePeasantsObject increaseObject;

    void OnMouseDown()
    {
        statisticManager.AddPeasant();
        Vector3 worldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        worldPosition.z = 91;
        worldPosition.y += 0.2f;
        worldPosition.x -= 0.15f;
        var newIncrease = Instantiate(increaseObject, worldPosition, Quaternion.identity, canvas);
        newIncrease.GetComponent<IncreasePeasantsObject>().increaseValue = statisticManager.peasantsPerClick;
    }
}
