using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject prefabHinhTron;
    public GameObject player;
    public float khoangThoiGianSinh = 5f;

    void Start()
    {
        InvokeRepeating("SinhHinhTron", 5f, khoangThoiGianSinh);
    }

    void SinhHinhTron()
    {
        GameObject hinhTronMoi = Instantiate(prefabHinhTron, transform.position, Quaternion.identity);

        hinhTronMoi.GetComponent<EnemyCircle>().player = player;
    }
}
