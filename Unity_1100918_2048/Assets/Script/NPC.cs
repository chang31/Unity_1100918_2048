using System;
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
    /// <summary>
    /// 開啟商店
    /// </summary>
    /// <param name="e"></param>
    /// <returns></returns>
    public bool Shop(bool e)
    {
        return e;
    }

    /// <summary>
    /// 購買道具
    /// </summary>
    /// <param name="e"></param>
    /// <returns></returns>
    public int PurchaseProps(int e = 100)
    {
        return e;
    }

    /// <summary>
    /// 第幾個任務
    /// </summary>
    public int TaskNumber = 1;
    /// <summary>
    /// 任務前置編號
    /// </summary>
    public string GetTask = ""; // 取得任務
    /// <summary>
    /// 任務編號
    /// </summary>
    /// <param name="TaskNo"></param>
    public void TaskAction(int TaskNo)
    {
        TaskNumber = TaskNo;
        GetTask = "TS" + Convert.ToString(TaskNo);
        print($"任務編號:{GetTask}");
    }

    /// <summary>
    /// 任務更新
    /// </summary>
    /// <returns></returns>
    private int TaskUpdate()
    {
        return 0;
    } // 任務更新
    /// <summary>
    /// 完成任務
    /// </summary>
    /// <returns></returns>
    private bool MissionAccomplished()
    {
        return false;
    }






}
