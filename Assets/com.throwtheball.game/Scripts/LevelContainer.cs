using UnityEngine.UI;
using UnityEngine;

public class LevelContainer : MonoBehaviour
{
    private void Start()
    {
        GetComponent<Text>().text = $"Level {StatsUtility.Level}";
    }
}
