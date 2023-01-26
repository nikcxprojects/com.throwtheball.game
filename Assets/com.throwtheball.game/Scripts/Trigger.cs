using UnityEngine;

public class Trigger : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        float distance = Mathf.Abs(collision.transform.position.x - transform.position.y);
        GameManager.Instance.CheckResult(distance);
    }
}
