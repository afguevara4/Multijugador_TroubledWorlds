using UnityEngine;
using System.Collections;
using Photon.Pun;

namespace Com.AdrianG.BattleKnights
{
    public class PlayerAnimatorManager : MonoBehaviourPun
    {

        #region Private Fields
        [SerializeField]
        public float velocidadMovimiento = 5.0f;
        public float velocidadRotacion = 200.0f;
        public Animator animator;
        public float x, y;
        #endregion
        #region MonoBehaviour Callbacks

        void Start()
        {
            animator = GetComponent<Animator>();
            if (!animator)
            {
                Debug.LogError("PlayerAnimatorManager is Missing Animator Component", this);
            }
        }

        void Update()
        {
            if (photonView.IsMine == false && PhotonNetwork.IsConnected == true)
            {
                return;
            }
            if (!animator)
            {
                return;
            }
            x = Input.GetAxis("Horizontal");
            y = Input.GetAxis("Vertical");

            transform.Rotate(0, x * Time.deltaTime * velocidadRotacion, 0);
            transform.Translate(0, 0, y * Time.deltaTime * velocidadMovimiento);

            animator.SetFloat("VelX", x);
            animator.SetFloat("VelY", y);

        }
        #endregion

    }
}