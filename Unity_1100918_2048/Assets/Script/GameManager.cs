using UnityEngine;
using UnityEngine.UI;

/// <summary> 
/// /// �C���޲z�� 
/// /// �C�������e������ 
/// /// �����e�����D��s 
/// ///</summary> 
public class GameManager : MonoBehaviour
{
    [Header("�e������")] 
    public GameObject goFinalCanves;
    [Header("�������D")]
    public Text textFinalTitle;

    public void ShowFinealCanves(bool win) 
    {
        print(1);
        goFinalCanves.SetActive(true);

        // �T���B��l
        // ���L�� ? ���L�Ȭ� true : ���L�Ȭ� flase
        string title = win ? "Win" : "Lose";

        // �P�_�� if
        /*
        if (win) title = "win"
        else title = "Lose"
        */

        textFinalTitle.text = title;
    
    
    }
}
