using UnityEngine;
using UnityEngine.UI;
using System.Linq;
/// <summary>
/// 2048 系統
/// 儲存每個區塊資料
/// 管理隨機生成
/// 滑動控制
/// 數字合併判定
/// 遊戲機制判定
/// </summary>
public class System2048 : MonoBehaviour
{
    #region 欄位:公開
    [Header("空白區塊")]
    public Transform[] blocksEmpty;
    [Header("數字區塊")]
    public GameObject goNumberBlock;
    [Header("畫布 2048")]
    public Transform traCanvas2048;
    #endregion


    #region 欄位:私人
    // 私人欄位顯示在屬性面板上
    [SerializeField]
    private Direction direction;


    /// <summary>
    /// 所有區塊資料
    /// </summary>
    private BlockDate[,] blocks = new BlockDate[1, 4];

    /// <summary>
    /// 按下座標
    /// </summary>
    private Vector3 posDown;
    /// <summary>
    /// 放下座標
    /// </summary>
    private Vector3 posUp;
    /// <summary>
    /// 是否按下左鍵
    /// </summary>    
    private bool isClickMouse;

    #endregion

    #region 事件
    private void Start()
    {
        Initialize();
    }

    private void Update()
    {
        CheckDirection();
    }
    #endregion

    #region 方法:私人
    /// <summary>
    /// 初始化資料
    /// </summary>
    private void Initialize()
    {
        for (int i = 0; i < blocks.GetLongLength(0); i++)
        {
            for (int j = 0; j < blocks.GetLongLength(1); j++)
            {
                blocks[i, j] = new BlockDate();
                blocks[i, j].v2Index = new Vector2Int(i, j);
                blocks[i, j].v2Position = blocksEmpty[i * blocks.GetLength(1) + j].position;
            }
        }

        PrintBlockData();
        CreateRandomNumberBlock();
        CreateRandomNumberBlock();
    }


    /// <summary>
    /// 輸出區塊二維陣列資料
    /// </summary>
    private void PrintBlockData()
    {
        string result = "";

        for (int i = 0; i < blocks.GetLength(0); i++)
        {
            for (int j = 0; j < blocks.GetLength(1); j++)
            {
                //編號 數字與座標
                //  result += "編號(" + blocks[i, j].v2Index + ")" + " <color=red>數字:" + blocks[i, j].number + "</color> | " + blocks[i, j].v2Position + " | ";
                // 編號 數字與物件
                result += "編號(" + blocks[i, j].v2Index + ")" + " <color=red>數字:" + blocks[i, j].number + "</color> <color=yellow> " + (blocks[i, j].goBlock ? "有" : "一") + "</color> | ";
            }

            result += "\n";
        }

        print(result);
    }


    /// <summary>
    /// 建立隨機數字區塊
    /// 判斷所有區塊內沒有數字的區塊 - 數字為零
    /// 隨機挑選一個
    /// 生成數字放到該區塊內
    /// </summary>
    private void CreateRandomNumberBlock()
    {
        var equalZero =
            from BlockDate data in blocks
            where data.number == 0
            select data;

        print("為零的資料有幾筆:" + equalZero.Count());

        int randomIndex = Random.Range(0, equalZero.Count());
        print("隨機編號:" + randomIndex);

        BlockDate dataRandom = blocks[equalZero.ToArray()[randomIndex].v2Index.x, equalZero.ToArray()[randomIndex].v2Index.y];
        dataRandom.number = 2;



        // 實例化 生成 (物件 父物件)
        GameObject tempBlock = Instantiate(goNumberBlock, traCanvas2048);
        // 生成區塊 指定座標
        tempBlock.transform.position = dataRandom.v2Position;
        // 儲存 生成區塊 資料
        dataRandom.goBlock = tempBlock;

        PrintBlockData();
    }

