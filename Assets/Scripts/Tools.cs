using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tools : MonoBehaviour
{
    public static int coinCount = 0;

    public GameObject objPuntos;
    public float puntosQueda;

    private void Start()
    {
        Tools.coinCount = Tools.coinCount + 1;
        Debug.Log("Empieza el juego" + Tools.coinCount + "tools");
    }
    private void OnTriggerEnter(Collider otherCollider)
    {
        if (otherCollider.CompareTag("Player") == true)
        {
            objPuntos.GetComponent<Points>().puntos += puntosQueda;
        }
        Tools.coinCount--;
        Debug.Log("recogida de moneda" + Tools.coinCount + "tools");

        if (Tools.coinCount == 0)
        {
            Debug.Log("Pasar al siguiente Nivel");
        }
        Destroy(gameObject);
    }
}
