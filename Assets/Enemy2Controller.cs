using UnityEngine;

public class Enemy2Controller : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float direction = -1f;

    public float a = 10f;
    public float b = -10f;

    private Rigidbody2D rb;

    void Update()
    {
        transform.Translate(Vector3.left * direction * moveSpeed * Time.deltaTime);

        if (transform.position.x >= a || transform.position.x <= b)
        {
            direction = -direction;
        }
    }
}
