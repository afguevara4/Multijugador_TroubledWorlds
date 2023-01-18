using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Points : MonoBehaviour
{
    public float puntos;

    public Text textPuntos;

    private void Update()
    {
        textPuntos.text = "Puntos " + puntos.ToString();
    }

}