    /// <summary>
    /// 檢查方向
    /// </summary>
    private void CheckDirection()
    {
        #region 鍵盤
        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
        {
            direction = Direction.Up;
            CheckAndMoveBlock();
        }
        if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow))
        {
            direction = Direction.Down;
            CheckAndMoveBlock();
        }
        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            direction = Direction.Left;
            CheckAndMoveBlock();
        }
        if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            direction = Direction.Right;
            CheckAndMoveBlock();
        }
        #endregion

        #region 滑鼠與觸控
        if (!isClickMouse && Input.GetKeyDown(KeyCode.Mouse0))
        {
            isClickMouse = true;
            posDown = Input.mousePosition;
            print("按下座標:" + posDown);

        }
        else if (isClickMouse && Input.GetKeyDown(KeyCode.Mouse0))
        {
            isClickMouse = false;
            posUp = Input.mousePosition;
            print("放開座標:" + posUp);

            // 1. 計算向量值 放開座標 - 案下座標
            Vector3 directionValue = posUp - posDown;
            //print("向量值: " + directionValue);
            // 2. 轉換成 0~1 值
            //print("轉換後值:" + directionValue.normalized);

            // 方向 X 與 Y 取絕對值
            float xAbs = Mathf.Abs(directionValue.normalized.x);
            float yAbs = Mathf.Abs(directionValue.normalized.y);
            // X > Y 水平方向
            if (xAbs > yAbs)
            {
                if (directionValue.normalized.x > 0) direction = Direction.Right;
                else direction = Direction.Left;
                CheckAndMoveBlock();

            }
            // Y > X 垂直方向
            else if (yAbs > xAbs)
            {
                if (directionValue.normalized.y > 0) direction = Direction.Up;
                else direction = Direction.Down;
                CheckAndMoveBlock();
            }
        }
        #endregion


    }

    /// <summary>
    /// 檢查並移動區塊
    /// </summary>
    private void CheckAndMoveBlock()
    {
        print("目前的方向: " + direction);

        switch (direction)
        {
            case Direction.Right:
                break;
            case Direction.Left:
                for(int i = 0; i < blocks.GetLength(0); i++)
                {
                    for (int j = 0; j < blocks.GetLength(1); j++)
                    {
                        BlockDate blockOriginal = new BlockDate();    // 原始有數字的區塊
                        BlockDate blockCheck = new BlockDate();       // 檢查旁邊的區塊
                        bool canMove = false;                         // 是否可以移動區塊
                        bool sameNumber = false;
                        blockOriginal = blocks[i, j];
                        // 如果 該區塊的數字 為零 就 繼續  (跳過此迴圈執行下個迴圈)
                        if (blocks[i, j].number == 0) continue;

                        for (int k = j - 1; k >= 0; k--)
                        {
                            print("檢查次數:" + k);

                            if (blocks[i, k].number == 0)
                            {
                                blockCheck = blocks[i, k];
                                canMove = true;
                            }

                            else if (blocks[i,k].number == blockOriginal.number)
                            {
                                blockCheck = blocks[i, k];
                                canMove = true;
                                sameNumber = true;
                            }
                        }

                        if (canMove)
                        {
                        // 將原本的物件移動到檢查數字為零的區塊位置
                        // 將原本數字歸零 檢查數字補上
                        // 將原本的物件清空 檢查物件補上
                        blockOriginal.goBlock.transform.position = blockCheck.v2Position;
                        

                            if (sameNumber)
                            {
                                int number = blockCheck.number * 2;
                                blockCheck.number = number;

                                Destroy(blockOriginal.goBlock);
                                blockCheck.goBlock.transform.Find("數字").GetComponent<Text>().text = number.ToString();
                            }
                            else
                            {
                                blockCheck.number = blockOriginal.number;
                                blockCheck.goBlock = blockOriginal.goBlock;
                            }

                         blockOriginal.number = 0;
                         blockOriginal.goBlock = null;


                        }
                    }
                }
                PrintBlockData();

                break;
            case Direction.Up:
                break;
            case Direction.Down:
                break;
        }
    }
    #endregion
}

/// <summary>
/// 區塊資料
/// 每個區塊遊戲物件　座標　編號　數字
/// </summary>
public class BlockDate
{
    /// <summary>
    /// 區塊內的數字物件
    /// </summary>
    public GameObject goBlock;
    /// <summary>
    /// 區塊座標
    /// </summary>
    public Vector2 v2Position;
    /// <summary>
    /// 區塊編號:二維陣列內的編號
    /// </summary>
    public Vector2Int v2Index;
    /// <summary>
    /// 區塊數字: 預設為 0 或者 2 4 8 .... 2048
    /// </summary>
    public int number;
}

/// <summary>
/// 方向列舉:無 有 左 上 下
/// </summary>
public enum Direction
{
    None, Right, Left, Up, Down
}

