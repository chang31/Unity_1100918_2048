using UnityEngine;

/// <summary>
/// �{�ѹB��l
/// 1. ���w
/// 2. �ƾ�
/// 3. ���
/// 4. �޿�
/// </summary>

public class LearnOperator: MonoBehaviour
{
    public float a = 10;
    public float b = 3;
    public int c = 30;
    public int hp = 100;

    private void Start()
    {
        #region ���w�B��l
        // ���w =
        // ��������w�B��l�k��b���w������
        #endregion

        #region �ƾǹB��l
        // �[����l
        // + - * / %
        print("�[�k:" + (a + b)); // ���G13
        print("��k:" + (a - b)); // ���G7
        print("���k:" + (a * b)); // ���G30
        print("���k:" + (a / b)); // ���G3.3333
        print("�l�k:" + (a % b)); // ���G1

        c = c + 1;     //��ϼg�k
        print("c ���G:" + c);
        c++;           // ���W ++ ���� --
        print("c ���G:" + c);

        hp = hp + 10;           //��l�g�k
        print("HP ���G:" + hp);
        hp += 10;               // �A�μƾǹB��l += -= /= *= %=
        print("HP ���G:" + hp);

        #endregion

        #region ����B��l
        //�j�� �p��  �j����   �p����    ����     ������
        // >    <     >=       <=      ==       !=
        // �����ӭ� �åB�o�쥬�L�ȵ��G

        print("a > b" + (a > b)); // t
        print("a < b" + (a < b)); // f
        print("a >= b" + (a >= b)); // t
        print("a <= b" + (a <= b)); // f
        print("a == b" + (a == b)); // f
        print("a != b" + (a != b)); // t

        #endregion

        #region �޿�B��l
        // �åB �Ϊ� �A��
        // &&    ||   !
        // �åB �Ϊ�
        // �����ӥ��L�� �åB�o�쥬�L�ȵ��G
        // �åB:�u�n���@�� f ���G�N�O f
        print("t && t" + (true && true));   // t
        print("f && t" + (false && true));   // f
        print("t && f" + (true && false));   // f
        print("f && f" + (false && false));   // f
        // �Ϊ�:�u�n���@�� t ���G�N�O t
        print("t || t" + (true || true));   // t
        print("f || t" + (false || true));   // t
        print("t || f" + (true || false));   // t
        print("f || f" + (false || false));   // f
        // ALT + SHIT + > �ֳt��� ESC�h�X

        // �A��:�u��[�b���L�ȫe��
        print(!true);               // F
        print(!(a > b));            // F
        print(!(true && true));     // F
        #endregion

    }
}
