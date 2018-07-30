using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonZoomIn : MonoBehaviour {

	// Use this for initialization

    public void OnSelect()
    {
        Vector3 oriScale = transform.parent.gameObject.transform.parent.transform.localScale;
        Vector3 menuScale = transform.parent.gameObject.transform.localScale;
        transform.parent.gameObject.transform.parent.transform.localScale += new Vector3(0.00002f, 0.00002f, 0.00002f);

        float zoomrate = transform.parent.gameObject.transform.parent.transform.localScale.x / oriScale.x;
        //本身按钮的大小不变
        transform.parent.gameObject.transform.localScale = new Vector3(menuScale.x / zoomrate, menuScale.y / zoomrate, menuScale.z / zoomrate);

    }
}
