using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Assertions;
using UnityEngine.UI;

public class LivesGUI : MonoBehaviour
{
    public TMP_Text _texto;
    private static LivesGUI _instance;

    public static LivesGUI Instance {
        get {
            return _instance;
        }
    }
    
    // Start is called before the first frame update
    void Awake()
    {
        if (_instance == null) {
            _instance = this;
        } else {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        Assert.IsNotNull(_texto, "TEXTO NO PUEDE SER NULO");
        _texto.text = "Lives: 3";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
