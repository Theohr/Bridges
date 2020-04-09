using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class BridgesMediumMode : MonoBehaviour
{
    public GameObject islandOne;          // Reference to the first GameObject
    public GameObject islandTwo;          // Reference to the second GameObject
    public GameObject islandThree;          // Reference to the second GameObject
    public GameObject islandFour;          // Reference to the first GameObject
    public GameObject islandFive;          // Reference to the second GameObject
    public GameObject islandSix;          // Reference to the second GameObject
    public GameObject islandSeven;          // Reference to the first GameObject
    public GameObject islandEight;          // Reference to the second GameObject
    public GameObject islandNine;          // Reference to the second GameObject
    public GameObject islandTen;          // Reference to the first GameObject
    public GameObject islandEleven;          // Reference to the second GameObject
    public GameObject islandTwelve;          // Reference to the second GameObject

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
    private LineRenderer line13;                            // Line Renderer 1
    private LineRenderer line14;                           // Line Renderer 2
    private LineRenderer line15;                           // Line Renderer 3
    private LineRenderer line16;                           // Line Renderer 4
    private LineRenderer line17;                           // Line Renderer 5
    private LineRenderer line18;                           // Line Renderer 6
    private LineRenderer line19;                            // Line Renderer 1
    private LineRenderer line20;                           // Line Renderer 2
    private LineRenderer line21;                           // Line Renderer 3
    private LineRenderer line22;                           // Line Renderer 4
    private LineRenderer line23;                           // Line Renderer 5
    private LineRenderer line24;                           // Line Renderer 6
    private LineRenderer line25;                           // Line Renderer 5
    private LineRenderer line26;                           // Line Renderer 6

    // assign material to the line renderer
    public Material material;

    public GameObject completedMode;

    bool complete = false;

    private Vector3 bridgePositionsX = new Vector3(0.1F, 0F, 0F); // offsets for the 2 bridges on x axis
    private Vector3 bridgePositionsY = new Vector3(0F, 0.1F, 0F); // offsets for the 2 bridges on the y axis

    // lines drawn 
    // counter for the solution button
    private int bridges1To4Counter = 0;
    private int bridges2To3Counter = 0;
    private int bridges1To7Counter = 0;
    private int bridges2To6Counter = 0;
    private int bridges4To5Counter = 0;
    private int bridges3To9Counter = 0;
    private int bridges6To5Counter = 0;
    private int bridges7To8Counter = 0;
    private int bridges6To10Counter = 0;
    private int bridges5To11Counter = 0;
    private int bridges10To9Counter = 0;
    private int bridges7To12Counter = 0;
    private int bridges12To11Counter = 0;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos = Input.mousePosition;

            //////
            // ISLAND 1 TO 4 BRIDGES
            //////
            if (mousePos.x < 135 && mousePos.x > 110)
            {
                if (mousePos.y > 150 && mousePos.y < 300)
                {
                    if (bridges1To4Counter == 0)
                    {
                        createLine();

                        // Update position of the two vertex of the Line Renderer
                        line.SetPosition(0, islandOne.transform.position);
                        line.SetPosition(1, islandFour.transform.position);

                        bridges1To4Counter++;

                        Debug.Log(bridges1To4Counter);
                    }
                    else if (bridges1To4Counter == 1)
                    {
                        Destroy(line);

                        createLine();

                        // Update position of the two vertex of the Line Renderer
                        line.SetPosition(0, islandOne.transform.position - bridgePositionsX);
                        line.SetPosition(1, islandFour.transform.position - bridgePositionsX);

                        createLine2();

                        // Update position of the two vertex of the Line Renderer
                        line2.SetPosition(0, islandOne.transform.position + bridgePositionsX);
                        line2.SetPosition(1, islandFour.transform.position + bridgePositionsX);

                        bridges1To4Counter++;

                        Debug.Log(bridges1To4Counter);
                    }
                    else
                    {
                        Destroy(line);
                        Destroy(line2);
                        bridges1To4Counter = bridges1To4Counter - 2;
                    }
                }
            }

            //////
            // ISLAND 2 TO 3
            //////
            if (mousePos.x > 75 && mousePos.x < 100)
            {
                if (mousePos.y > 100 && mousePos.y < 220)
                {
                    if (bridges2To3Counter == 0)
                    {
                        createLine3();

                        // Update position of the two vertex of the Line Renderer
                        line3.SetPosition(0, islandTwo.transform.position);
                        line3.SetPosition(1, islandThree.transform.position);

                        bridges2To3Counter++;

                        Debug.Log(bridges2To3Counter);
                    }
                    else if (bridges2To3Counter == 1)
                    {
                        Destroy(line3);

                        createLine3();

                        // Update position of the two vertex of the Line Renderer
                        line3.SetPosition(0, islandTwo.transform.position - bridgePositionsX);
                        line3.SetPosition(1, islandThree.transform.position - bridgePositionsX);

                        createLine4();

                        // Update position of the two vertex of the Line Renderer
                        line4.SetPosition(0, islandTwo.transform.position + bridgePositionsX);
                        line4.SetPosition(1, islandThree.transform.position + bridgePositionsX);

                        bridges2To3Counter++;

                        Debug.Log(bridges2To3Counter);
                    }
                    else
                    {
                        Destroy(line3);
                        Destroy(line4);
                        bridges2To3Counter = bridges2To3Counter - 2;
                    }
                }
            }

            //////
            // ISLAND 1 TO 7
            //////
            if (mousePos.x > 145 && mousePos.x < 330)
            {
                if (mousePos.y > 310 && mousePos.y < 335)
                {
                    if (bridges1To7Counter == 0)
                    {
                        createLine5();

                        // Update position of the two vertex of the Line Renderer
                        line5.SetPosition(0, islandOne.transform.position);
                        line5.SetPosition(1, islandSeven.transform.position);

                        bridges1To7Counter++;

                        Debug.Log(bridges1To7Counter);
                    }
                    else if (bridges1To7Counter == 1)
                    {
                        Destroy(line5);

                        createLine5();

                        // Update position of the two vertex of the Line Renderer
                        line5.SetPosition(0, islandOne.transform.position - bridgePositionsY);
                        line5.SetPosition(1, islandSeven.transform.position - bridgePositionsY);

                        createLine6();

                        // Update position of the two vertex of the Line Renderer
                        line6.SetPosition(0, islandOne.transform.position + bridgePositionsY);
                        line6.SetPosition(1, islandSeven.transform.position + bridgePositionsY);

                        bridges1To7Counter++;

                        Debug.Log(bridges1To7Counter);
                    }
                    else
                    {
                        Destroy(line5);
                        Destroy(line6);
                        bridges1To7Counter = bridges1To7Counter - 2;
                    }
                }
            }

            //////
            // ISLAND 2 TO 6
            //////
            if (mousePos.x > 105 && mousePos.x < 230)
            {
                if (mousePos.y > 225 && mousePos.y < 250)
                {
                    if (bridges2To6Counter == 0)
                    {
                        createLine7();

                        // Update position of the two vertex of the Line Renderer
                        line7.SetPosition(0, islandTwo.transform.position);
                        line7.SetPosition(1, islandSix.transform.position);

                        bridges2To6Counter++;

                        Debug.Log(bridges2To6Counter);
                    }
                    else if (bridges2To6Counter == 1)
                    {
                        Destroy(line7);

                        createLine7();

                        // Update position of the two vertex of the Line Renderer
                        line7.SetPosition(0, islandTwo.transform.position - bridgePositionsY);
                        line7.SetPosition(1, islandSix.transform.position - bridgePositionsY);

                        createLine8();

                        // Update position of the two vertex of the Line Renderer
                        line8.SetPosition(0, islandTwo.transform.position + bridgePositionsY);
                        line8.SetPosition(1, islandSix.transform.position + bridgePositionsY);

                        bridges2To6Counter++;

                        Debug.Log(bridges2To6Counter);
                    }
                    else
                    {
                        Destroy(line7);
                        Destroy(line8);
                        bridges2To6Counter = bridges2To6Counter - 2;
                    }
                }
            }

            //////
            // ISLAND 4 TO 5
            //////
            if (mousePos.x > 145 && mousePos.x < 230)
            {
                if (mousePos.y > 110 && mousePos.y < 135)
                {
                    if (bridges4To5Counter == 0)
                    {
                        createLine9();

                        // Update position of the two vertex of the Line Renderer
                        line9.SetPosition(0, islandFour.transform.position);
                        line9.SetPosition(1, islandFive.transform.position);

                        bridges4To5Counter++;

                        Debug.Log(bridges4To5Counter);
                    }
                    else if (bridges4To5Counter == 1)
                    {
                        Destroy(line9);

                        createLine9();

                        // Update position of the two vertex of the Line Renderer
                        line9.SetPosition(0, islandFour.transform.position - bridgePositionsY);
                        line9.SetPosition(1, islandFive.transform.position - bridgePositionsY);

                        createLine10();

                        // Update position of the two vertex of the Line Renderer
                        line10.SetPosition(0, islandFour.transform.position + bridgePositionsY);
                        line10.SetPosition(1, islandFive.transform.position + bridgePositionsY);

                        bridges4To5Counter++;

                        Debug.Log(bridges4To5Counter);
                    }
                    else
                    {
                        Destroy(line9);
                        Destroy(line10);
                        bridges4To5Counter = bridges4To5Counter - 2;
                    }
                }
            }

            //////
            // ISLAND 3 TO 9
            //////
            if (mousePos.x > 105 && mousePos.x < 420)
            {
                if (mousePos.y > 65 && mousePos.y < 90)
                {
                    if (bridges3To9Counter == 0)
                    {
                        createLine11();

                        // Update position of the two vertex of the Line Renderer
                        line11.SetPosition(0, islandThree.transform.position);
                        line11.SetPosition(1, islandNine.transform.position);

                        bridges3To9Counter++;

                        Debug.Log(bridges3To9Counter);
                    }
                    else if (bridges3To9Counter == 1)
                    {
                        Destroy(line11);

                        createLine11();

                        // Update position of the two vertex of the Line Renderer
                        line11.SetPosition(0, islandThree.transform.position - bridgePositionsY);
                        line11.SetPosition(1, islandNine.transform.position - bridgePositionsY);

                        createLine12();

                        // Update position of the two vertex of the Line Renderer
                        line12.SetPosition(0, islandThree.transform.position + bridgePositionsY);
                        line12.SetPosition(1, islandNine.transform.position + bridgePositionsY);

                        bridges3To9Counter++;

                        Debug.Log(bridges3To9Counter);
                    }
                    else
                    {
                        Destroy(line11);
                        Destroy(line12);
                        bridges3To9Counter = bridges3To9Counter - 2;
                    }
                }
            }

            //////
            // ISLAND 6 TO 5
            //////
            if (mousePos.x > 230 && mousePos.x < 255)
            {
                if (mousePos.y > 140 && mousePos.y < 225)
                {
                    if (bridges6To5Counter == 0)
                    {
                        createLine13();

                        // Update position of the two vertex of the Line Renderer
                        line13.SetPosition(0, islandSix.transform.position);
                        line13.SetPosition(1, islandFive.transform.position);

                        bridges6To5Counter++;

                        Debug.Log(bridges6To5Counter);
                    }
                    else if (bridges6To5Counter == 1)
                    {
                        Destroy(line13);

                        createLine13();

                        // Update position of the two vertex of the Line Renderer
                        line13.SetPosition(0, islandSix.transform.position - bridgePositionsX);
                        line13.SetPosition(1, islandFive.transform.position - bridgePositionsX);

                        createLine14();

                        // Update position of the two vertex of the Line Renderer
                        line14.SetPosition(0, islandSix.transform.position + bridgePositionsX);
                        line14.SetPosition(1, islandFive.transform.position + bridgePositionsX);

                        bridges6To5Counter++;

                        Debug.Log(bridges6To5Counter);
                    }
                    else
                    {
                        Destroy(line13);
                        Destroy(line14);
                        bridges6To5Counter = bridges6To5Counter - 2;
                    }
                }
            }

            //////
            // ISLAND 7 TO 8
            //////
            if (mousePos.x > 315 && mousePos.x < 340)
            {
                if (mousePos.y > 200 && mousePos.y < 300)
                {
                    if (bridges7To8Counter == 0)
                    {
                        createLine15();

                        // Update position of the two vertex of the Line Renderer
                        line15.SetPosition(0, islandSeven.transform.position);
                        line15.SetPosition(1, islandEight.transform.position);

                        bridges7To8Counter++;

                        Debug.Log(bridges7To8Counter);
                    }
                    else if (bridges7To8Counter == 1)
                    {
                        Destroy(line15);

                        createLine15();

                        // Update position of the two vertex of the Line Renderer
                        line15.SetPosition(0, islandSeven.transform.position - bridgePositionsX);
                        line15.SetPosition(1, islandEight.transform.position - bridgePositionsX);

                        createLine16();

                        // Update position of the two vertex of the Line Renderer
                        line16.SetPosition(0, islandSeven.transform.position + bridgePositionsX);
                        line16.SetPosition(1, islandEight.transform.position + bridgePositionsX);

                        bridges7To8Counter++;

                        Debug.Log(bridges7To8Counter);
                    }
                    else
                    {
                        Destroy(line15);
                        Destroy(line16);
                        bridges7To8Counter = bridges7To8Counter - 2;
                    }
                }
            }

            //////
            // ISLAND 6 TO 10
            //////
            if (mousePos.x > 265 && mousePos.x < 430)
            {
                if (mousePos.y > 230 && mousePos.y < 255)
                {
                    if (bridges6To10Counter == 0)
                    {
                        createLine17();

                        // Update position of the two vertex of the Line Renderer
                        line17.SetPosition(0, islandSix.transform.position);
                        line17.SetPosition(1, islandTen.transform.position);

                        bridges6To10Counter++;

                        Debug.Log(bridges6To10Counter);
                    }
                    else if (bridges6To10Counter == 1)
                    {
                        Destroy(line17);

                        createLine17();

                        // Update position of the two vertex of the Line Renderer
                        line17.SetPosition(0, islandSix.transform.position - bridgePositionsY);
                        line17.SetPosition(1, islandTen.transform.position - bridgePositionsY);

                        createLine18();

                        // Update position of the two vertex of the Line Renderer
                        line18.SetPosition(0, islandSix.transform.position + bridgePositionsY);
                        line18.SetPosition(1, islandTen.transform.position + bridgePositionsY);

                        bridges6To10Counter++;

                        Debug.Log(bridges6To10Counter);
                    }
                    else
                    {
                        Destroy(line17);
                        Destroy(line18);
                        bridges6To10Counter = bridges6To10Counter - 2;
                    }
                }
            }

            //////
            // ISLAND 5 TO 11
            //////
            if (mousePos.x > 270 && mousePos.x < 550)
            {
                if (mousePos.y > 110 && mousePos.y < 135)
                {
                    if (bridges5To11Counter == 0)
                    {
                        createLine19();

                        // Update position of the two vertex of the Line Renderer
                        line19.SetPosition(0, islandFive.transform.position);
                        line19.SetPosition(1, islandEleven.transform.position);

                        bridges5To11Counter++;

                        Debug.Log(bridges5To11Counter);
                    }
                    else if (bridges5To11Counter == 1)
                    {
                        Destroy(line19);

                        createLine19();

                        // Update position of the two vertex of the Line Renderer
                        line19.SetPosition(0, islandFive.transform.position - bridgePositionsY);
                        line19.SetPosition(1, islandEleven.transform.position - bridgePositionsY);

                        createLine20();

                        // Update position of the two vertex of the Line Renderer
                        line20.SetPosition(0, islandFive.transform.position + bridgePositionsY);
                        line20.SetPosition(1, islandEleven.transform.position + bridgePositionsY);

                        bridges5To11Counter++;

                        Debug.Log(bridges5To11Counter);
                    }
                    else
                    {
                        Destroy(line19);
                        Destroy(line20);
                        bridges5To11Counter = bridges5To11Counter - 2;
                    }
                }
            }

            //////
            // ISLAND 10 TO 9
            //////
            if (mousePos.x > 430 && mousePos.x < 455)
            {
                if (mousePos.y > 100 && mousePos.y < 225)
                {
                    if (bridges10To9Counter == 0)
                    {
                        createLine21();

                        // Update position of the two vertex of the Line Renderer
                        line21.SetPosition(0, islandTen.transform.position);
                        line21.SetPosition(1, islandNine.transform.position);

                        bridges10To9Counter++;

                        Debug.Log(bridges10To9Counter);
                    }
                    else if (bridges10To9Counter == 1)
                    {
                        Destroy(line21);

                        createLine21();

                        // Update position of the two vertex of the Line Renderer
                        line21.SetPosition(0, islandTen.transform.position - bridgePositionsX);
                        line21.SetPosition(1, islandNine.transform.position - bridgePositionsX);

                        createLine22();

                        // Update position of the two vertex of the Line Renderer
                        line22.SetPosition(0, islandTen.transform.position + bridgePositionsX);
                        line22.SetPosition(1, islandNine.transform.position + bridgePositionsX);

                        bridges10To9Counter++;

                        Debug.Log(bridges10To9Counter);
                    }
                    else
                    {
                        Destroy(line21);
                        Destroy(line22);
                        bridges10To9Counter = bridges10To9Counter - 2;
                    }
                }
            }

            //////
            // ISLAND 7 TO 12
            //////
            if (mousePos.x > 350 && mousePos.x < 550)
            {
                if (mousePos.y > 310 && mousePos.y < 335)
                {
                    if (bridges7To12Counter == 0)
                    {
                        createLine23();

                        // Update position of the two vertex of the Line Renderer
                        line23.SetPosition(0, islandSeven.transform.position);
                        line23.SetPosition(1, islandTwelve.transform.position);

                        bridges7To12Counter++;

                        Debug.Log(bridges7To12Counter);
                    }
                    else if (bridges7To12Counter == 1)
                    {
                        Destroy(line23);

                        createLine23();

                        // Update position of the two vertex of the Line Renderer
                        line23.SetPosition(0, islandSeven.transform.position - bridgePositionsY);
                        line23.SetPosition(1, islandTwelve.transform.position - bridgePositionsY);

                        createLine24();

                        // Update position of the two vertex of the Line Renderer
                        line24.SetPosition(0, islandSeven.transform.position + bridgePositionsY);
                        line24.SetPosition(1, islandTwelve.transform.position + bridgePositionsY);

                        bridges7To12Counter++;

                        Debug.Log(bridges7To12Counter);
                    }
                    else
                    {
                        Destroy(line23);
                        Destroy(line24);
                        bridges7To12Counter = bridges7To12Counter - 2;
                    }
                }
            }

            //////
            // ISLAND 12 TO 11
            //////
            if (mousePos.x > 555 && mousePos.x < 580)
            {
                if (mousePos.y > 150 && mousePos.y < 300)
                {
                    if (bridges12To11Counter == 0)
                    {
                        createLine25();

                        // Update position of the two vertex of the Line Renderer
                        line25.SetPosition(0, islandTwelve.transform.position);
                        line25.SetPosition(1, islandEleven.transform.position);

                        bridges12To11Counter++;

                        Debug.Log(bridges12To11Counter);
                    }
                    else if (bridges12To11Counter == 1)
                    {
                        Destroy(line25);

                        createLine25();

                        // Update position of the two vertex of the Line Renderer
                        line25.SetPosition(0, islandTwelve.transform.position - bridgePositionsX);
                        line25.SetPosition(1, islandEleven.transform.position - bridgePositionsX);

                        createLine26();

                        // Update position of the two vertex of the Line Renderer
                        line26.SetPosition(0, islandTwelve.transform.position + bridgePositionsX);
                        line26.SetPosition(1, islandEleven.transform.position + bridgePositionsX);

                        bridges12To11Counter++;

                        Debug.Log(bridges12To11Counter);
                    }
                    else
                    {
                        Destroy(line25);
                        Destroy(line26);
                        bridges12To11Counter = bridges12To11Counter - 2;
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
        line7 = new GameObject("Line7").AddComponent<LineRenderer>();
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
        line8 = new GameObject("Line8").AddComponent<LineRenderer>();
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
        line9 = new GameObject("Line9").AddComponent<LineRenderer>();
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
        line10 = new GameObject("Line10").AddComponent<LineRenderer>();
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
        line11 = new GameObject("Line11").AddComponent<LineRenderer>();
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
        line12 = new GameObject("Line12").AddComponent<LineRenderer>();
        // assign material
        line12.material = material;
        line12.material.color = Color.black;
        // Set the width of the Line Renderer
        line12.SetWidth(0.10F, 0.10F);
        // Set the number of vertex fo the Line Renderer
        line12.SetVertexCount(2);
    }
    void createLine13()
    {
        // new line object
        line13 = new GameObject("Line13").AddComponent<LineRenderer>();
        // assign material
        line13.material = material;
        line13.material.color = Color.black;
        // Set the width of the Line Renderer
        line13.SetWidth(0.10F, 0.10F);
        // Set the number of vertex fo the Line Renderer
        line13.SetVertexCount(2);
    }

    void createLine14()
    {
        // new line object
        line14 = new GameObject("Line14").AddComponent<LineRenderer>();
        // assign material
        line14.material = material;
        line14.material.color = Color.black;
        // Set the width of the Line Renderer
        line14.SetWidth(0.10F, 0.10F);
        // Set the number of vertex fo the Line Renderer
        line14.SetVertexCount(2);
    }
    void createLine15()
    {
        // new line object
        line15 = new GameObject("Line15").AddComponent<LineRenderer>();
        // assign material
        line15.material = material;
        line15.material.color = Color.black;
        // Set the width of the Line Renderer
        line15.SetWidth(0.10F, 0.10F);
        // Set the number of vertex fo the Line Renderer
        line15.SetVertexCount(2);
    }

    void createLine16()
    {
        // new line object
        line16 = new GameObject("Line16").AddComponent<LineRenderer>();
        // assign material
        line16.material = material;
        line16.material.color = Color.black;
        // Set the width of the Line Renderer
        line16.SetWidth(0.10F, 0.10F);
        // Set the number of vertex fo the Line Renderer
        line16.SetVertexCount(2);
    }
    void createLine17()
    {
        // new line object
        line17 = new GameObject("Line7").AddComponent<LineRenderer>();
        // assign material
        line17.material = material;
        line17.material.color = Color.black;
        // Set the width of the Line Renderer
        line17.SetWidth(0.10F, 0.10F);
        // Set the number of vertex fo the Line Renderer
        line17.SetVertexCount(2);
    }

    void createLine18()
    {
        // new line object
        line18 = new GameObject("Line18").AddComponent<LineRenderer>();
        // assign material
        line18.material = material;
        line18.material.color = Color.black;
        // Set the width of the Line Renderer
        line18.SetWidth(0.10F, 0.10F);
        // Set the number of vertex fo the Line Renderer
        line18.SetVertexCount(2);
    }
    void createLine19()
    {
        // new line object
        line19 = new GameObject("Line19").AddComponent<LineRenderer>();
        // assign material
        line19.material = material;
        line19.material.color = Color.black;
        // Set the width of the Line Renderer
        line19.SetWidth(0.10F, 0.10F);
        // Set the number of vertex fo the Line Renderer
        line19.SetVertexCount(2);
    }

    void createLine20()
    {
        // new line object
        line20 = new GameObject("Line20").AddComponent<LineRenderer>();
        // assign material
        line20.material = material;
        line20.material.color = Color.black;
        // Set the width of the Line Renderer
        line20.SetWidth(0.10F, 0.10F);
        // Set the number of vertex fo the Line Renderer
        line20.SetVertexCount(2);
    }
    void createLine21()
    {
        // new line object
        line21 = new GameObject("Line21").AddComponent<LineRenderer>();
        // assign material
        line21.material = material;
        line21.material.color = Color.black;
        // Set the width of the Line Renderer
        line21.SetWidth(0.10F, 0.10F);
        // Set the number of vertex fo the Line Renderer
        line21.SetVertexCount(2);
    }

    void createLine22()
    {
        // new line object
        line22 = new GameObject("Line22").AddComponent<LineRenderer>();
        // assign material
        line22.material = material;
        line22.material.color = Color.black;
        // Set the width of the Line Renderer
        line22.SetWidth(0.10F, 0.10F);
        // Set the number of vertex fo the Line Renderer
        line22.SetVertexCount(2);
    }
    void createLine23()
    {
        // new line object
        line23 = new GameObject("Line23").AddComponent<LineRenderer>();
        // assign material
        line23.material = material;
        line23.material.color = Color.black;
        // Set the width of the Line Renderer
        line23.SetWidth(0.10F, 0.10F);
        // Set the number of vertex fo the Line Renderer
        line23.SetVertexCount(2);
    }

    void createLine24()
    {
        // new line object
        line24 = new GameObject("Line24").AddComponent<LineRenderer>();
        // assign material
        line24.material = material;
        line24.material.color = Color.black;
        // Set the width of the Line Renderer
        line24.SetWidth(0.10F, 0.10F);
        // Set the number of vertex fo the Line Renderer
        line24.SetVertexCount(2);
    }

    void createLine25()
    {
        // new line object
        line25 = new GameObject("Line25").AddComponent<LineRenderer>();
        // assign material
        line25.material = material;
        line25.material.color = Color.black;
        // Set the width of the Line Renderer
        line25.SetWidth(0.10F, 0.10F);
        // Set the number of vertex fo the Line Renderer
        line25.SetVertexCount(2);
    }

    void createLine26()
    {
        // new line object
        line26 = new GameObject("Line26").AddComponent<LineRenderer>();
        // assign material
        line26.material = material;
        line26.material.color = Color.black;
        // Set the width of the Line Renderer
        line26.SetWidth(0.10F, 0.10F);
        // Set the number of vertex fo the Line Renderer
        line26.SetVertexCount(2);
    }

    void Complete()
    {
        if (bridges1To4Counter == 2 && bridges2To3Counter == 2 && bridges1To7Counter == 1 && bridges2To6Counter == 0
            && bridges4To5Counter == 1 && bridges3To9Counter == 2 && bridges6To5Counter == 1 && bridges7To8Counter == 2 
            && bridges6To10Counter == 0 && bridges5To11Counter == 0 && bridges10To9Counter == 2 && bridges7To12Counter == 2
            && bridges12To11Counter == 1)
        {
            complete = true;
            if (complete)
            {
                gameObject.GetComponent<BridgesMediumMode>().enabled = false;
                completedMode.SetActive(true);
            }
        }
    }
}
