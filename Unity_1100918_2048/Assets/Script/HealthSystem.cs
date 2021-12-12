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
    [Header("�ʵe�Ѽ�")]
    public string parameterDamage = "����Ĳ�o";
    public string parameterDead = "���`Ĳ�o";


    private float hpMax;
    private Animator ani;
    
    // ����ƥ� : �bStart ���e����@�� �B�z��l��
    private void Awake()
    {
        hpMax = hp;
        ani = GetComponent<Animator>();
    }

    private void Start()
    {
        textHp.text = "HP" + hp;
        imgHp.fillAmount = 1;
    }

    // �I���ƥ�: ��ӸI�����䤤�@�Ӧ��Ŀ� Is Trigger
    // Enter �I���}�l�ɰ��榹�ƥ�@��
    // collision �I�쪫�󪺸I����T
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == tagDamageObject)
        {
            // 
            Hurt(collision.GetComponent<Bullet>().attack);
        }
    }

    /// <summary>
    /// ����
    /// </summary>
    /// <param name="damege"></param>
    public void Hurt(float damege)
    {
        if (hp <= 0) return;            // �p�G���`�N���X

        hp -= damege;
        hp = Mathf.Clamp(hp, 0, hpMax);  // ����(hp �̤p �̤j)
        textHp.text = "HP" + hp;
        imgHp.fillAmount = hp / hpMax;
        ani.SetTrigger(parameterDamage);
        if (hp <= 0) Dead();
    }
    /// <summary>
    /// ���`
    /// </summary>
    private void Dead()
    {
        ani.SetTrigger(parameterDead);
    }
}
