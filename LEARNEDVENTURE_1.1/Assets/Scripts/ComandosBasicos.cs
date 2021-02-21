using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class ComandosBasicos : MonoBehaviour
{
   public void CargarEscena (string NombreDeEscena)
    {
        SceneManager.LoadSceneAsync(NombreDeEscena);
    }

    public void salir()
    {
        Application.Quit();
        Debug.Log ("has salido del juego, comparte el conocimiento");
    }
}
