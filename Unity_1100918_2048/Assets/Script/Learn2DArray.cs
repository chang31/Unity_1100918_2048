using UnityEngine;
using System.Linq; // LinQ Query 查詢語言 - 資料查詢

/// <summary>
/// 認識二維陣列
/// </summary>
public class Learn2DArray : MonoBehaviour
{
    // 一維陣列
    public int[] numbers = { 1, 3, 6, 8, 9 };
    // 二維陣列
    public int[,] bloscks = { { 6, 9 }, { 7, 8 } };

    public string[,] objects = new string[4, 6];

    public int[,] scores = { { 10, 30 }, { 66, 88 }, { 9, 89 } };

    private void Start()
    {
        #region 存取
        // 一維陣列存取
        numbers[4] = 99;
        print("一維陣列第五筆資料:" + numbers[4]);

        // 二維陣列存取
        print("二維陣列第二列第一欄1,0:" + bloscks[1, 0]);
        bloscks[1, 0] = 6;
        print("二維陣列第二列第一欄1,0:" + bloscks[1, 0]);

        print("二維陣列第一維度長度:" + scores.GetLength(0));
        print("二維陣列第二維度長度:" + scores.GetLength(1));

        string result = "";

        for (int i = 0; i < scores.GetLength(0); i++)
        {
            for (int J = 0; J <scores.GetLength(1); J++)
            {
                result += scores[i, J] + " | ";

            }

            result += "\n";
        }

        print(result);
        #endregion

        #region 資料搜尋

        // 搜尋 numbers 一維陣列內大於等於10的資料
        // var 無類型資料型態
        // from 資料A in 陣列       - 從陣列搜尋資料並保存為 資料A
        // where 資料A 條件         - 判斷 資料A 是否符合條件
        // select 資料A;            - 選取 符合條件的 資料A
        var numberGratherTen =
            from int n in numbers
            where n >= 10
            select n;

        print("符合 >= 10 資料有幾筆:" + numberGratherTen.Count());
        for (int i = 0; i < numberGratherTen.Count(); i++)
        {
            print(">= 10 的資料為:" + numberGratherTen.ToArray()[i]);
        }

        // scores 不及格的分數有哪些
        var noPass =
            from int no in scores
            where no < 60
            select no;

        for (int i = 0; i < noPass.Count(); i++)
        {
            print("不及格的分數:" + noPass.ToArray()[i]);
        }
        #endregion
    }
}
