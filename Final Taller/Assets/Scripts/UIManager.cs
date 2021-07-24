using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI textContadorSanidad;
    [SerializeField] private TextMeshProUGUI textContadorAnimo;
    [SerializeField] private TextMeshProUGUI textContadorOcupacion;
    [SerializeField] private TextMeshProUGUI textContadorPresupuesto;

    private int ContadorSanidad;
    private int ContadorAnimo;
    private int ContadorOcupacion;
    private int ContadorPresupuesto;

    [SerializeField] private GameObject elementosDescripcion;
    // Start is called before the first frame update
    void Start()
    {
        ActualizarAnimo(60);
        ActualizarOcupacion(25);
        ActualizarPresupuesto(75);
        ActualizarSanidad(80);
    }
    

    public void ActualizarSanidad(int cantidad)
    {
        ContadorSanidad = cantidad;
        textContadorSanidad.text = ContadorSanidad.ToString();
    }
    
    public void ActualizarOcupacion(int cantidad)
    {
        ContadorOcupacion = cantidad;
        textContadorOcupacion.text = ContadorOcupacion.ToString();
    }
    
    public void ActualizarAnimo(int cantidad)
    {
        ContadorAnimo = cantidad;
        textContadorAnimo.text = ContadorAnimo.ToString();
    }
    
    public void ActualizarPresupuesto(int cantidad)
    {
        ContadorPresupuesto = cantidad;
        textContadorPresupuesto.text = ContadorPresupuesto.ToString();
    }
}
