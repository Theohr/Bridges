using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class DrawingBridges2ndTry : MonoBehaviour
{
    public GameObject islandOne;          // Reference to the first GameObject
    public GameObject islandTwo;          // Reference to the second GameObject
    public GameObject islandThree;          // Reference to the second GameObject
    public GameObject islandFour;          // Reference to the first GameObject
    public GameObject islandFive;          // Reference to the second GameObject
    public GameObject islandSix;          // Reference to the second GameObject

    private LineRenderer line;                            // Line Renderer 1
    private LineRenderer line2;                           // Line Renderer 2
    private LineRenderer line3;                           // Line Renderer 3
    private LineRenderer line4;                           // Line Renderer 4
    private LineRenderer line5;                           // Line Renderer 5
    private LineRenderer line6;                           // Line Renderer 6
    private LineRenderer line7;                            // Line Renderer 1
    private LineRenderer line8;                           // Line Renderer 2
    private LineRenderer line9;                           // Line Renderer 3
    private LineRenderer line10;                           // Line Renderer 4
    private LineRenderer line11;                           // Line Renderer 5
    private LineRenderer line12;                           // Line Renderer 6

    private Vector3 bridgePositionsX = new Vector3(0.1F, 0F, 0F); // offsets for the 2 bridges on x axis
    private Vector3 bridgePositionsY = new Vector3(0F, 0.1F, 0F); // offsets for the 2 bridges on the y axis

    // assign material to the line renderer
    public Material material;

    public GameObject completedMode;

    bool complete = false;

    // lines drawn 
    // counter for the solution button
    private int bridges1To2Counter = 0;
    private int bridges1To3Counter = 0;
    private int bridges3To4Counter = 0;
    private int bridges2To4Counter = 0;
    private int bridges4To5Counter = 0;
    private int bridges4To6Counter = 0;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            // get the mouse position to check if its between certain islands below
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

                    if (bridges1To2Counter == 0)
                    {
                        createLine();

                        // Update position of the two vertex of the Line Renderer
                        line.SetPosition(0, islandOne.transform.position);
                        line.SetPosition(1, islandTwo.transform.position);

                        bridges1To2Counter++;

                        Debug.Log(bridges1To2Counter);
                    }
                    else if (bridges1To2Counter == 1)
                    {
                        Destroy(line);

                        createLine();

                        // Update position of the two vertex of the Line Renderer
                        line.SetPosition(0, islandOne.transform.position - bridgePositionsX);
                        line.SetPosition(1, islandTwo.transform.position - bridgePositionsX);

                        createLine7();

                        // Update position of the two vertex of the Line Renderer
                        line7.SetPosition(0, islandOne.transform.position + bridgePositionsX);
                        line7.SetPosition(1, islandTwo.transform.position + bridgePositionsX);

                        bridges1To2Counter++;

                        Debug.Log(bridges1To2Counter);
                    }
                    else
                    {
                        Destroy(line);
                        Destroy(line7);
                        bridges1To2Counter = bridges1To2Counter - 2;
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

                    if (bridges1To3Counter == 0)
                    {
                        createLine2();

                        // Update position of the two vertex of the Line Renderer
                        line2.SetPosition(0, islandOne.transform.position);
                        line2.SetPosition(1, islandThree.transform.position);

                        bridges1To3Counter++;

                        Debug.Log(bridges1To3Counter);
                    }
                    else if (bridges1To3Counter == 1)
                    {
                        Destroy(line2);

                        bridges1To3Counter--;

                        createLine2();

                        // Update position of the two vertex of the Line Renderer
                        line2.SetPosition(0, islandOne.transform.position - bridgePositionsY);
                        line2.SetPosition(1, islandThree.transform.position - bridgePositionsY);

                        createLine8();

                        // Update position of the two vertex of the Line Renderer
                        line8.SetPosition(0, islandOne.transform.position + bridgePositionsY);
                        line8.SetPosition(1, islandThree.transform.position + bridgePositionsY);

                        bridges1To3Counter = bridges1To3Counter + 2;

                        Debug.Log(bridges1To3Counter);
                    }
                    else
                    {
                        Destroy(line2);
                        Destroy(line8);
                        bridges1To3Counter = bridges1To3Counter - 2;
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

                    if (bridges3To4Counter == 0)
                    {
                        createLine3();

                        // Update position of the two vertex of the Line Renderer
                        line3.SetPosition(0, islandThree.transform.position);
                        line3.SetPosition(1, islandFour.transform.position);

                        bridges3To4Counter++;

                        Debug.Log(bridges3To4Counter);
                    }
                    else if (bridges3To4Counter == 1)
                    {
                        Destroy(line3);

                        bridges3To4Counter--;

                        createLine3();

                        // Update position of the two vertex of the Line Renderer
                        line3.SetPosition(0, islandThree.transform.position - bridgePositionsX);
                        line3.SetPosition(1, islandFour.transform.position - bridgePositionsX);

                        createLine9();

                        // Update position of the two vertex of the Line Renderer
                        line9.SetPosition(0, islandThree.transform.position + bridgePositionsX);
                        line9.SetPosition(1, islandFour.transform.position + bridgePositionsX);

                        bridges3To4Counter = bridges3To4Counter + 2;

                        Debug.Log(bridges3To4Counter);
                    }
                    else
                    {
                        Destroy(line3);
                        Destroy(line9);
                        bridges3To4Counter = bridges3To4Counter - 2;
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

                    if (bridges2To4Counter == 0)
                    {
                        createLine4();

                        // Update position of the two vertex of the Line Renderer
                        line4.SetPosition(0, islandTwo.transform.position);
                        line4.SetPosition(1, islandFour.transform.position);

                        bridges2To4Counter++;

                        Debug.Log(bridges2To4Counter);
                    }
                    else if (bridges2To4Counter == 1)
                    {
                        Destroy(line4);

                        bridges2To4Counter--;

                        createLine4();

                        // Update position of the two vertex of the Line Renderer
                        line4.SetPosition(0, islandTwo.transform.position - bridgePositionsY);
                        line4.SetPosition(1, islandFour.transform.position - bridgePositionsY);

                        createLine10();

                        // Update position of the two vertex of the Line Renderer
                        line10.SetPosition(0, islandTwo.transform.position + bridgePositionsY);
                        line10.SetPosition(1, islandFour.transform.position + bridgePositionsY);

                        bridges2To4Counter = bridges2To4Counter + 2;

                        Debug.Log(bridges2To4Counter);
                    }
                    else
                    {
                        Destroy(line4);
                        Destroy(line10);
                        bridges2To4Counter = bridges2To4Counter - 2;
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

                    if (bridges4To5Counter == 0)
                    {
                        createLine5();

                        // Update position of the two vertex of the Line Renderer
                        line5.SetPosition(0, islandFour.transform.position);
                        line5.SetPosition(1, islandFive.transform.position);

                        bridges4To5Counter++;

                        Debug.Log(bridges4To5Counter);
                    }
                    else if (bridges4To5Counter == 1)
                    {
                        Destroy(line5);

                        bridges4To5Counter--;

                        createLine5();

                        // Update position of the two vertex of the Line Renderer
                        line5.SetPosition(0, islandFour.transform.position - bridgePositionsX);
                        line5.SetPosition(1, islandFive.transform.position - bridgePositionsX);

                        createLine11();

                        // Update position of the two vertex of the Line Renderer
                        line11.SetPosition(0, islandFour.transform.position + bridgePositionsX);
                        line11.SetPosition(1, islandFive.transform.position + bridgePositionsX);

                        bridges4To5Counter = bridges4To5Counter + 2;

                        Debug.Log(bridges4To5Counter);
                    }
                    else
                    {
                        Destroy(line5);
                        Destroy(line11);
                        bridges4To5Counter = bridges4To5Counter - 2;
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

                    if (bridges4To6Counter == 0)
                    {
                        createLine6();

                        // Update position of the two vertex of the Line Renderer
                        line6.SetPosition(0, islandFour.transform.position);
                        line6.SetPosition(1, islandSix.transform.position);

                        bridges4To6Counter++;

                        Debug.Log(bridges4To6Counter);
                    }
                    else if (bridges4To6Counter == 1)
                    {
                        Destroy(line6);

                        bridges4To6Counter--;

                        createLine6();

                        // Update position of the two vertex of the Line Renderer
                        line6.SetPosition(0, islandFour.transform.position - bridgePositionsY);
                        line6.SetPosition(1, islandSix.transform.position - bridgePositionsY);

                        createLine12();

                        // Update position of the two vertex of the Line Renderer
                        line12.SetPosition(0, islandFour.transform.position + bridgePositionsY);
                        line12.SetPosition(1, islandSix.transform.position + bridgePositionsY);

                        bridges4To6Counter = bridges4To6Counter + 2;

                        Debug.Log(bridges4To6Counter);
                    }
                    else
                    {
                        Destroy(line6);
                        Destroy(line12);
                        bridges4To6Counter = bridges4To6Counter - 2;
                    }

                }
            }
        }
     
        Complete();
    }

    void createLine()
    {
        // new line object
        line = new GameObject("Line1").AddComponent<LineRenderer>();
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
        line2 = new GameObject("Line2").AddComponent<LineRenderer>();
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
        line3 = new GameObject("Line3").AddComponent<LineRenderer>();
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
        line4 = new GameObject("Line4").AddComponent<LineRenderer>();
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
        line5 = new GameObject("Line5").AddComponent<LineRenderer>();
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
        line6 = new GameObject("Line6").AddComponent<LineRenderer>();
        // assign material
        line6.material = material;
        line6.material.color = Color.black;
        // Set the width of the Line Renderer
        line6.SetWidth(0.10F, 0.10F);
        // Set the number of vertex fo the Line Renderer
        line6.SetVertexCount(2);
    }


    void createLine7()
    {
        // new line object
        line7 = new GameObject("Line6").AddComponent<LineRenderer>();
        // assign material
        line7.material = material;
        line7.material.color = Color.black;
        // Set the width of the Line Renderer
        line7.SetWidth(0.10F, 0.10F);
        // Set the number of vertex fo the Line Renderer
        line7.SetVertexCount(2);
    }


    void createLine8()
    {
        // new line object
        line8 = new GameObject("Line6").AddComponent<LineRenderer>();
        // assign material
        line8.material = material;
        line8.material.color = Color.black;
        // Set the width of the Line Renderer
        line8.SetWidth(0.10F, 0.10F);
        // Set the number of vertex fo the Line Renderer
        line8.SetVertexCount(2);
    }


    void createLine9()
    {
        // new line object
        line9 = new GameObject("Line6").AddComponent<LineRenderer>();
        // assign material
        line9.material = material;
        line9.material.color = Color.black;
        // Set the width of the Line Renderer
        line9.SetWidth(0.10F, 0.10F);
        // Set the number of vertex fo the Line Renderer
        line9.SetVertexCount(2);
    }


    void createLine10()
    {
        // new line object
        line10 = new GameObject("Line6").AddComponent<LineRenderer>();
        // assign material
        line10.material = material;
        line10.material.color = Color.black;
        // Set the width of the Line Renderer
        line10.SetWidth(0.10F, 0.10F);
        // Set the number of vertex fo the Line Renderer
        line10.SetVertexCount(2);
    }


    void createLine11()
    {
        // new line object
        line11 = new GameObject("Line6").AddComponent<LineRenderer>();
        // assign material
        line11.material = material;
        line11.material.color = Color.black;
        // Set the width of the Line Renderer
        line11.SetWidth(0.10F, 0.10F);
        // Set the number of vertex fo the Line Renderer
        line11.SetVertexCount(2);
    }

    void createLine12()
    {
        // new line object
        line12 = new GameObject("Line6").AddComponent<LineRenderer>();
        // assign material
        line12.material = material;
        line12.material.color = Color.black;
        // Set the width of the Line Renderer
        line12.SetWidth(0.10F, 0.10F);
        // Set the number of vertex fo the Line Renderer
        line12.SetVertexCount(2);
    }

    void Complete()
    {
        if (bridges1To2Counter == 1 && bridges1To3Counter == 1 && bridges3To4Counter == 2 && bridges2To4Counter == 2 && bridges4To5Counter == 1 && bridges4To6Counter == 2)
        {
            complete = true;
            if (complete)
            {
                gameObject.GetComponent<DrawingBridges2ndTry>().enabled = false;
                completedMode.SetActive(true);
            }
        }
    }
}
