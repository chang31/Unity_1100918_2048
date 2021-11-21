using UnityEngine;
using System.Linq;
/// <summary>
/// 2048 �t��
/// �x�s�C�Ӱ϶����
/// �޲z�H���ͦ�
/// �ưʱ���
/// �Ʀr�X�֧P�w
/// �C������P�w
/// </summary>
public class System2048: MonoBehaviour
{
    [Header("�ťհ϶�")]
    public Transform[] blocksEmpty;
    [Header("�Ʀr�϶�")]
    public GameObject goNumberBlock;
    [Header("�e�� 2048")]
    public Transform traCanvas2048;


    /// <summary>
    /// �Ҧ��϶����
    /// </summary>
    public BlockDate[,] blocks = new BlockDate[4, 4];

    private void Start()
    {
        Initialize();
    }

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
                result += "�s��(" + blocks[i, j].v2Index + ")" + " <color=red>�Ʀr:" + blocks[i, j].number + "</color> <color=yellow> " + blocks[i, j].goBlock + "</color> | ";
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

        PrintBlockData();


        // ��Ҥ� �ͦ� (���� ������)
       GameObject tempBlock = Instantiate(goNumberBlock, traCanvas2048);
        // �ͦ��϶� ���w�y��
        tempBlock.transform.position = dataRandom.v2Position;
        // �x�s �ͦ��϶� ���
        dataRandom.goBlock = tempBlock;

    }

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


    /// <summary>
    /// ��V�C�|:�L �� �� �W �U
    /// </summary>
    public enum Direction
    {
        None , Right , Left , Up ,Down
    }
}
