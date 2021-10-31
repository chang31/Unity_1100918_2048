using UnityEngine;

public class NPC : MonoBehaviour
{
    // 私人 僅限此類別存取 Uinty 不顯示 private (預設)
    // 公開 所有類別可存取 Unity 會顯示 public
    // 1.整數 int 預設 0
    // 2.浮點數 有小數點 float 預設 0
    // 3.字串 文字資訊 string 預設 空
    // 4.布林值 是與否 true or false (預設 false) bool
    private void Start()
    {
     print("商人:你要來買什麼東西呢?");
     print("任務更新:BOSS擊殺完畢");

    }
    public bool Shop = true; // 開啟商店
    public int PurchaseProps =100; // 購買道具
    public int GetTask = 01; // 取得任務
    private int TaskUpdate =1; // 任務更新
    private bool MissionAccomplished = false; //完成任務






}
