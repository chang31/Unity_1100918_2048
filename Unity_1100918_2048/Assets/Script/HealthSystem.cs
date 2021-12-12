using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// 血量系統
/// 管理血量 受傷與死亡
/// </summary>
public class HealthSystem : MonoBehaviour
{
    [Header("血量"), Range(0, 500)]
    public float hp = 100;
    [Header("要控制的血量與血條")]
    public Text textHp;
    public Image imgHp;
    [Header("造成傷害的物件標籤")]
    public string tagDamageObject;

    private float hpMax;

    // 喚醒事件 : 在Start 之前執行一次 處理初始值
    private void Awake()
    {
        hpMax = hp;
    }

    /// <summary>
    /// 受傷
    /// </summary>
    /// <param name="damege"></param>
    public void Hurt(float damege)
    {
        hp -= damege;
        textHp.text = "HP" + hp;
        imgHp.fillAmount = hp / hpMax;
    }
}
