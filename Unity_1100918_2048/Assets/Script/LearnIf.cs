using UnityEngine;

public class LearnIf : MonoBehaviour
{
    public bool openDoor;

    private void Start()
    {
        // �P�_�� if else
        // �y�k
        // �p�G ( ���L�� ) { ���L�� ���� true �|���� �{�����e }
        // �_�h (���L�� ���� false �|���� �{�����e )
        if (true)
        {
            print("���L�� true");
        if (false)
            {
            print("���L�� false");
            }

        // openDoor == ture �P openDoor
        if (openDoor)
        {
                print("�}��");
        }
        else
        {
                print("����");
        }
        }
    }
}
