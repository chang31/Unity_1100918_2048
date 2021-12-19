using UnityEditor;
using UnityEngine;

public class AttackSystemFar : AttackSystem
{
    /// <summary>
    /// 攻擊系統：遠距離
    /// 繼承語法：子類別 : 要繼承的類別(父類別)
    /// 擁有父類別的成員：欄位、屬性、方法、事件
    /// </summary>

    [Header("生成粒子位置")]
    public Transform positionSpawn;
    [Header("攻擊粒子")]
    public GameObject goAttackParticle;
    [Header("粒子發射速度"), Range(0, 1500)]
    public float speed = 500;
    // override 複寫: 複寫父類別 virtual 成員
    public override void Attack(float increase = 0)
    {
        // base.Attack();  // base 基底:父類別的內容

        onAttackFinish.Invoke();

        // 生成(物件 物件 角度 )
        // 生成的物件名稱後方會有(Clone)
        // Quaternion 四元數
        // identity 零角度
        GameObject tempAttack = Instantiate(goAttackParticle, positionSpawn.position, Quaternion.identity);
        tempAttack.GetComponent<Rigidbody2D>().AddForce(new Vector2(speed, 0));

        tempAttack.AddComponent<Bullet>().attack = attack + increase;

        print("本次攻擊力:" + (attack + increase)); 
    }

}
