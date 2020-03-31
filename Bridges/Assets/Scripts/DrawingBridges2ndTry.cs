using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class DrawingBridges2ndTry : MonoBehaviour
{
    public GameObject islandOne;          // Reference to the first GameObject
    public GameObject islandTwo;          // Reference to the second GameObject
    public GameObject islandThree;          // Reference to the second GameObject
    public GameObject islandFour;          // Reference to the first GameObject
    public GameObject islandFive;          // Reference to the second GameObject
    public GameObject islandSix;          // Reference to the second GameObject

    private LineRenderer line;                           // Line Renderer
    private LineRenderer line2;                           // Line Renderer
    private LineRenderer line3;                           // Line Renderer
    private LineRenderer line4;                           // Line Renderer
    private LineRenderer line5;                           // Line Renderer
    private LineRenderer line6;                           // Line Renderer

    // assign material to the line renderer
    public Material material;

    // lines drawn
    private int currLines = 0;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos = Input.mousePosition;

            //////
            // ISLAND 1 TO ISLAND 2 COORDINATES
            //////
            if (mousePos.x < 185 && mousePos.x > 160)
            {
                if (mousePos.y > 219 && mousePos.y < 312)
                {
                    Debug.Log("Left mouse button pressed");

                    Debug.Log(mousePos.x);
                    Debug.Log(mousePos.y);

                    if (line == null)
                    {
                        createLine();

                        // Update position of the two vertex of the Line Renderer
                        line.SetPosition(0, islandOne.transform.position);
                        line.SetPosition(1, islandTwo.transform.position);

                        currLines++;

                        Debug.Log(currLines);
                    }
                    else
                    {
                        Destroy(line);
                        currLines--;
                    }
                }
            }

            //////
            // ISLAND 1 TO ISLAND 3 COORDINATES
            //////
            if (mousePos.x > 192 && mousePos.x < 340)
            {
                if (mousePos.y > 315 && mousePos.y < 340)
                {
                    Debug.Log("Left mouse button pressed");

                    Debug.Log(mousePos.x);
                    Debug.Log(mousePos.y);

                    if (line2 == null)
                    {
                        createLine2();

                        // Update position of the two vertex of the Line Renderer
                        line2.SetPosition(0, islandOne.transform.position);
                        line2.SetPosition(1, islandThree.transform.position);

                        currLines++;
                    }
                    else
                    {
                        Destroy(line2);
                        currLines--;
                    }
                }
            }

            //////
            // ISLAND 3 TO ISLAND 4 COORDINATES
            //////
            if (mousePos.x > 340 && mousePos.x < 365)
            {
                if (mousePos.y > 215 && mousePos.y < 315)
                {
                    Debug.Log("Left mouse button pressed");

                    Debug.Log(mousePos.x);
                    Debug.Log(mousePos.y);

                    if (line3 == null)
                    {
                        createLine3();

                        // Update position of the two vertex of the Line Renderer
                        line3.SetPosition(0, islandThree.transform.position);
                        line3.SetPosition(1, islandFour.transform.position);

                        currLines++;

                        Debug.Log(currLines);
                    }
                    else
                    {
                        Destroy(line3);
                        currLines--;
                    }
                }
            }

            //////
            // ISLAND 2 TO ISLAND 4 COORDINATES
            //////
            if (mousePos.x > 192 && mousePos.x < 340)
            {
                if (mousePos.y > 185 && mousePos.y < 210)
                {
                    Debug.Log("Left mouse button pressed");

                    Debug.Log(mousePos.x);
                    Debug.Log(mousePos.y);

                    if (line4 == null)
                    {
                        createLine4();

                        // Update position of the two vertex of the Line Renderer
                        line4.SetPosition(0, islandTwo.transform.position);
                        line4.SetPosition(1, islandFour.transform.position);

                        currLines++;

                        Debug.Log(currLines);
                    }
                    else
                    {
                        Destroy(line4);
                        currLines--;
                    }
                }
            }

            //////
            // ISLAND 4 TO ISLAND 5 COORDINATES
            //////
            if (mousePos.x > 340 && mousePos.x < 365)
            {
                if (mousePos.y > 90 && mousePos.y < 182)
                {
                    Debug.Log("Left mouse button pressed");

                    Debug.Log(mousePos.x);
                    Debug.Log(mousePos.y);

                    if (line5 == null)
                    {
                        createLine5();

                        // Update position of the two vertex of the Line Renderer
                        line5.SetPosition(0, islandFour.transform.position);
                        line5.SetPosition(1, islandFive.transform.position);

                        currLines++;

                        Debug.Log(currLines);
                    }
                    else
                    {
                        Destroy(line5);
                        currLines--;
                    }
                }
            }

            //////
            // ISLAND 4 TO ISLAND 6 COORDINATES
            //////
            if (mousePos.x > 375 && mousePos.x < 515)
            {
                if (mousePos.y > 185 && mousePos.y < 210)
                {
                    Debug.Log("Left mouse button pressed");

                    Debug.Log(mousePos.x);
                    Debug.Log(mousePos.y);

                    if (line6 == null)
                    {
                        createLine6();

                        // Update position of the two vertex of the Line Renderer
                        line6.SetPosition(0, islandFour.transform.position);
                        line6.SetPosition(1, islandSix.transform.position);

                        currLines++;

                        Debug.Log(currLines);
                    }
                    else
                    {
                        Destroy(line6);
                        currLines--;
                    }
                }
            }
        }
    }

    void createLine()
    {
        // new line object
        line = new GameObject("Line" + currLines).AddComponent<LineRenderer>();
        // assign material
        line.material = material;
        line.material.color = Color.black;
        // Set the width of the Line Renderer
        line.SetWidth(0.10F, 0.10F);
        // Set the number of vertex fo the Line Renderer
        line.SetVertexCount(2);
    }

    void createLine2()
    {
        // new line object
        line2 = new GameObject("Line" + currLines).AddComponent<LineRenderer>();
        // assign material
        line2.material = material;
        line2.material.color = Color.black;
        // Set the width of the Line Renderer
        line2.SetWidth(0.10F, 0.10F);
        // Set the number of vertex fo the Line Renderer
        line2.SetVertexCount(2);
    }

    void createLine3()
    {
        // new line object
        line3 = new GameObject("Line" + currLines).AddComponent<LineRenderer>();
        // assign material
        line3.material = material;
        line3.material.color = Color.black;
        // Set the width of the Line Renderer
        line3.SetWidth(0.10F, 0.10F);
        // Set the number of vertex fo the Line Renderer
        line3.SetVertexCount(2);
    }

    void createLine4()
    {
        // new line object
        line4 = new GameObject("Line" + currLines).AddComponent<LineRenderer>();
        // assign material
        line4.material = material;
        line4.material.color = Color.black;
        // Set the width of the Line Renderer
        line4.SetWidth(0.10F, 0.10F);
        // Set the number of vertex fo the Line Renderer
        line4.SetVertexCount(2);
    }

    void createLine5()
    {
        // new line object
        line5 = new GameObject("Line" + currLines).AddComponent<LineRenderer>();
        // assign material
        line5.material = material;
        line5.material.color = Color.black;
        // Set the width of the Line Renderer
        line5.SetWidth(0.10F, 0.10F);
        // Set the number of vertex fo the Line Renderer
        line5.SetVertexCount(2);
    }

    void createLine6()
    {
        // new line object
        line6 = new GameObject("Line" + currLines).AddComponent<LineRenderer>();
        // assign material
        line6.material = material;
        line6.material.color = Color.black;
        // Set the width of the Line Renderer
        line6.SetWidth(0.10F, 0.10F);
        // Set the number of vertex fo the Line Renderer
        line6.SetVertexCount(2);
    }
}
