using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicaPies : MonoBehaviour
{
    public LogicaPersona1 logicaPersona1;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerStay(Collider other)
    {
        logicaPersona1.puedoSaltar = true;
    }

    private void OnTriggerExit(Collider other)
    {
        logicaPersona1.puedoSaltar = false;
    }
}
