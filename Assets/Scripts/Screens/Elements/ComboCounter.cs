using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ComboCounter : MonoBehaviour
{
    [SerializeField] private ScriptableGameEvent _attackEvent;
    private TMP_Text _thisText;
    private int currentCounter;
    private CanvasGroup _canvasgroup;
    void Start(){
        _thisText = gameObject.GetComponent<TMP_Text>();
        _canvasgroup = gameObject.GetComponent<CanvasGroup>();
        LeanTween.scale(gameObject, Vector3.one * 0.75f, 0.25f).setLoopPingPong();
        LeanTween.rotateZ(gameObject, -15f ,0.5f).setLoopPingPong();
    }

    private void OnEnable() {
       _attackEvent.Subcribe(AddToCounter); 
    }

    private void OnDisable() {
        _attackEvent.Unsubcribe(AddToCounter);
    }

    private void Update() => _thisText.text = "x" + currentCounter.ToString();

    public void AddToCounter(){
        CancelInvoke("TurnInvisble");
        AudioManager.Instance.PlaySound("Punch");
        _canvasgroup.alpha = 1;
        currentCounter++;
        Invoke("TurnInvisble", 2f);
    }

    private void TurnInvisble(){
        LeanTween.alphaCanvas(_canvasgroup, 0, 0.25f).setOnComplete(() => {
            currentCounter = 0;
        });
    }

}
