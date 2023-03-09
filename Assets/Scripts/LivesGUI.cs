using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Assertions;

public class LivesGUI : MonoBehaviour
{
    public TMP_Text _texto.text;
    
    // Start is called before the first frame update
    void Awake()
    {

    }

    void Start()
    {
        Assert.IsNotNull(_texto, "TEXTO NO PUEDE SER NULO");
        _texto.text = "Hola a todos";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
