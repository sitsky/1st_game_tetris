using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Line_Filled : MonoBehaviour {

    private List<GameObject> touching = new List<GameObject>();
    

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter2D(Collider2D coll)
    {
        Debug.Log("levels coll:" + coll.gameObject.name);
        touching.Add(coll.gameObject);
        if (touching.Count >= 4)
        {
            Remove_and_Drop();
        }
    }

    void OnTriggerExit2D(Collider2D coll)
    {

        Block_Behavior thissparent = coll.transform.parent.GetComponent<Block_Behavior>();
        Debug.Log("Exit levels coll:" + coll.gameObject.name + "   " + thissparent.controlls_enabled);

        if (thissparent.controlls_enabled)
        {
            Debug.Log("Exit levels coll:" + coll.gameObject.name + "   " + thissparent.controlls_enabled);
            touching.Remove(coll.gameObject);
        }
    }

    void Remove_and_Drop()
    {
        for (int i = 0; i < touching.Count; i++)
        {
            Destroy(touching[i]);
        }
        /*
        GameObject[] Blocks_to_move_down = GameObject.FindGameObjectsWithTag("Block");
        foreach(GameObject i in Blocks_to_move_down)
        {
            if(i.transform.position.y > transform.position.y)
            {
                i.transform.Translate(0, -0.4f, 0, Space.World);
            }
        }
        touching.Clear();*/
    }
}
