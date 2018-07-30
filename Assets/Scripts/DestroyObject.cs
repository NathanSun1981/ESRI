using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour {

    // Use this for initialization
    public void OnSelect()
    {
        Destroy(transform.parent.gameObject.transform.parent.gameObject);
    }

}
