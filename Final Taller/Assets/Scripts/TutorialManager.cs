using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TutorialManager : MonoBehaviour
{
    [SerializeField] private Image imagen;
    [SerializeField] private Sprite imagen1, imagen2, imagen3;
    private int contador = 0;

    public void SiguienteImagen()
    {
        contador++;
        if (contador == 1)
            imagen.sprite = imagen2;
        if (contador == 2)
            imagen.sprite = imagen3;
        if (contador == 3)
            SceneManager.LoadScene("Game");
    }

}
