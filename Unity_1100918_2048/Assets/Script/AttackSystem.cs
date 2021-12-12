using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using System.Collections; // �ޥ� �t�� ���X API:��P�{��

public class AttackSystem : MonoBehaviour
{
    /// <summary>
    /// �����t�ΡG��Z��
    /// </summary>
    #region ���G���}
    [Header("�����O��")]
    public float attack = 10;
    [Header("�����ؼ�")]
    public GameObject goTarget;
    [Header("�����O����")]
    public Text textAttack;
    [Header("�������")]
    public float delayAttack = 3.5f;
    [Header("����ǰe�ˮ`")]
    public float delaySendDamage = 0.5f;
    [Header("�ʵe�Ѽ�")]
    public string parameterAttack = "����Ĳ�o";
    #endregion

    #region ���:�O�@ Protected
    // public ���\�������O�s��
    // private ���\�����O�s��
    // protected ���\�l���O�s��
    protected HealthSystem targetHealthSystem;
    protected Animator ani;

    #endregion


    #region  �ƥ�
    private void Awake()
    {
        textAttack.text = "Atk" + attack;
        targetHealthSystem = goTarget.GetComponent<HealthSystem>();
    }
    #endregion

    [Header("���������ƥ�")]
    public UnityEvent onAttackFinish;

    #region ��k�G���}
    // virtual ����:���\�l���O�Ƽg
    /// <summary>
    /// ������k
    /// </summary>
    public virtual void Attack()
    {
        // �Ұ� ��P�{��
        StartCoroutine(DelayAttack());
    }

    private IEnumerator DelayAttack()
    {
        // ����3.5�� 
        yield return new WaitForSeconds(delayAttack);
        // �����ʵe
        ani.SetTrigger(parameterAttack);
        // ���� 0.5��
        yield return new WaitForSeconds(delaySendDamage);
        // �ǰe�ˮ`
        targetHealthSystem.Hurt(attack);
        onAttackFinish.Invoke();
    }
    #endregion

}
