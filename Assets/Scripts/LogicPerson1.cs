using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicPerson1 : MonoBehaviour
{
    public float velocidadMovimiento = 0.5f;
    public float velocidadRotacion = 200.0f;
    public float x, y;

    #region Private Fields
    [SerializeField]
    private float directionDampTime = 1f;
    private Animator anim;
    #endregion
    #region MonoBehaviour Callbacks
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();

        if (!anim)
        {
            Debug.LogError("PlayerAnimatorManager is Missing Animator Component", this);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
       
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");
        
        if (y < 0)
        {
            y = 0;
        }
        anim.SetFloat("VelX", x);
        anim.SetFloat("VelY", y);

        transform.Rotate(0, x * Time.deltaTime * velocidadRotacion, 0);
        transform.Translate(0, 0, y * Time.deltaTime * velocidadMovimiento);

        anim.SetFloat("VelX", x);
        anim.SetFloat("VelY", y);
    }

    #endregion
}
