using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateBuildings : MonoBehaviour {


    public  Buildings buttonPrefab;
    private Buildings buttonObject;

    public void OnSelect()
    {
        buttonObject = Instantiate(buttonPrefab, gameObject.transform.position + new Vector3(0.2f, 0, 0), Quaternion.Euler(0, -90, 0)) as Buildings;
        /*
        GameObject[] tag = GameObject.FindGameObjectsWithTag("GameController");
        for (int i = 0; i < tag.Length; i++)
        {
            buttonObject.BuildingsID = tag[i].GetComponent<SpaceCollectionManager>().buildingNum;
            tag[i].GetComponent<SpaceCollectionManager>().buildingNum += 1;
        }
        */

    }
}
