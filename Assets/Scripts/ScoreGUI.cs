using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Assertions;
using UnityEngine.UI;

public class ScoreGUI : MonoBehaviour
{
    public TMP_Text _texto;
    private static ScoreGUI _instance;

    public static ScoreGUI Instance {
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
        _texto.text = "Score: 0";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
