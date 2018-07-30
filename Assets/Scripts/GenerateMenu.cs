using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateMenu : MonoBehaviour {

    public ButtonMenu buttonPrefab;
    private ButtonMenu buttonObject;


    public void OnHold()
    {
        buttonObject = Instantiate(buttonPrefab, gameObject.transform.position + new Vector3(0, 0.3f, 0), Quaternion.Euler(0, -90, 0)) as ButtonMenu;
    }

}
