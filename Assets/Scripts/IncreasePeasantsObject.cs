using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class IncreasePeasantsObject : MonoBehaviour
{
    public int increaseValue = 1;

    private Vector2 vector;
    private float timer;
    private float delayAmount;

    void Start()
    {
        vector = new Vector2(0, 1);
        GetComponent<TMP_Text>().text = $"+{increaseValue}";
        delayAmount = 0.5f;
    }

    void Update()
    {
        transform.Translate(vector * Time.deltaTime);

        timer += Time.deltaTime;

        if (timer >= delayAmount)
        {
            timer = 0f;

            Destroy(this.gameObject);
        }
    }
}
