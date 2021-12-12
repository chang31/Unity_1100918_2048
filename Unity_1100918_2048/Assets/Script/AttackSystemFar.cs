using UnityEditor;
using UnityEngine;

public class AttackSystemFar : AttackSystem
{
    /// <summary>
    /// �����t�ΡG���Z��
    /// �~�ӻy�k�G�l���O : �n�~�Ӫ����O(�����O)
    /// �֦������O�������G���B�ݩʡB��k�B�ƥ�
    /// </summary>

    [Header("�ͦ��ɤl��m")]
    public Transform positionSpawn;
    [Header("�����ɤl")]
    public GameObject goAttackParticle;
    [Header("�ɤl�o�g�t��"), Range(0, 1500)]
    public float speed = 500;
    // override �Ƽg: �Ƽg�����O virtual ����
    public override void Attack()
    {
        base.Attack();

        print("���Z����");

        // �ͦ�(���� ���� ���� )
        // �ͦ�������W�٫��|��(Clone)
        // Quaternion �|����
        // identity �s����
        GameObject tempAttack = Instantiate(goAttackParticle, positionSpawn.position, Quaternion.identity);
        tempAttack.GetComponent<Rigidbody2D>().AddForce(new Vector2(speed, 0));

    }

}
