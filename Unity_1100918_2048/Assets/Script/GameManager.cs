using UnityEngine;
using UnityEngine.UI;

/// <summary> 
/// /// 遊戲管理器 
/// /// 遊戲結束畫面控制 
/// /// 結束畫面標題更新 
/// ///</summary> 
public class GameManager : MonoBehaviour
{
    [Header("畫布結束")] 
    public GameObject goFinalCanves;
    [Header("結束標題")]
    public Text textFinalTitle;

    public void ShowFinealCanves(bool win) 
    {
        print(1);
        goFinalCanves.SetActive(true);

        // 三元運算子
        // 布林值 ? 布林值為 true : 布林值為 flase
        string title = win ? "Win" : "Lose";

        // 判斷式 if
        /*
        if (win) title = "win"
        else title = "Lose"
        */

        textFinalTitle.text = title;
    
    
    }
}
