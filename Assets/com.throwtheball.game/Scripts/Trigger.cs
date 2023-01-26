using UnityEngine;

public class Trigger : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        float distance = Mathf.Abs(collision.transform.position.x - transform.position.x);
        GameManager.Instance.CheckResult(distance);
    }
}
