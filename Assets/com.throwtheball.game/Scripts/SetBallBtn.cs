using UnityEngine;
using UnityEngine.UI;

public class SetBallBtn : MonoBehaviour
{
    Button btn;

    private void Awake()
    {
        btn = GetComponent<Button>();
        btn.onClick.AddListener(() =>
        {
            StatsUtility.CurrentBall = transform.parent.GetSiblingIndex();
        });
    }

    private void OnEnable()
    {
        btn.interactable = transform.parent.GetSiblingIndex() <= StatsUtility.Skins;
    }
}
