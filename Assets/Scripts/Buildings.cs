using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Academy.HoloToolkit.Unity;

public class Buildings : MonoBehaviour {

    public int BuildingsID;

    private Vector3 navigationPreviousPosition;
    public float MaxScale = 2f;
    public float MinScale = 0.1f;

    public float RotationSensitivity = 25.0f;

    private float rotationFactorY;

    public Canvas MenuControl;

    // Use this for initialization
    void Start () {

        MenuControl.gameObject.SetActive(false);

    }
	
	// Update is called once per frame
	void Update () {
		
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

    void PerformNavigationStart(Vector3 position)
    {
        //设置初始位置    
        navigationPreviousPosition = position;
    }

    void PerformZoomUpdate(Vector3 position)
    {
        if (GestureManager.Instance.IsNavigating && HandsManager.Instance.FocusedGameObject == gameObject)
        {
            Vector3 deltaScale = Vector3.zero;
            float ScaleValue = 0.01f;
            //设置每一帧缩放的大小  
            if (position.x < 0)
            {
                ScaleValue = -1 * ScaleValue;
            }
            //当缩放超出设置的最大，最小范围时直接返回  
            if (transform.localScale.x >= MaxScale && ScaleValue > 0)
            {
                return;
            }
            else if (transform.localScale.x <= MinScale && ScaleValue < 0)
            {
                return;
            }
            //根据比例计算每个方向上的缩放大小  
            deltaScale.x = ScaleValue;
            deltaScale.y = (transform.localScale.y / transform.localScale.x) * ScaleValue;
            deltaScale.z = (transform.localScale.z / transform.localScale.x) * ScaleValue;
            transform.localScale += deltaScale;
        }
    }

    void OnHold()
    {
        //if (GazeManager.Instance.HitInfo.collider.gameObject.tag == "Rotate")
        //{
            MenuControl.gameObject.SetActive(true);
        //}            
    }
}
