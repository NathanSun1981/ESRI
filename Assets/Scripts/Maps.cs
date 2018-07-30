using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Academy.HoloToolkit.Unity;

public class Maps : MonoBehaviour {

    public ButtonMenu buttonPrefab;
    private ButtonMenu buttonObject;

    public float RotationSensitivity = 25.0f;

    private float rotationFactorY;

    public void OnHold()
    {
        buttonObject = Instantiate(buttonPrefab, gameObject.transform.position + new Vector3(0, 0.3f, 0), Quaternion.Euler(0, -90, 0)) as ButtonMenu;
    }

    // Use this for initialization  
    void PerformManipulationStart()
    {

    }

    void PerformManipulationUpdate(Vector3 position)
    {
        if (GestureManager.Instance.IsManipulating)
        {
            try
            {
                if (GazeManager.Instance.HitInfo.collider.gameObject.tag == "Rotate")
                {   //绕Y轴进行旋转
                    rotationFactorY = GestureManager.Instance.ManipulationPosition.x * RotationSensitivity;
                    transform.Rotate(new Vector3(0, rotationFactorY, 0));

                }
            }
            catch
            {

            }
        }
    }

}
