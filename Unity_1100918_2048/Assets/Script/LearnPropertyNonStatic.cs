using UnityEngine;

/// <summary>
/// �ǲ߫D�R�A�ݩ�
/// </summary>
public class LearnPropertyNonStatic : MonoBehaviour
{

    // �R�A�P�D�R�A�t�� :
    // 1. �w�q���
    // 2. ����������P���O�ۦP
    // 3. ���n�x�s���� �Ҧp: Main Camera
    public Camera cam;
    public Transform tra;

    private void Start()
    {
        // �R�A��Ӳ�
        print("��v���ƶq:" + Camera.allCamerasCount);

        // �D�R�A�ݩ�
        // ���o�D�R�A�ݩʻy�k :
        // ���W��.�D�R�A�ݩʦW��
        print("��v���`��:" + cam.depth);


        // �]�w�D�R�A�ݩʻy�k :
        // ���W��.�D�R�A�ݩʦW�� ���w ��;
        tra.position = new Vector3(5, 0, 0);


    }
}
