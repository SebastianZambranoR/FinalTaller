using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject objetosEleccion;
    [SerializeField] private GameObject objetosSituacion;
    [SerializeField] private GameObject objetosFinal;
    [SerializeField] private GameObject barraDeFondo;
    [SerializeField] private GameObject textos;

    private bool final;
    
    // Start is called before the first frame update
    void Start()
    {
        MostrarSituacion();
        objetosFinal.SetActive(false);
        
    }

    public void MostrarSituacion()
    {
        if (!final)
        {
            objetosEleccion.SetActive(false);
            objetosSituacion.SetActive(true);
        }
    }

    public void MostrarElecciones()
    {
        if (!final)
        {
            objetosEleccion.SetActive(true);
            objetosSituacion.SetActive(false);
        }
    }

    public void Final()
    {
        objetosEleccion.SetActive(false);
        objetosSituacion.SetActive(false);
        barraDeFondo.SetActive(false);
        textos.SetActive(false);
        objetosFinal.SetActive(true);
        final = true;
    }

    public void Restart()
    {
        SceneManager.LoadScene("Intro");
    }
}
