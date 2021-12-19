using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using System.Collections; // 引用 系統 集合 API:協同程序

public class AttackSystem : MonoBehaviour
{
    /// <summary>
    /// 攻擊系統：近距離
    /// </summary>
    #region 欄位：公開
    [Header("攻擊力基底")]
    public float attack = 10;
    [Header("攻擊目標")]
    public GameObject goTarget;
    [Header("攻擊力介面")]
    public Text textAttack;
    [Header("延遲攻擊")]
    public float delayAttack = 3.5f;
    [Header("延遲傳送傷害")]
    public float delaySendDamage = 0.5f;
    [Header("動畫參數")]
    public string parameterAttack = "攻擊觸發";
    #endregion

    #region 欄位:保護 Protected
    // public 允許任何類別存取
    // private 允許此類別存取
    // protected 允許子類別存取
    protected HealthSystem targetHealthSystem;
    protected Animator ani;

    #endregion


    #region  事件
    private void Awake()
    {
        textAttack.text = "Atk" + attack;
        ani = GetComponent<Animator>();
        targetHealthSystem = goTarget.GetComponent<HealthSystem>();
    }
    #endregion

    [Header("攻擊開始事件")]
    public UnityEvent onAttackStart;
    [Header("攻擊完成事件")]
    public UnityEvent onAttackFinish;
    private bool isStop;


    /// <summary>
    /// 停止攻擊
    /// </summary>
    public void StopAttack()
    {
        isStop = true;          // 已經停止
        StopAllCoroutines();    // 停止所有協程
        enabled = false;        // 關閉腳本
    }

    #region 方法：公開
    // virtual 虛擬:允許子類別複寫
    /// <summary>
    /// 攻擊方法
    /// </summary>
    public virtual void Attack(float increase =0)
    {
        if (isStop) return;     // 如果停止就跳出

        // 啟動 協同程序
        StartCoroutine(DelayAttack());
    }

    private IEnumerator DelayAttack()
    {
        // 延遲3.5秒 
        yield return new WaitForSeconds(delayAttack);

        // 攻擊動畫
        ani.SetTrigger(parameterAttack);

        // 延遲 0.5秒
        yield return new WaitForSeconds(delaySendDamage);

        onAttackFinish.Invoke();

        // 傳送傷害
        targetHealthSystem.Hurt(attack);
        onAttackFinish.Invoke();
    }
    #endregion

}
