using UnityEngine.UI;
using UnityEngine;

public class Menu : MonoBehaviour
{
    private void Start()
    {
        transform.GetChild(0).GetComponent<Button>().onClick.AddListener(() =>
        {
            GameManager.Instance.InitLevel();
            gameObject.SetActive(false);
        });
    }
}
