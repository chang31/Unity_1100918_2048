using UnityEngine;

/// <summary>
/// �P�_�� switch
/// </summary>
public class LearnSwitch : MonoBehaviour
{
    public string equipment;

    private void Start()
    {
        // Switch �y�k:
        // Switch (�n�P�_�����)
        // {
        //      case �� 1:
        //          �{�����e;
        //          break;
        //      case �� 2:
        //          �{�����e;
        //          break;
        //      default:         // ���Ƥ��ŦX�W�� case
        //          �{�����e;
        //          break;
        // }

        switch (equipment)
        {
            case "�M�l":
                print("�A�{�b���ۤM�l");
                break;
            case "�e�l":
                print("�A�{�b���ۤe�l");
                break;
            default:
                print("�A�������O�Z�� =.=");
                break;

        }
    }


}
