using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeColor : MonoBehaviour
{
    [SerializeField] private Renderer _render; //Atribua a Mesh que irá mudar de cor
    [SerializeField] private ScriptableColors _colors; //Atribua o Scriptable com a List de cores
    [SerializeField] private Button _btn; //Atribua o botão que irá realizar uma ação
    private void Start() {
        InitiateChangeColor(); //Muda a cor no Start
        _btn.onClick.AddListener(ActivateRandomColor); //Atribuido via Script um metódo nos eventos do botão
    }

    private void InitiateChangeColor(){
        LeanTween.color(_render.gameObject, _colors.CurrentColor , 2f);
    }

    private void ActivateRandomColor(){
        _btn.gameObject.SetActive(false);
        LeanTween.color(_render.gameObject, _colors.CurrentColor , 1f).setLoopPingPong(); //Definido Loop na troca das cores
    }
}
