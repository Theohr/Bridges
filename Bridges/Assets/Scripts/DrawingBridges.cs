using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class DrawingBridges : MonoBehaviour
{
    // Create an if statement for each position between the islands
    // If the person clicks between the islands 
    // Then a bridge is drawn between the islands with specific coordinates 
    // If pressed again 2 bridges are drawn 
    // If pressed 3rd time then bridges are removed

    // line renderer component
    private LineRenderer line;
    // mouse position
    private Vector3 mousePos;
    // assign material to the line renderer
    public Material material;
    // lines drawn
    private int currLines = 0;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (line == null)
            {
                createLine();
            }

            mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePos.z = 0;
            line.SetPosition(0, mousePos);
            line.SetPosition(1, mousePos);
        }
        else if (Input.GetMouseButtonUp(0) && line)
        {
            mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePos.z = 0;
            line.SetPosition(1, mousePos);
            line = null;
            currLines++;
        }
        else if (Input.GetMouseButton(0) && line)
        {
            mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePos.z = 0;
            line.SetPosition(1, mousePos);
        }
    }

    void createLine()
    {
        // new line object
        line = new GameObject("Line" + currLines).AddComponent<LineRenderer>();
        // assign material
        line.material = material;
        line.material.color = Color.black;
        // 2 end points of the line
        line.positionCount = 2;
        // start width
        line.startWidth = 0.10f;
        // end width
        line.endWidth = 0.10f;
        line.useWorldSpace = false;
        line.numCapVertices = 50;
    }
}
