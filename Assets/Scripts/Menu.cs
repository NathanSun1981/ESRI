using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{

    public ButtonMenu buttonPrefab;
    private ButtonMenu buttonObject;


    public void OnSelect()
    {
        buttonObject = Instantiate(buttonPrefab, gameObject.transform.position + new Vector3(0.2f, 0, 0), Quaternion.Euler(0, -90, 0)) as ButtonMenu;
    }
}
