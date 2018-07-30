using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAll : MonoBehaviour {

    GameObject[] gameObjects;

    public void OnSelect()
    {

        gameObjects = GameObject.FindGameObjectsWithTag("Map");

        for (var i = 0; i < gameObjects.Length; i++)
        {
            Destroy(gameObjects[i]);
        }

        gameObjects = GameObject.FindGameObjectsWithTag("Rotate");

        for (var i = 0; i < gameObjects.Length; i++)
        {
            Destroy(gameObjects[i]);
        }
    }
}
