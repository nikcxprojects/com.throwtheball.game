using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get => FindObjectOfType<GameManager>(); }

    private GameObject LevelPrefab { get; set; }
    private Transform Parent { get; set; }

    private void Awake()
    {
        LevelPrefab = Resources.Load<GameObject>("level");
        Parent = GameObject.Find("Environment").transform;
    }

    public void InitLevel()
    {
        Instantiate(LevelPrefab, Parent);
    }
}