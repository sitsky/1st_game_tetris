using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
    Quit Game.
    Quit() runs OnClick() event of Quit Button.
 */

public class Quit_Game : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D coll)
    {
        Application.Quit();
    }
}
