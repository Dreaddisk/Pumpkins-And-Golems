using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    #region Variables
    private Transform _pumkinPos;
    private float zDistance = 10f;
    private float yDistance = 4f;
    #endregion Variables

    #region MainFunctions
    private void Awake()
    {
        _pumkinPos = GameObject.Find("Pumkin").transform;
        
    }

    private void Update()
    {
        Vector3 temp = transform.position;
        temp.y = _pumkinPos.position.y + yDistance;
        temp.z = _pumkinPos.position.z - zDistance;
        transform.position = temp;

    }
    #endregion MainFunctions

    #region Methods

    #endregion Methods
}	// Main Class
