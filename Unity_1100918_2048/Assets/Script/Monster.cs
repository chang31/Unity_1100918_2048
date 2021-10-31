using UnityEngine;

public class Monster : MonoBehaviour
{
    // 1.��� int �w�] 0
    // 2.�B�I�� ���p���I float �w�] 0
    // 3.�r�� ��r��T string �w�] ��
    // 4.���L�� �O�P�_ true or false (�w�] false) bool

    // Moving speed ���ʳt��
    // Attack power �����O
    // Blood volume ��q
    // Tracking range �l�ܽd��
    // Tracking displacement (three-dimensional vector) �l�ܦ첾(�T���V�q)
    // �����D�� (GameObject)
    // Probability of dropping items �����D����v
    // Drop item sound effects �����D�㭵��
    // Injured sound ���˭���
    // Attack sound ��������

    [Header("���ʳt��")]
    [Tooltip("���ʳt��,�d��O0��10"), Range(0, 10)]
    public float ms = 3.5f;
    [Tooltip("�����O,�d��O0��500"), Range(0, 500)]
    public float ap = 100f;
    [Tooltip("��q,�d��O0��5000"), Range(0, 5000)]
    public float bv = 350f;
    [Tooltip("�l�ܽd��,�d��O0��50"), Range(0, 50)]
    public float tr = 30f;

    
    public string td = "�l�ܦ첾";
    public Vector3 v3Custom = new Vector3(1, 2, 3);

    [Header("�����D��")]
    public bool go = false;
    [Header("�����D����v")]  [Range(0, 1)]
    public int podi = 1;
    [Header("�����D�㭵��")]
    public bool dise = false;
    [Header("���˭���")]
    public bool ins = false;
    [Header("��������")]
    public bool ats = false;


    private void Start()
    {
        print("���ʳt��:" + ms);
        print("�����O:" + ap);
        print("��q:" + bv);
        print("�l�ܽd��:" + tr);

    }
}
