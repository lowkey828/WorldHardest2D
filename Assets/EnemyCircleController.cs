using UnityEngine;

public class EnemyCircle : MonoBehaviour
{
    public float tocDoDiChuyen = 1f;
    public GameObject player;

    void Update()
    {
        if (player != null)
        {
            transform.position = Vector2.MoveTowards(transform.position, player.transform.position, tocDoDiChuyen * Time.deltaTime);
        }
    }
}
