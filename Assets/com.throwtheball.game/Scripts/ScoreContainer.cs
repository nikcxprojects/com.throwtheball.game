using UnityEngine;
using UnityEngine.UI;

public class ScoreContainer : MonoBehaviour
{
    private void Start()
    {
        GetComponent<Text>().text = $"{StatsUtility.Score}";
    }
}
