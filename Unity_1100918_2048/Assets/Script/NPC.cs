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
    public bool Shop = true; // �}�Ұө�
    public int PurchaseProps =100; // �ʶR�D��
    public int GetTask = 01; // ���o����
    private int TaskUpdate =1; // ���ȧ�s
    private bool MissionAccomplished = false; //��������






}
