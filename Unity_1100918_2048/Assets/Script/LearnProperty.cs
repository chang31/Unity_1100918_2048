using UnityEngine;

public class LearnProperty : MonoBehaviour
{
    // 欄位 
    public int passwordField = 123456789;

    // 屬性
    // 語法:
    // 修飾詞 資料屬性 屬性名稱 { 存取子 }
    public int passwordProperty { get; set; }
    // get取得 set存放
    // 唯讀屬性 只能取得
    // 黏巴達 => 
    public int myPasswordProperty { get => 6869; }
    //唯讀完整寫法
    // get 需使用關鍵字 return 傳回
    public string nameCharacter
    {
        get
        {
            print("我在屬性 name Character 裡面~");
            return "Chang";
        }
    }
    // 唯寫完整寫法
    // set 可以使用關鍵字 value 輸入值
    public float Attack
    {
        set
        {
            print("攻擊力:" + value);
        }
    }

    //開始事件 start 播放時執行一次
    private void Start()
    {
        // Set 存放屬性資料
        // 語法:
        // 屬性名稱 指定 值
        passwordProperty = 666;
        // Get 取得屬性資料
        // 語法:
        // 屬性名稱
        print("屬性密碼" + passwordProperty);

        // myPasswordProperty = 999 // 不能設定唯讀
        print("我的屬性密碼:" + myPasswordProperty);

        print(nameCharacter);

        // print(attack);  // 不能取得唯寫
        Attack = 99.9f;
    }
    
}