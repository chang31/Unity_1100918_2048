using UnityEngine;
using UnityEngine.Audio; // �ޥ� ���� �R�W�Ŷ�
using UnityEngine.SceneManagement; // �ޥ� �����޲z �R�W�Ŷ�

/// <summary>
/// �}�l�e�����޲z��
/// �}�l�C�� �]�w ���}�C��
/// </summary>
public class MenuManager : MonoBehaviour
{
    // Unity ���s�P�{�����q
    // 1. ���}����k
    // 2. ���s�]�w�I���ƥ� On Click

    public AudioMixer mixer;

    /// <summary>
    /// �}�l�C��
    /// </summary> 

    public void StartGame(float delay)
    {
        // �ϥ��~�����O�������y�k
        // �~�����O���Ϊk
        // ��k�W��(�������޼�)
        // ���� delay ���I�s ��k
        Invoke("DelayStartGame" , delay);
    }

    public void DelayStartGame()
    {
        // �����޲z ���J����(�����W��)
        SceneManager.LoadScene("�C������");
        // SceneManager.LoadScene(1);
    }

    /// <summary>
    /// �]�w�C��
    /// </summary>
    public void SettingGameBGM(float volume)
    {
        mixer.SetFloat("���q BGM", volume);
    }

    /// <summary>
    /// �]�w�C��
    /// </summary>
    public void SettingGameSFX(float volume)
    {
        mixer.SetFloat("���q SFX", volume);
    }

    /// <summary>
    /// ���}�C��
    /// </summary>

    public void QuitGame(float delay)
    {

        Invoke("DelayQuitGame", delay);

    }

    public void DelayQuitGame()
    {
        // ���ε{��.���}()
        // Quit ���|�A Editor ���� �o�������� ��� PC

        Application.Quit();

        print("���}�C��");
    }
}
