using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// ��q�t��
/// �޲z��q ���˻P���`
/// </summary>
public class HealthSystem : MonoBehaviour
{
    [Header("��q"), Range(0, 500)]
    public float hp = 100;
    [Header("�n�����q�P���")]
    public Text textHp;
    public Image imgHp;
    [Header("�y���ˮ`���������")]
    public string tagDamageObject;

    private float hpMax;

    // ����ƥ� : �bStart ���e����@�� �B�z��l��
    private void Awake()
    {
        hpMax = hp;
    }

    /// <summary>
    /// ����
    /// </summary>
    /// <param name="damege"></param>
    public void Hurt(float damege)
    {
        hp -= damege;
        textHp.text = "HP" + hp;
        imgHp.fillAmount = hp / hpMax;
    }
}
