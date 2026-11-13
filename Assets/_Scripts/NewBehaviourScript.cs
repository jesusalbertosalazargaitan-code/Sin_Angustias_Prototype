using System.Collections;
using System.Collections.Generic;
using Unity.Profiling.LowLevel.Unsafe;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public bool a = true; // Variable para controlar si el objeto está activo o no
    public bool b = false; // Variable para controlar si el objeto es visible o no
    // Start is called before the first frame update
    void Start()
    {
        //quiero la luz se prenda y apague
    }

    // Update is called once per frame
    void Update()
    {
        
        if ( a == true && b == false)
        {
            //encender la luz 
            b = true;
        }

        if ( a == false && b == true)
        {
            //apaga luz
            a = true;
            b = false;
        }

        if ( b == true)
        {
            a = false;
        }
    
       
    }
}
