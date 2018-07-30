using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.WSA;

public class FixPosition : MonoBehaviour {

    // Use this for initialization
    GameObject[] gameObjects;

    public void OnSelect()
    {

        gameObjects = GameObject.FindGameObjectsWithTag("Map");

        for (var i = 0; i < gameObjects.Length; i++)
        {
            WorldAnchor anchor = gameObject.AddComponent<WorldAnchor>();
        }
        
    }
}
