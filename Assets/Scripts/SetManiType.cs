using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Esri.PrototypeLab.HoloLens.Demo;

public class SetManiType : MonoBehaviour {

    public Text text;
    private GameObject[] gameObjects;
    // Use this for initialization
    public void OnSelect()
    {
        gameObjects = GameObject.FindGameObjectsWithTag("Map");
        for (int i = 0; i < gameObjects.Length; i++)
        {
            if(gameObjects[i].GetComponents<TerrainMap>() != null)
            {
                gameObjects[i].GetComponent<TerrainMap>().ManipulateType = text.text;
            }
        }
    }

}
