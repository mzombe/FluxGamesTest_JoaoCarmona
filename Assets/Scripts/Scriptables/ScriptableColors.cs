using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableObjects/Colors To Change")]
public class ScriptableColors : ScriptableObject
{
    [SerializeField] private List<Color> currentColor = new List<Color>();

    public Color CurrentColor { //Função que retorna uma cor aleatória quando acessado
        get{
            return currentColor[Random.Range(0,currentColor.Count)];
        }
    }
}
