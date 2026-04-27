using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TelaVitoria : MonoBehaviour
{
    public void Exibir()
    {
        this.gameObject.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
    public void Esconder()
    {
        
    }
    public void TentarNovamente()
    {
        SceneManager.LoadScene("game1");

    }
    public void SairJogo()
    {
        Application.Quit();
    }
}
