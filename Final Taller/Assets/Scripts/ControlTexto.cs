using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ControlTexto : MonoBehaviour
{
    [SerializeField] private PlantillaTextos plantilla;
    [SerializeField] private PlantillaTextos[] arrayPlantilla;

    [SerializeField] private TextMeshProUGUI textoSituacion;
    [SerializeField] private TextMeshProUGUI textoEleccionUno;
    [SerializeField] private TextMeshProUGUI textoEleccionDos;
    [SerializeField] private TextMeshProUGUI textoFinal;

    [SerializeField] private GameManager _gameManager;
    private UIManager _uiManager;
    
    // Start is called before the first frame update
    void Start()
    {
        _uiManager = GetComponent<UIManager>();
        plantilla = arrayPlantilla[0];
        PrepararTextos();
    }
    
    void PrepararTextos()
    {
        if (!plantilla.final)
        {
            textoSituacion.text = plantilla.textNarrativo;
            textoEleccionUno.text = plantilla.eleccionUno;
            textoEleccionDos.text = plantilla.eleccionDos;
        }
        else
        {
            textoFinal.text = plantilla.textNarrativo;
        }

    }

    public void ControlBotones(int indice)
    {
        if (!arrayPlantilla[plantilla.referencias[indice]].final)
        {
            AplicarEfectos(indice);
            plantilla = arrayPlantilla[plantilla.referencias[indice]];
        }
        else
        {
            plantilla = arrayPlantilla[plantilla.referencias[indice]];
            _gameManager.Final();
        }
        PrepararTextos();
    }

    public void AplicarEfectos(int decision)
    {
        if (decision == 0)
        {
            if(plantilla.efectoAnimo1 != 0)
                _uiManager.ActualizarAnimo(plantilla.efectoAnimo1);
            if(plantilla.efectoOcupacion1 != 0)
                _uiManager.ActualizarOcupacion(plantilla.efectoOcupacion1);
            if(plantilla.efectoPresupuesto1 != 0)
                _uiManager.ActualizarPresupuesto(plantilla.efectoPresupuesto1);
            if(plantilla.efectoSalubridad1 != 0)
                _uiManager.ActualizarSanidad(plantilla.efectoSalubridad1);
        }else if (decision == 1)
        {
            if (plantilla.efectoAnimo2 != 0)
                _uiManager.ActualizarAnimo(plantilla.efectoAnimo2);
            if(plantilla.efectoOcupacion2 != 0)
                _uiManager.ActualizarOcupacion(plantilla.efectoOcupacion2);
            if(plantilla.efectoPresupuesto2 != 0)
                _uiManager.ActualizarPresupuesto(plantilla.efectoPresupuesto2);
            if(plantilla.efectoSalubridad2 != 0)
                _uiManager.ActualizarSanidad(plantilla.efectoSalubridad2);
        }
    }
}
