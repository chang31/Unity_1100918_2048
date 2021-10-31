using UnityEngine;

public class Monster : MonoBehaviour
{
    // 1.整數 int 預設 0
    // 2.浮點數 有小數點 float 預設 0
    // 3.字串 文字資訊 string 預設 空
    // 4.布林值 是與否 true or false (預設 false) bool

    // Moving speed 移動速度
    // Attack power 攻擊力
    // Blood volume 血量
    // Tracking range 追蹤範圍
    // Tracking displacement (three-dimensional vector) 追蹤位移(三維向量)
    // 掉落道具 (GameObject)
    // Probability of dropping items 掉落道具機率
    // Drop item sound effects 掉落道具音效
    // Injured sound 受傷音效
    // Attack sound 攻擊音效

    [Header("移動速度")]
    [Tooltip("移動速度,範圍是0～10"), Range(0, 10)]
    public float ms = 3.5f;
    [Tooltip("攻擊力,範圍是0～500"), Range(0, 500)]
    public float ap = 100f;
    [Tooltip("血量,範圍是0～5000"), Range(0, 5000)]
    public float bv = 350f;
    [Tooltip("追蹤範圍,範圍是0～50"), Range(0, 50)]
    public float tr = 30f;

    
    public string td = "追蹤位移";
    public Vector3 v3Custom = new Vector3(1, 2, 3);

    [Header("掉落道具")]
    public bool go = false;
    [Header("掉落道具機率")]  [Range(0, 1)]
    public int podi = 1;
    [Header("掉落道具音效")]
    public bool dise = false;
    [Header("受傷音效")]
    public bool ins = false;
    [Header("攻擊音效")]
    public bool ats = false;


    private void Start()
    {
        print("移動速度:" + ms);
        print("攻擊力:" + ap);
        print("血量:" + bv);
        print("追蹤範圍:" + tr);

    }
}
