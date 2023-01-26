using UnityEngine;

public static class StatsUtility
{
    public static int Score
    {
        get => PlayerPrefs.GetInt("score", 0);
        set => PlayerPrefs.SetInt("score", value);
    }

    public static int BestScore
    {
        get => PlayerPrefs.GetInt("bestscore", 0);
        set
        {
            if(value > BestScore)
            {
                PlayerPrefs.SetInt("bestscore", value);
            }
        }
    }

    public static int Level
    {
        get => PlayerPrefs.GetInt("level", 1);
        set => PlayerPrefs.SetInt("level", value);
    }

    public static float LevelProgress
    {
        get => PlayerPrefs.GetFloat("levelprogress", 0);
        set => PlayerPrefs.SetFloat("levelprogress", value);
    }
}
