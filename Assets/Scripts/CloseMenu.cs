using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseMenu : MonoBehaviour {

	// Use this for initialization

    public void OnSelect()
    {
        if (transform.parent.gameObject.tag == "ControlButton")
        {
            transform.parent.gameObject.SetActive(false);
        }
        else
        {
            Destroy(transform.parent.gameObject);
        }
        
    }
}
