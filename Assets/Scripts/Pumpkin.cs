using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pumpkin : MonoBehaviour {

    #region Variables
    public float moveForce = 10f;

    private Rigidbody _myBody;
    #endregion Variables

    #region MainFunctions
    private void FixedUpdate()
    {
        // Initialization of the player movement
        MovePumpkin();
    }

    private void Awake()
    {
        _myBody = GetComponent<Rigidbody>();

    }
    #endregion MainFunctions

    #region Methods
    public void MovePumpkin() {

        // Inputs the player movement
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        _myBody.AddForce(new Vector3(h * moveForce, 0f, v * moveForce));
    }

    private void OnTriggerEnter(Collider target)
    {
        if (target.tag == "Golem") {

            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

        if (target.tag == "Gates") {

            Time.timeScale = 0f;
        }
    }
    #endregion Methods
}	// Main Class
