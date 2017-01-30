using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersistentObject : MonoBehaviour {

    public string dataString; // data som ska passas över;
    public int availibleScene;
void Awake()
    {
        //förstörsinte i nästa scen så data sparas
        DontDestroyOnLoad(this);
    }
}
