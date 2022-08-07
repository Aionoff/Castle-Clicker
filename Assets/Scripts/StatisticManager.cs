using UnityEngine;

public class StatisticManager : MonoBehaviour
{
    public int peasants;

    void Start()
    {
        peasants = 0;
    }

    public void AddPeasant()
    {
        peasants++;

        Debug.Log(peasants);
    }
}
