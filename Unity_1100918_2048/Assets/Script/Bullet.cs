using UnityEngine;


/// <summary>
/// �l�u�t��
/// ��a�o�g�̪������O
/// �B�z�I����R������
/// </summary>
public class Bullet : MonoBehaviour
{
    public float attack;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // gameObject �����}�����C������
        // Destroy() �R������
        Destroy(gameObject);
    }


}
