// ����:������r�A������
// �\�� 21.10.17
// �}�o�� Chang 21.10.17 
using UnityEngine;  //  �ޥ� UnityEngine API

//class���O(�Ź�)  �W�ٸ��ɦW�ۦP
public class Car : MonoBehaviour
{
    #region ���P�򥻻y�k
    // �{����� Field �x�s���
    // �y�k:
    // �׹��� ������� ���W�� ���w �w�]�� �����Ÿ�
    // �`�ΰ򥻥|�j����
    // 1.��� int �w�] 0
    // 2.�B�I�� ���p���I float �w�] 0
    // 3.�r�� ��r��T string �w�] ��
    // 4.���L�� �O�P�_ true or false (�w�] false) bool
    // �׹����������
    // �p�H �ȭ������O�s�� Uinty ����� private (�w�])
    // ���} �Ҧ����O�i�s�� Unity �|��� public
    // ����ݩ� Attritube
    // [�ݩʦW��(��)] - ������b���e���ΤW�@��
    // 1. ���D Header (�r��)
    // 2. ���� Tooltip (�r��)
    // 3. �d�� Range (�B�I��,�B�I��)
    [Header("�T��CC��")][Range(1000,5000)]
    public int cc = 2000;
    [Tooltip("�T�����q,�d��O3��20"), Range(3,20)] 
    public float weight = 3.5f;
    public string brand = "���";
    public bool hasSkyWindow = true;
    #endregion

    #region �C�����`������
    // �C�� Color
    public Color color1;
    public Color colorRed = Color.red;
    public Color colorCustom = new Color(0, 0, 1);
    public Color colorCustomAlpga = new Color(0, 1, 0, 0.3f);
    // �V�q(�y��) Vector (�B�I��~�B�I��)/int���
    // Vector 2 ~ 4
    public Vector2 v2;
    public Vector2 v2One = Vector2.one;
    public Vector2 v2up = Vector2.up;
    public Vector2 v2Custom = new Vector2(7, 9);
    public Vector3 v3Custom = new Vector3(1, 2, 3);
    public Vector4 v4Custom = new Vector4(1, 2, 3, 4);
    // ���� KeyCode [Mouse0����,1�k��,2�u��]
    public KeyCode kc;
    public KeyCode kcW = KeyCode.W;
    public KeyCode kcML = KeyCode.Mouse0;
    // �C������ GameObject �������w�w�]��
    public GameObject CarBox;
    public GameObject CarOil;
    // ���� Component �������w�w�]��
    public Transform traBox;
    public SpriteRenderer sprBox;
    public Camera cam;
    #endregion

    #region �s������� Set Get
    // �{���J�f:�ƥ�
    // �}�l�ƥ�:����C������@��,��l�]�w
    private void Start()
    {
        print("���o,�v�x�w�}");
        // Get ���o�����   *�w�]�ȥH���O�ݩʬ��u���@(Inspector)
        // �y�k:
        // ���W��
        print("CC��:" + cc);
        print("���" + weight);

        // Set �s�������
        // �y�k:
        // ���W�� ���w ��
        brand = "���Q";
        cc = 3500;
    }
    #endregion
}