using UnityEngine;

public class LearnProperty : MonoBehaviour
{
    // ��� 
    public int passwordField = 123456789;

    // �ݩ�
    // �y�k:
    // �׹��� ����ݩ� �ݩʦW�� { �s���l }
    public int passwordProperty { get; set; }
    // get���o set�s��
    // ��Ū�ݩ� �u����o
    // �H�ڹF => 
    public int myPasswordProperty { get => 6869; }
    //��Ū����g�k
    // get �ݨϥ�����r return �Ǧ^
    public string nameCharacter
    {
        get
        {
            print("�ڦb�ݩ� name Character �̭�~");
            return "Chang";
        }
    }
    // �߼g����g�k
    // set �i�H�ϥ�����r value ��J��
    public float Attack
    {
        set
        {
            print("�����O:" + value);
        }
    }

    //�}�l�ƥ� start ����ɰ���@��
    private void Start()
    {
        // Set �s���ݩʸ��
        // �y�k:
        // �ݩʦW�� ���w ��
        passwordProperty = 666;
        // Get ���o�ݩʸ��
        // �y�k:
        // �ݩʦW��
        print("�ݩʱK�X" + passwordProperty);

        // myPasswordProperty = 999 // ����]�w��Ū
        print("�ڪ��ݩʱK�X:" + myPasswordProperty);

        print(nameCharacter);

        // print(attack);  // ������o�߼g
        Attack = 99.9f;
    }
    
}