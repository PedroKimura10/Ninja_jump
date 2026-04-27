using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuPrincipal : MonoBehaviour
{
    [SerializeField] private GameObject painelMenuprincipal;

    public void Jogar()
    {
        SceneManager.LoadScene("game1");

    }
    public void SairJogo()
    {
        Application.Quit();
    }
}
