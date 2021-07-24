using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu (menuName = "ObjetoTexto")]
public class PlantillaTextos : ScriptableObject
{
    [TextArea (3,15)]
    public string textNarrativo;

    [Space(20)] 
    public string eleccionUno;
    public string eleccionDos;
    [Space(20)] 
    [Header("Eleccion uno")]
    public int efectoSalubridad1;
    public int efectoAnimo1;
    public int efectoOcupacion1;
    public int efectoPresupuesto1;
    
    [Space(20)] 
    [Header("Eleccion dos")]
    public int efectoSalubridad2;
    public int efectoAnimo2;
    public int efectoOcupacion2;
    public int efectoPresupuesto2;
    
    [Space(20)] 
    public int[] referencias = new int[2];

    public bool final;
}
