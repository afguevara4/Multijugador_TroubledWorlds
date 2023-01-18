using System.Collections;
using System.Collections.Generic;
using Photon.Pun;
using UnityEngine;

public class LogicaPersona1 : MonoBehaviourPun
{
    public Rigidbody rb;
    public float fuerzaSalto = 8f;
    public bool puedoSaltar;

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
        puedoSaltar = false;
        animator = GetComponent<Animator>();
        
    }

    void FixedUpdate()
    {
        transform.Rotate(0, x * Time.deltaTime * velocidadRotacion, 0);
        transform.Translate(0, 0, y * Time.deltaTime * velocidadMovimiento);

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
       
        animator.SetFloat("VelX", x);
        animator.SetFloat("VelY", y);

        if (puedoSaltar)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                animator.SetBool("salte", true);
                rb.AddForce(new Vector3(0, fuerzaSalto, 0), ForceMode.Impulse);
            }
            animator.SetBool("tocoSuelo", true);
        }
        else
        {
            EstoyCayendo();
        }
    }
    #endregion

    public void EstoyCayendo()
    {
        animator.SetBool("tocoSuelo", false);
        animator.SetBool("salte", false);
    }
}
