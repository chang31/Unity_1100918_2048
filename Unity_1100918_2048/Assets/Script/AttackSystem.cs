using UnityEngine;

public class AttackSystem : MonoBehaviour
{
    /// <summary>
    /// �����t�ΡG��Z��
    /// </summary>
        #region ���G���}
        [Header("�����O��")]
        public float attack = 10;
        [Header("�����ؼ�")]
        public GameObject goTarget;
        #endregion

        #region ��k�G���}
        // virtual ����:���\�l���O�Ƽg
        /// <summary>
        /// ������k
        /// </summary>
        public virtual void Attack()
        {
            print("�o�ʧ����A�����O���G" + attack);
        }
        #endregion
  
}
