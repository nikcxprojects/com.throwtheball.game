using UnityEngine.UI;
using UnityEngine;

public class BestScoreContainer : MonoBehaviour
{
    private void Start()
    {
        GetComponent<Text>().text = $"{StatsUtility.BestScore}";
    }
}
