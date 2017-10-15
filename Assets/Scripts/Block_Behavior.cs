using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Block_Behavior : MonoBehaviour {

    public bool controlls_enabled = true;
    private bool create = true;
    // Use this for initialization
    void Start() {
    }

    // Update is called once per frame
    void Update() {
        if (controlls_enabled)
        {
            transform.Translate(0, -0.05f, 0, Space.World);

            if (Input.GetKeyUp(KeyCode.UpArrow))
            {
                transform.Rotate(0.0f, 0.0f, -90.0f);
            }
            if (Input.GetKeyUp(KeyCode.DownArrow))
            {
                transform.Rotate(0.0f, 0.0f, 90.0f);
            }
            if (Input.GetKeyUp(KeyCode.LeftArrow))
            {
                transform.Translate(-0.4f, 0, 0);
            }
            if (Input.GetKeyUp(KeyCode.RightArrow))
            {
                transform.Translate(0.4f, 0, 0);
            }
        }
        else
        {
            if (create)
            {
                GameObject new_piece = Instantiate(Resources.Load("Right_L"), new Vector3(0, 4f, 0), Quaternion.identity) as GameObject;
                create = false;
            }
        }
    }

}
