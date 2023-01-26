using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get => FindObjectOfType<GameManager>(); }

    private GameObject LevelPrefab { get; set; }
    private Transform Parent { get; set; }

    [SerializeField] GameObject game;
    [SerializeField] GameObject menu;

    [Space(10)]
    [SerializeField] Text scoreText;

    private void Awake()
    {
        LevelPrefab = Resources.Load<GameObject>("level");
        Parent = GameObject.Find("Environment").transform;

        OpenMenu();
    }

    public void InitLevel()
    {
        Instantiate(LevelPrefab, Parent);
        if(!game.activeSelf)
        {
            OpenGame();
        }
    }

    public void CheckResult(float distance)
    {
        int value = distance < 0.2f ? 2 : 1;
        if(value > 1)
        {
            Destroy(Instantiate(Resources.Load<GameObject>("nice"), null), 1.0f);
        }

        Progress.Instance.UpdateProgress(value);

        StatsUtility.Score += value;
        scoreText.text = $"{StatsUtility.Score}";
    }

    public void OpenMenu()
    {
        if (FindObjectOfType<Level>())
        {
            Destroy(FindObjectOfType<Level>().gameObject);
        }

        StatsUtility.BestScore = StatsUtility.Score;

        game.SetActive(false);
        menu.SetActive(true);
    }

    public void OpenGame()
    {
        StatsUtility.Score = 0;
        scoreText.text = $"{StatsUtility.Score}";

        game.SetActive(true);
        menu.SetActive(false);
    }
}