using UnityEngine;
    // �z�Lgoogle�j�M Unity API �έn���ݩʦW�� �����|��
public class LearnPropertyStatic : MonoBehaviour
{
    private void Start()
    {
        // �R�A�ݩ� Static Property
        // ���o�R�A�ݩ�
        // �y�k : ���O�W��.�R�A�ݩʦW��
        print("�H����:" + Random.value);
        print("��v���`��:" + Camera.allCamerasCount);

        // �]�w�R�A�ݩ�
        // �y�k : ���O�W��.�R�A�ݩʦW�� ���w �� : 
        Cursor.visible = false;
        // Mathf.PI = 9.99999f; // (Read Only) ����]�w ��Ū�ݩ�

    }
}
