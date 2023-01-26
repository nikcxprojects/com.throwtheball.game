using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get => FindObjectOfType<GameManager>(); }

    private GameObject LevelPrefab { get; set; }
    private Transform Parent { get; set; }

    [SerializeField] GameObject game;

    private void Awake()
    {
        LevelPrefab = Resources.Load<GameObject>("level");
        Parent = GameObject.Find("Environment").transform;
    }

    public void InitLevel()
    {
        Instantiate(LevelPrefab, Parent);
        if(!game.activeSelf)
        {
            game.SetActive(true);
        }
    }

    public void CheckResult(float distance)
    {

    }
}