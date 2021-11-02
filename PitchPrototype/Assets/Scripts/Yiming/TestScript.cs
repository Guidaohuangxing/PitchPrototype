using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Tobii.Gaming;


public class TestScript : MonoBehaviour
{
    public GameObject lastFocus;
    public Vector3 targetPlace;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(TobiiAPI.GetFocusedObject() != null)
        {
            lastFocus = TobiiAPI.GetFocusedObject();
        }
        if(lastFocus != null)
        {
            targetPlace = this.transform.position;
        }
    }
}
