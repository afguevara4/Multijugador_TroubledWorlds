using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //Para la coneccion entre escenas

public class MainMenu : MonoBehaviour
{
    public void Escenajuego()
    {
        SceneManager.LoadScene("Launcher"); 
    }

    public void CargarNivel(string nombreNivel)
    {
        SceneManager.LoadScene(nombreNivel) ;
    }

    public void Salir()
    {
        Application.Quit();
    }
}
