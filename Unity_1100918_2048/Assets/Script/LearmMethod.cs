using UnityEngine;

/// <summary>
/// summary �K�n
/// ��ƻ����A��ܦb vs �sĶ�����ܤW
/// </summary>
public class LearmMethod : MonoBehaviour
{
    // ��k Method Function (�禡)   
    // �@��: ������������{�����e
    // �y�k:
    // �׹��� �Ǧ^������� ��k�W�� (�Ѽ�) { �{�����e }
    // �L�Ǧ^ void 
    // �R�W�ߺD:Unity ��k�H�j�g�}�Y
    // �ۭq��k:���|����
    public void Test()
    {
        print("�ڦb���դ�k~");
    }
    private void Start()
    {
        // �I�s��k
        // �W��();
        Test();
        Drive90();
        Drive150();
        // �I�s��k :�޼�
        Drive(70);
        Drive(200);
    }

    //�����ݨD
    //���񭵮�
    //�T���i�H�[�t �ɳt 90
    //�T���i�H�[�t �ɳt 150
    public void Drive90()
    {
        print("�}�� �ɳt:" + 90);
        print("����");
    }

    public void Drive150()
    {
        print("�}�� �ɳt:" + 150);
        print("����");
    }

    public void Drive(int speed)
    {
        print("�}�� �ɳt:" + speed);
        print("����");
    }
}
