using UnityEngine;
using System.Linq; // LinQ Query �d�߻y�� - ��Ƭd��

/// <summary>
/// �{�ѤG���}�C
/// </summary>
public class Learn2DArray : MonoBehaviour
{
    // �@���}�C
    public int[] numbers = { 1, 3, 6, 8, 9 };
    // �G���}�C
    public int[,] bloscks = { { 6, 9 }, { 7, 8 } };

    public string[,] objects = new string[4, 6];

    public int[,] scores = { { 10, 30 }, { 66, 88 }, { 9, 89 } };

    private void Start()
    {
        #region �s��
        // �@���}�C�s��
        numbers[4] = 99;
        print("�@���}�C�Ĥ������:" + numbers[4]);

        // �G���}�C�s��
        print("�G���}�C�ĤG�C�Ĥ@��1,0:" + bloscks[1, 0]);
        bloscks[1, 0] = 6;
        print("�G���}�C�ĤG�C�Ĥ@��1,0:" + bloscks[1, 0]);

        print("�G���}�C�Ĥ@���ת���:" + scores.GetLength(0));
        print("�G���}�C�ĤG���ת���:" + scores.GetLength(1));

        string result = "";

        for (int i = 0; i < scores.GetLength(0); i++)
        {
            for (int J = 0; J <scores.GetLength(1); J++)
            {
                result += scores[i, J] + " | ";

            }

            result += "\n";
        }

        print(result);
        #endregion

        #region ��Ʒj�M

        // �j�M numbers �@���}�C���j�󵥩�10�����
        // var �L������ƫ��A
        // from ���A in �}�C       - �q�}�C�j�M��ƨëO�s�� ���A
        // where ���A ����         - �P�_ ���A �O�_�ŦX����
        // select ���A;            - ��� �ŦX���� ���A
        var numberGratherTen =
            from int n in numbers
            where n >= 10
            select n;

        print("�ŦX >= 10 ��Ʀ��X��:" + numberGratherTen.Count());
        for (int i = 0; i < numberGratherTen.Count(); i++)
        {
            print(">= 10 ����Ƭ�:" + numberGratherTen.ToArray()[i]);
        }

        // scores ���ή檺���Ʀ�����
        var noPass =
            from int no in scores
            where no < 60
            select no;

        for (int i = 0; i < noPass.Count(); i++)
        {
            print("���ή檺����:" + noPass.ToArray()[i]);
        }
        #endregion
    }
}
