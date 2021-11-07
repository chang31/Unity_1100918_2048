using UnityEngine;

/// <summary>
/// �C�| : �U�Ԧ��C�|
/// </summary>
public class LearnEnumeration: MonoBehaviour
{
    // 1. �w�q�C�|
    // �y�k : �׹��� �C�| �C�|�W�� ( �C�|��1�A�C�|��2�A...�C�|��n )
    public enum StateEnemy
    {
        Idle, Walk, Track, Attack, Dead
    }
    // 2. �ϥΦC�|
    // �y�k : �׹��� �C�|�W�� ���W�� ���w �� :
    public StateEnemy state;

    private void Update()
    {
        switch (state)
        {
            case StateEnemy.Idle:
                print("���ݤ�");
                break;
            case StateEnemy.Walk:
                print("������");
                break;
            case StateEnemy.Track:
                print("�l�ܤ�");
                break;
            case StateEnemy.Attack:
                print("������");
                break;
            case StateEnemy.Dead:
                print("���`��");
                break;
        }
    }
}
