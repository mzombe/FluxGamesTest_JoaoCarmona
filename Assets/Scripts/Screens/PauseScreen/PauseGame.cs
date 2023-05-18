using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseGame : MonoBehaviour
{
    [SerializeField] private Button _btnResume; 
    [SerializeField] private Button _btnQuit; 
    [SerializeField] private GameObject _screen;

    private void Start() {
        _btnResume.onClick.AddListener(Resume);
        _btnQuit.onClick.AddListener(Quit);
    }

    private void Update() {
        if(Input.GetKeyDown(KeyCode.Escape)){
           if(!_screen.activeSelf) Pause();
        }
    }

    private void Pause(){
        LeanTween.moveLocalX(_screen, 700, 1f);
        _screen.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
    }

    private void Resume(){
        LeanTween.moveLocalX(_screen, 1350, 1f).setOnComplete(() => {
            _screen.SetActive(false);
        });
        
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void Quit(){
        Application.Quit();
    }

}
