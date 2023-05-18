using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadAssetBundle : MonoBehaviour
{
    //Atribuição pelo inspector do caminho onde está o asset e qual asset irá ser instanciado como GameObject
    [SerializeField] private string _assetBundlePath; 
    [SerializeField] private string _assetName; 

    private AssetBundle _assetBundle;
    private GameObject _assetObj;
    void Start()
    {
        _assetBundle = AssetBundle.LoadFromFile(_assetBundlePath);

        if (_assetBundle == null) return;

        _assetObj = _assetBundle.LoadAsset<GameObject>(_assetName);
        Instantiate(_assetObj);
    }
}
