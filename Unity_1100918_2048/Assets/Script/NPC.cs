using System;
using UnityEngine;

public class NPC : MonoBehaviour
{
    // �p�H �ȭ������O�s�� Uinty ����� private (�w�])
    // ���} �Ҧ����O�i�s�� Unity �|��� public
    // 1.��� int �w�] 0
    // 2.�B�I�� ���p���I float �w�] 0
    // 3.�r�� ��r��T string �w�] ��
    // 4.���L�� �O�P�_ true or false (�w�] false) bool
    private void Start()
    {
        print("�ӤH:�A�n�ӶR����F��O?");
        print("���ȧ�s:BOSS��������");

    }
    /// <summary>
    /// �}�Ұө�
    /// </summary>
    /// <param name="e"></param>
    /// <returns></returns>
    public bool Shop(bool e)
    {
        return e;
    }

    /// <summary>
    /// �ʶR�D��
    /// </summary>
    /// <param name="e"></param>
    /// <returns></returns>
    public int PurchaseProps(int e = 100)
    {
        return e;
    }

    /// <summary>
    /// �ĴX�ӥ���
    /// </summary>
    public int TaskNumber = 1;
    /// <summary>
    /// ���ȫe�m�s��
    /// </summary>
    public string GetTask = ""; // ���o����
    /// <summary>
    /// ���Ƚs��
    /// </summary>
    /// <param name="TaskNo"></param>
    public void TaskAction(int TaskNo)
    {
        TaskNumber = TaskNo;
        GetTask = "TS" + Convert.ToString(TaskNo);
        print($"���Ƚs��:{GetTask}");
    }

    /// <summary>
    /// ���ȧ�s
    /// </summary>
    /// <returns></returns>
    private int TaskUpdate()
    {
        return 0;
    } // ���ȧ�s
    /// <summary>
    /// ��������
    /// </summary>
    /// <returns></returns>
    private bool MissionAccomplished()
    {
        return false;
    }






}
