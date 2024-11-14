using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Vector2 viTriHoiSinh = new Vector2(5, 5);

    public GameObject win;

    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        Vector3 move = new Vector3(horizontal, vertical, 0f).normalized;

        transform.Translate(move * moveSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            transform.position = viTriHoiSinh;
        }

        if (collision.gameObject.CompareTag("Win"))
        {
            win.SetActive(true);
        }
    }

    public void playAgain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
