using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Brick_Behavior : MonoBehaviour
{


    private bool create = true;

    public static class AppHelper
    {
#if UNITY_WEBPLAYER
     public static string webplayerQuitURL = "http://google.com";
#endif
        public static void Quit()
        {
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
#elif UNITY_WEBPLAYER
         Application.OpenURL(webplayerQuitURL);
#else
            Application.Quit();
#endif
        }
    }
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter2D(Collider2D coll)
    {
        //Debug.Log("Brick_Behavior: " + coll.ToString());
        if (!(coll.ToString().Contains("Line")))
        {
            Block_Behavior thissparent = transform.parent.GetComponent<Block_Behavior>();
            thissparent.controlls_enabled = false;
            if (!(gameObject.GetComponent<Rigidbody2D>()))
            {
                gameObject.AddComponent<Rigidbody2D>();
                gameObject.GetComponent<Rigidbody2D>().isKinematic = true;
                gameObject.GetComponent<Rigidbody2D>().useFullKinematicContacts = true;
            }
        }
        if (coll.ToString().Contains("Over"))
        {
            AppHelper.Quit();
        }
    }
}
