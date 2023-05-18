using UnityEngine;
using System;

[CreateAssetMenu(menuName = "ScriptableObjects/Game Event")]
public class ScriptableGameEvent : ScriptableObject
{
    private Action action = delegate {}; //Criar váriavel do evento em um delegate vazio
    public void Invoke() => action(); //Metodo que inicia o invoke do evento
    public void Subcribe(Action method) => action += method; //Inscrição de um metodo em um evento
    public void Unsubcribe(Action method) => action -= method; //Desinscrever de um metodo em um evento

}
