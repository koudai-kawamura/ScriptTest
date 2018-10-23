using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour {

    // Use this for initialization
    void Start(){

        for (int array = 0; array < 5; array++)
        {
            Debug.Log(array);
        }

        for (int array = 0; array >= 5; array--)
        {
            Debug.Log(array);
        }

    }


    // Update is called once per frame
    void Update() {

    }
}
