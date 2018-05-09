using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floor_Button : Maze {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {

            RaycastHit clicked;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            bool isContained = false;

            if (Physics.Raycast(ray, out clicked, 100.0f))
            {
                GameObject tempFloor = clicked.transform.gameObject;

                foreach (Cell cell in allNodes)
                {
                    if (cell.cellFloor == tempFloor) isContained = true;
                }
                if (clicked.transform && isContained)
                {
                    clicked.transform.gameObject.GetComponent<Renderer>().material.color = Color.red;
                }
            }
        }
    }
}
