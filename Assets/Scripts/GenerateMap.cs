using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateMap : MonoBehaviour {

    public Maps buttonPrefab;
    private Maps buttonObject;

    public void OnSelect()
    {
        buttonObject = Instantiate(buttonPrefab, gameObject.transform.position + new Vector3(0, -0.2f, 0), Quaternion.Euler(0, -90, 0)) as Maps;
    }
}
