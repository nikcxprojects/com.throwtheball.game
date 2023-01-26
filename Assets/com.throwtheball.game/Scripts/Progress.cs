using UnityEngine.UI;
using UnityEngine;

public class Progress : MonoBehaviour
{
    public static Progress Instance { get => FindObjectOfType<Progress>(); }

    private const float max = 10;

    [SerializeField] Text currentLevelCount;
    [SerializeField] Text nextLevelCount;

    [Space(10)]
    [SerializeField] Image progressImgAmount;

    private void Start()
    {
        currentLevelCount.text = $"{StatsUtility.Level}";
        nextLevelCount.text = $"{StatsUtility.Level + 1}";

        UpdateProgress();
    }

    public void UpdateProgress(int amount = 0)
    {
        StatsUtility.LevelProgress += amount;
        progressImgAmount.fillAmount = StatsUtility.LevelProgress / max;
    }
}
