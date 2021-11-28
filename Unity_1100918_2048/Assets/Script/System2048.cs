using UnityEngine;
using UnityEngine.UI;
using System.Linq;
/// <summary>
/// 2048 �t��
/// �x�s�C�Ӱ϶����
/// �޲z�H���ͦ�
/// �ưʱ���
/// �Ʀr�X�֧P�w
/// �C������P�w
/// </summary>
public class System2048 : MonoBehaviour
{
    #region ���:���}
    [Header("�ťհ϶�")]
    public Transform[] blocksEmpty;
    [Header("�Ʀr�϶�")]
    public GameObject goNumberBlock;
    [Header("�e�� 2048")]
    public Transform traCanvas2048;
    #endregion


    #region ���:�p�H
    // �p�H�����ܦb�ݩʭ��O�W
    [SerializeField]
    private Direction direction;


    /// <summary>
    /// �Ҧ��϶����
    /// </summary>
    private BlockDate[,] blocks = new BlockDate[1, 4];

    /// <summary>
    /// ���U�y��
    /// </summary>
    private Vector3 posDown;
    /// <summary>
    /// ��U�y��
    /// </summary>
    private Vector3 posUp;
    /// <summary>
    /// �O�_���U����
    /// </summary>    
    private bool isClickMouse;

    #endregion

    #region �ƥ�
    private void Start()
    {
        Initialize();
    }

    private void Update()
    {
        CheckDirection();
    }
    #endregion

    #region ��k:�p�H
    /// <summary>
    /// ��l�Ƹ��
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
    /// ��X�϶��G���}�C���
    /// </summary>
    private void PrintBlockData()
    {
        string result = "";

        for (int i = 0; i < blocks.GetLength(0); i++)
        {
            for (int j = 0; j < blocks.GetLength(1); j++)
            {
                //�s�� �Ʀr�P�y��
                //  result += "�s��(" + blocks[i, j].v2Index + ")" + " <color=red>�Ʀr:" + blocks[i, j].number + "</color> | " + blocks[i, j].v2Position + " | ";
                // �s�� �Ʀr�P����
                result += "�s��(" + blocks[i, j].v2Index + ")" + " <color=red>�Ʀr:" + blocks[i, j].number + "</color> <color=yellow> " + (blocks[i, j].goBlock ? "��" : "�@") + "</color> | ";
            }

            result += "\n";
        }

        print(result);
    }


    /// <summary>
    /// �إ��H���Ʀr�϶�
    /// �P�_�Ҧ��϶����S���Ʀr���϶� - �Ʀr���s
    /// �H���D��@��
    /// �ͦ��Ʀr���Ӱ϶���
    /// </summary>
    private void CreateRandomNumberBlock()
    {
        var equalZero =
            from BlockDate data in blocks
            where data.number == 0
            select data;

        print("���s����Ʀ��X��:" + equalZero.Count());

        int randomIndex = Random.Range(0, equalZero.Count());
        print("�H���s��:" + randomIndex);

        BlockDate dataRandom = blocks[equalZero.ToArray()[randomIndex].v2Index.x, equalZero.ToArray()[randomIndex].v2Index.y];
        dataRandom.number = 2;



        // ��Ҥ� �ͦ� (���� ������)
        GameObject tempBlock = Instantiate(goNumberBlock, traCanvas2048);
        // �ͦ��϶� ���w�y��
        tempBlock.transform.position = dataRandom.v2Position;
        // �x�s �ͦ��϶� ���
        dataRandom.goBlock = tempBlock;

        PrintBlockData();
    }

    /// <summary>
    /// �ˬd��V
    /// </summary>
    private void CheckDirection()
    {
        #region ��L
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

        #region �ƹ��PĲ��
        if (!isClickMouse && Input.GetKeyDown(KeyCode.Mouse0))
        {
            isClickMouse = true;
            posDown = Input.mousePosition;
            print("���U�y��:" + posDown);

        }
        else if (isClickMouse && Input.GetKeyDown(KeyCode.Mouse0))
        {
            isClickMouse = false;
            posUp = Input.mousePosition;
            print("��}�y��:" + posUp);

            // 1. �p��V�q�� ��}�y�� - �פU�y��
            Vector3 directionValue = posUp - posDown;
            //print("�V�q��: " + directionValue);
            // 2. �ഫ�� 0~1 ��
            //print("�ഫ���:" + directionValue.normalized);

            // ��V X �P Y �������
            float xAbs = Mathf.Abs(directionValue.normalized.x);
            float yAbs = Mathf.Abs(directionValue.normalized.y);
            // X > Y ������V
            if (xAbs > yAbs)
            {
                if (directionValue.normalized.x > 0) direction = Direction.Right;
                else direction = Direction.Left;
                CheckAndMoveBlock();

            }
            // Y > X ������V
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
    /// �ˬd�ò��ʰ϶�
    /// </summary>
    private void CheckAndMoveBlock()
    {
        print("�ثe����V: " + direction);

        switch (direction)
        {
            case Direction.Right:
                break;
            case Direction.Left:
                for(int i = 0; i < blocks.GetLength(0); i++)
                {
                    for (int j = 0; j < blocks.GetLength(1); j++)
                    {
                        BlockDate blockOriginal = new BlockDate();    // ��l���Ʀr���϶�
                        BlockDate blockCheck = new BlockDate();       // �ˬd���䪺�϶�
                        bool canMove = false;                         // �O�_�i�H���ʰ϶�
                        bool sameNumber = false;
                        blockOriginal = blocks[i, j];
                        // �p�G �Ӱ϶����Ʀr ���s �N �~��  (���L���j�����U�Ӱj��)
                        if (blocks[i, j].number == 0) continue;

                        for (int k = j - 1; k >= 0; k--)
                        {
                            print("�ˬd����:" + k);

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
                        // �N�쥻�����󲾰ʨ��ˬd�Ʀr���s���϶���m
                        // �N�쥻�Ʀr�k�s �ˬd�Ʀr�ɤW
                        // �N�쥻������M�� �ˬd����ɤW
                        blockOriginal.goBlock.transform.position = blockCheck.v2Position;
                        

                            if (sameNumber)
                            {
                                int number = blockCheck.number * 2;
                                blockCheck.number = number;

                                Destroy(blockOriginal.goBlock);
                                blockCheck.goBlock.transform.Find("�Ʀr").GetComponent<Text>().text = number.ToString();
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
/// �϶����
/// �C�Ӱ϶��C������@�y�С@�s���@�Ʀr
/// </summary>
public class BlockDate
{
    /// <summary>
    /// �϶������Ʀr����
    /// </summary>
    public GameObject goBlock;
    /// <summary>
    /// �϶��y��
    /// </summary>
    public Vector2 v2Position;
    /// <summary>
    /// �϶��s��:�G���}�C�����s��
    /// </summary>
    public Vector2Int v2Index;
    /// <summary>
    /// �϶��Ʀr: �w�]�� 0 �Ϊ� 2 4 8 .... 2048
    /// </summary>
    public int number;
}

/// <summary>
/// ��V�C�|:�L �� �� �W �U
/// </summary>
public enum Direction
{
    None, Right, Left, Up, Down
}

