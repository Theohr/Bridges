using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BridgesHardMode : MonoBehaviour
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
    public GameObject islandThirteen;          // Reference to the first GameObject
    public GameObject islandFourteen;          // Reference to the second GameObject
    public GameObject islandFifteen;          // Reference to the second GameObject
    public GameObject islandSixteen;          // Reference to the first GameObject
    public GameObject islandSeventeen;          // Reference to the second GameObject
    public GameObject islandEighteen;          // Reference to the second GameObject
    public GameObject islandNineteen;          // Reference to the first GameObject
    public GameObject islandTwenty;          // Reference to the second GameObject

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
    private LineRenderer line27;                            // Line Renderer 1
    private LineRenderer line28;                           // Line Renderer 2
    private LineRenderer line29;                           // Line Renderer 3
    private LineRenderer line30;                           // Line Renderer 4
    private LineRenderer line31;                           // Line Renderer 5
    private LineRenderer line32;                           // Line Renderer 6
    private LineRenderer line33;                            // Line Renderer 1
    private LineRenderer line34;                           // Line Renderer 2
    private LineRenderer line35;                           // Line Renderer 3
    private LineRenderer line36;                           // Line Renderer 4
    private LineRenderer line37;                           // Line Renderer 5
    private LineRenderer line38;                           // Line Renderer 6
    private LineRenderer line39;                            // Line Renderer 1
    private LineRenderer line40;                           // Line Renderer 2
    private LineRenderer line41;                           // Line Renderer 3
    private LineRenderer line42;                           // Line Renderer 4
    private LineRenderer line43;                           // Line Renderer 5
    private LineRenderer line44;                           // Line Renderer 6
    private LineRenderer line45;                            // Line Renderer 1
    private LineRenderer line46;                           // Line Renderer 2
    private LineRenderer line47;                           // Line Renderer 3
    private LineRenderer line48;                           // Line Renderer 4
    private LineRenderer line49;                           // Line Renderer 5
    private LineRenderer line50;                           // Line Renderer 6
    private LineRenderer line51;                           // Line Renderer 5
    private LineRenderer line52;                           // Line Renderer 6
    private LineRenderer line53;                           // Line Renderer 5
    private LineRenderer line54;                           // Line Renderer 6

    // assign material to the line renderer
    public Material material;

    public GameObject completedMode;

    bool complete = false;

    private Vector3 bridgePositionsX = new Vector3(0.1F, 0F, 0F); // offsets for the 2 bridges on x axis
    private Vector3 bridgePositionsY = new Vector3(0F, 0.1F, 0F); // offsets for the 2 bridges on the y axis

    // lines drawn 
    // counter for the solution button
    private int bridges1To2Counter = 0;
    private int bridges2To3Counter = 0;
    private int bridges4To5Counter = 0;
    private int bridges1To9Counter = 0;
    private int bridges4To8Counter = 0;
    private int bridges2To10Counter = 0;
    private int bridges5To7Counter = 0;
    private int bridges3To19Counter = 0;
    private int bridges8To7Counter = 0;
    private int bridges7To19Counter = 0;
    private int bridges19To6Counter = 0;
    private int bridges9To10Counter = 0;
    private int bridges10To6Counter = 0;
    private int bridges8To12Counter = 0;
    private int bridges6To11Counter = 0;
    private int bridges10To14Counter = 0;
    private int bridges9To13Counter = 0;
    private int bridges7To18Counter = 0;
    private int bridges12To11Counter = 0;
    private int bridges13To14Counter = 0;
    private int bridges13To15Counter = 0;
    private int bridges12To17Counter = 0;
    private int bridges14To20Counter = 0;
    private int bridges11To16Counter = 0;
    private int bridges18To16Counter = 0;
    private int bridges17To18Counter = 0;
    private int bridges15To20Counter = 0;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos = Input.mousePosition;

            Debug.Log("Left mouse button pressed");

            Debug.Log(mousePos.x);
            Debug.Log(mousePos.y);

            //////
            // ISLAND 1 TO 2 BRIDGES
            //////
            if (mousePos.x < 65 && mousePos.x > 35)
            {
                if (mousePos.y > 210 && mousePos.y < 310)
                {
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

                        createLine2();

                        // Update position of the two vertex of the Line Renderer
                        line2.SetPosition(0, islandOne.transform.position + bridgePositionsX);
                        line2.SetPosition(1, islandTwo.transform.position + bridgePositionsX);

                        bridges1To2Counter++;

                        Debug.Log(bridges1To2Counter);
                    }
                    else
                    {
                        Destroy(line);
                        Destroy(line2);
                        bridges1To2Counter = bridges1To2Counter - 2;
                    }
                }
            }

            //////
            // ISLAND 2 TO 3 BRIDGES
            //////
            if (mousePos.x < 65 && mousePos.x > 35)
            {
                if (mousePos.y > 80 && mousePos.y < 180)
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
            // ISLAND 4 TO 5 BRIDGES
            //////
            if (line11 == null)
            {
                if (mousePos.x < 95 && mousePos.x > 75)
                {
                    if (mousePos.y > 155 && mousePos.y < 240)
                    {
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

                            createLine5();

                            // Update position of the two vertex of the Line Renderer
                            line5.SetPosition(0, islandFour.transform.position - bridgePositionsX);
                            line5.SetPosition(1, islandFive.transform.position - bridgePositionsX);

                            createLine6();

                            // Update position of the two vertex of the Line Renderer
                            line6.SetPosition(0, islandFour.transform.position + bridgePositionsX);
                            line6.SetPosition(1, islandFive.transform.position + bridgePositionsX);

                            bridges4To5Counter++;

                            Debug.Log(bridges4To5Counter);
                        }
                        else
                        {
                            Destroy(line5);
                            Destroy(line6);
                            bridges4To5Counter = bridges4To5Counter - 2;
                        }

                    }
                }
            }
            //////
            // ISLAND 1 TO 9 BRIDGES
            //////
            if (mousePos.x < 270 && mousePos.x > 65)
            {
                if (mousePos.y > 320 && mousePos.y < 340)
                {
                    if (bridges1To9Counter == 0)
                    {
                        createLine7();

                        // Update position of the two vertex of the Line Renderer
                        line7.SetPosition(0, islandOne.transform.position);
                        line7.SetPosition(1, islandNine.transform.position);

                        bridges1To9Counter++;

                        Debug.Log(bridges1To9Counter);
                    }
                    else if (bridges1To9Counter == 1)
                    {
                        Destroy(line7);

                        createLine7();

                        // Update position of the two vertex of the Line Renderer
                        line7.SetPosition(0, islandOne.transform.position - bridgePositionsY);
                        line7.SetPosition(1, islandNine.transform.position - bridgePositionsY);

                        createLine8();

                        // Update position of the two vertex of the Line Renderer
                        line8.SetPosition(0, islandOne.transform.position + bridgePositionsY);
                        line8.SetPosition(1, islandNine.transform.position + bridgePositionsY);

                        bridges1To9Counter++;

                        Debug.Log(bridges1To9Counter);
                    }
                    else
                    {
                        Destroy(line7);
                        Destroy(line8);
                        bridges1To9Counter = bridges1To9Counter - 2;
                    }

                }
            }

            //////
            // ISLAND 4 TO 8 BRIDGES
            //////
            if (mousePos.x < 205 && mousePos.x > 105)
            {
                if (mousePos.y > 245 && mousePos.y < 265)
                {
                    if (bridges4To8Counter == 0)
                    {
                        createLine9();

                        // Update position of the two vertex of the Line Renderer
                        line9.SetPosition(0, islandFour.transform.position);
                        line9.SetPosition(1, islandEight.transform.position);

                        bridges4To8Counter++;

                        Debug.Log(bridges4To8Counter);
                    }
                    else if (bridges4To8Counter == 1)
                    {
                        Destroy(line9);

                        createLine9();

                        // Update position of the two vertex of the Line Renderer
                        line9.SetPosition(0, islandFour.transform.position - bridgePositionsY);
                        line9.SetPosition(1, islandEight.transform.position - bridgePositionsY);

                        createLine10();

                        // Update position of the two vertex of the Line Renderer
                        line10.SetPosition(0, islandFour.transform.position + bridgePositionsY);
                        line10.SetPosition(1, islandEight.transform.position + bridgePositionsY);

                        bridges4To8Counter++;

                        Debug.Log(bridges4To8Counter);
                    }
                    else
                    {
                        Destroy(line9);
                        Destroy(line10);
                        bridges4To8Counter = bridges4To8Counter - 2;
                    }

                }
            }

            //////
            // ISLAND 2 TO 10 BRIDGES
            //////
            if (line5 == null && line17 == null)
            {
                if (mousePos.x < 270 && mousePos.x > 65)
                {
                    if (mousePos.y > 190 && mousePos.y < 210)
                    {
                        if (bridges2To10Counter == 0)
                        {
                            createLine11();

                            // Update position of the two vertex of the Line Renderer
                            line11.SetPosition(0, islandTwo.transform.position);
                            line11.SetPosition(1, islandTen.transform.position);

                            bridges2To10Counter++;

                            Debug.Log(bridges2To10Counter);
                        }
                        else if (bridges2To10Counter == 1)
                        {
                            Destroy(line11);

                            createLine11();

                            // Update position of the two vertex of the Line Renderer
                            line11.SetPosition(0, islandTwo.transform.position - bridgePositionsY);
                            line11.SetPosition(1, islandTen.transform.position - bridgePositionsY);

                            createLine12();

                            // Update position of the two vertex of the Line Renderer
                            line12.SetPosition(0, islandTwo.transform.position + bridgePositionsY);
                            line12.SetPosition(1, islandTen.transform.position + bridgePositionsY);

                            bridges2To10Counter++;

                            Debug.Log(bridges2To10Counter);
                        }
                        else
                        {
                            Destroy(line11);
                            Destroy(line12);
                            bridges2To10Counter = bridges2To10Counter - 2;
                        }

                    }
                }
            }
            //////
            // ISLAND 5 TO 7 BRIDGES
            //////
            if (mousePos.x < 205 && mousePos.x > 105)
            {
                if (mousePos.y > 130 && mousePos.y < 150)
                {
                    if (bridges5To7Counter == 0)
                    {
                        createLine13();

                        // Update position of the two vertex of the Line Renderer
                        line13.SetPosition(0, islandFive.transform.position);
                        line13.SetPosition(1, islandSeven.transform.position);

                        bridges5To7Counter++;

                        Debug.Log(bridges5To7Counter);
                    }
                    else if (bridges5To7Counter == 1)
                    {
                        Destroy(line13);

                        createLine13();

                        // Update position of the two vertex of the Line Renderer
                        line13.SetPosition(0, islandFive.transform.position - bridgePositionsY);
                        line13.SetPosition(1, islandSeven.transform.position - bridgePositionsY);

                        createLine14();

                        // Update position of the two vertex of the Line Renderer
                        line14.SetPosition(0, islandFive.transform.position + bridgePositionsY);
                        line14.SetPosition(1, islandSeven.transform.position + bridgePositionsY);

                        bridges5To7Counter++;

                        Debug.Log(bridges5To7Counter);
                    }
                    else
                    {
                        Destroy(line13);
                        Destroy(line14);
                        bridges5To7Counter = bridges5To7Counter - 2;
                    }

                }
            }

            //////
            // ISLAND 3 TO 19 BRIDGES
            //////
            if (mousePos.x < 240 && mousePos.x > 95)
            {
                if (mousePos.y > 55 && mousePos.y < 75)
                {
                    if (bridges3To19Counter == 0)
                    {
                        createLine15();

                        // Update position of the two vertex of the Line Renderer
                        line15.SetPosition(0, islandThree.transform.position);
                        line15.SetPosition(1, islandNineteen.transform.position);

                        bridges3To19Counter++;

                        Debug.Log(bridges3To19Counter);
                    }
                    else if (bridges3To19Counter == 1)
                    {
                        Destroy(line15);

                        createLine15();

                        // Update position of the two vertex of the Line Renderer
                        line15.SetPosition(0, islandThree.transform.position - bridgePositionsY);
                        line15.SetPosition(1, islandNineteen.transform.position - bridgePositionsY);

                        createLine16();

                        // Update position of the two vertex of the Line Renderer
                        line16.SetPosition(0, islandThree.transform.position + bridgePositionsY);
                        line16.SetPosition(1, islandNineteen.transform.position + bridgePositionsY);

                        bridges3To19Counter++;

                        Debug.Log(bridges3To19Counter);
                    }
                    else
                    {
                        Destroy(line15);
                        Destroy(line16);
                        bridges3To19Counter = bridges3To19Counter - 2;
                    }

                }
            }

            //////
            // ISLAND 8 TO 7 BRIDGES
            //////
            if (line11 == null)
            {
                if (mousePos.x < 235 && mousePos.x > 215)
                {
                    if (mousePos.y > 155 && mousePos.y < 240)
                    {
                        if (bridges8To7Counter == 0)
                        {
                            createLine17();

                            // Update position of the two vertex of the Line Renderer
                            line17.SetPosition(0, islandEight.transform.position);
                            line17.SetPosition(1, islandSeven.transform.position);

                            bridges8To7Counter++;

                            Debug.Log(bridges8To7Counter);
                        }
                        else if (bridges8To7Counter == 1)
                        {
                            Destroy(line17);

                            createLine17();

                            // Update position of the two vertex of the Line Renderer
                            line17.SetPosition(0, islandEight.transform.position - bridgePositionsX);
                            line17.SetPosition(1, islandSeven.transform.position - bridgePositionsX);

                            createLine18();

                            // Update position of the two vertex of the Line Renderer
                            line18.SetPosition(0, islandEight.transform.position + bridgePositionsX);
                            line18.SetPosition(1, islandSeven.transform.position + bridgePositionsX);

                            bridges8To7Counter++;

                            Debug.Log(bridges8To7Counter);
                        }
                        else
                        {
                            Destroy(line17);
                            Destroy(line18);
                            bridges8To7Counter = bridges8To7Counter - 2;
                        }

                    }
                }
            }

            //////
            // ISLAND 7 TO 19 BRIDGES
            //////
            if (mousePos.x < 235 && mousePos.x > 215)
            {
                if (mousePos.y > 80 && mousePos.y < 120)
                {
                    if (bridges7To19Counter == 0)
                    {
                        createLine19();

                        // Update position of the two vertex of the Line Renderer
                        line19.SetPosition(0, islandSeven.transform.position);
                        line19.SetPosition(1, islandNineteen.transform.position);

                        bridges7To19Counter++;

                        Debug.Log(bridges7To19Counter);
                    }
                    else if (bridges7To19Counter == 1)
                    {
                        Destroy(line19);

                        createLine19();

                        // Update position of the two vertex of the Line Renderer
                        line19.SetPosition(0, islandSeven.transform.position - bridgePositionsX);
                        line19.SetPosition(1, islandNineteen.transform.position - bridgePositionsX);

                        createLine20();

                        // Update position of the two vertex of the Line Renderer
                        line20.SetPosition(0, islandSeven.transform.position + bridgePositionsX);
                        line20.SetPosition(1, islandNineteen.transform.position + bridgePositionsX);

                        bridges7To19Counter++;

                        Debug.Log(bridges7To19Counter);
                    }
                    else
                    {
                        Destroy(line19);
                        Destroy(line20);
                        bridges7To19Counter = bridges7To19Counter - 2;
                    }

                }
            }

            //////
            // ISLAND 19 TO 6 BRIDGES
            //////
            if (mousePos.x < 270 && mousePos.x > 245)
            {
                if (mousePos.y > 55 && mousePos.y < 75)
                {
                    if (bridges19To6Counter == 0)
                    {
                        createLine21();

                        // Update position of the two vertex of the Line Renderer
                        line21.SetPosition(0, islandNineteen.transform.position);
                        line21.SetPosition(1, islandSix.transform.position);

                        bridges19To6Counter++;

                        Debug.Log(bridges19To6Counter);
                    }
                    else if (bridges19To6Counter == 1)
                    {
                        Destroy(line21);

                        createLine21();

                        // Update position of the two vertex of the Line Renderer
                        line21.SetPosition(0, islandNineteen.transform.position - bridgePositionsY);
                        line21.SetPosition(1, islandSix.transform.position - bridgePositionsY);

                        createLine22();

                        // Update position of the two vertex of the Line Renderer
                        line22.SetPosition(0, islandNineteen.transform.position + bridgePositionsY);
                        line22.SetPosition(1, islandSix.transform.position + bridgePositionsY);

                        bridges19To6Counter++;

                        Debug.Log(bridges19To6Counter);
                    }
                    else
                    {
                        Destroy(line21);
                        Destroy(line22);
                        bridges19To6Counter = bridges19To6Counter - 2;
                    }

                }
            }

            //////
            // ISLAND 9 TO 10 BRIDGES
            //////
            if (line27 == null)
            {
                if (mousePos.x < 295 && mousePos.x > 275)
                {
                    if (mousePos.y > 210 && mousePos.y < 310)
                    {
                        if (bridges9To10Counter == 0)
                        {
                            createLine23();

                            // Update position of the two vertex of the Line Renderer
                            line23.SetPosition(0, islandNine.transform.position);
                            line23.SetPosition(1, islandTen.transform.position);

                            bridges9To10Counter++;

                            Debug.Log(bridges9To10Counter);
                        }
                        else if (bridges9To10Counter == 1)
                        {
                            Destroy(line23);

                            createLine23();

                            // Update position of the two vertex of the Line Renderer
                            line23.SetPosition(0, islandNine.transform.position - bridgePositionsX);
                            line23.SetPosition(1, islandTen.transform.position - bridgePositionsX);

                            createLine24();

                            // Update position of the two vertex of the Line Renderer
                            line24.SetPosition(0, islandNine.transform.position + bridgePositionsX);
                            line24.SetPosition(1, islandTen.transform.position + bridgePositionsX);

                            bridges9To10Counter++;

                            Debug.Log(bridges9To10Counter);
                        }
                        else
                        {
                            Destroy(line23);
                            Destroy(line24);
                            bridges9To10Counter = bridges9To10Counter - 2;
                        }

                    }
                }
            }
            //////
            // ISLAND 10 TO 6 BRIDGES
            //////
            if (line35 == null)
            {
                if (mousePos.x < 295 && mousePos.x > 275)
                {
                    if (mousePos.y > 80 && mousePos.y < 180)
                    {
                        if (bridges10To6Counter == 0)
                        {
                            createLine25();

                            // Update position of the two vertex of the Line Renderer
                            line25.SetPosition(0, islandTen.transform.position);
                            line25.SetPosition(1, islandSix.transform.position);

                            bridges10To6Counter++;

                            Debug.Log(bridges10To6Counter);
                        }
                        else if (bridges10To6Counter == 1)
                        {
                            Destroy(line25);

                            createLine25();

                            // Update position of the two vertex of the Line Renderer
                            line25.SetPosition(0, islandTen.transform.position - bridgePositionsX);
                            line25.SetPosition(1, islandSix.transform.position - bridgePositionsX);

                            createLine26();

                            // Update position of the two vertex of the Line Renderer
                            line26.SetPosition(0, islandTen.transform.position + bridgePositionsX);
                            line26.SetPosition(1, islandSix.transform.position + bridgePositionsX);

                            bridges10To6Counter++;

                            Debug.Log(bridges10To6Counter);
                        }
                        else
                        {
                            Destroy(line25);
                            Destroy(line26);
                            bridges10To6Counter = bridges10To6Counter - 2;
                        }
                    }
                }
            }

            //////
            // ISLAND 8 TO 12 BRIDGES
            //////
            if (line23 == null)
            {
                if (mousePos.x < 370 && mousePos.x > 245)
                {
                    if (mousePos.y > 245 && mousePos.y < 265)
                    {
                        if (bridges8To12Counter == 0)
                        {
                            createLine27();

                            // Update position of the two vertex of the Line Renderer
                            line27.SetPosition(0, islandEight.transform.position);
                            line27.SetPosition(1, islandTwelve.transform.position);

                            bridges8To12Counter++;

                            Debug.Log(bridges8To12Counter);
                        }
                        else if (bridges8To12Counter == 1)
                        {
                            Destroy(line27);

                            createLine27();

                            // Update position of the two vertex of the Line Renderer
                            line27.SetPosition(0, islandEight.transform.position - bridgePositionsY);
                            line27.SetPosition(1, islandTwelve.transform.position - bridgePositionsY);

                            createLine28();

                            // Update position of the two vertex of the Line Renderer
                            line28.SetPosition(0, islandEight.transform.position + bridgePositionsY);
                            line28.SetPosition(1, islandTwelve.transform.position + bridgePositionsY);

                            bridges8To12Counter++;

                            Debug.Log(bridges8To12Counter);
                        }
                        else
                        {
                            Destroy(line27);
                            Destroy(line28);
                            bridges8To12Counter = bridges8To12Counter - 2;
                        }

                    }
                }
            }

            //////
            // ISLAND 6 TO 11 BRIDGES
            //////
            if (mousePos.x < 370 && mousePos.x > 305)
            {
                if (mousePos.y > 55 && mousePos.y < 75)
                {
                    if (bridges6To11Counter == 0)
                    {
                        createLine29();

                        // Update position of the two vertex of the Line Renderer
                        line29.SetPosition(0, islandSix.transform.position);
                        line29.SetPosition(1, islandEleven.transform.position);

                        bridges6To11Counter++;

                        Debug.Log(bridges6To11Counter);
                    }
                    else if (bridges6To11Counter == 1)
                    {
                        Destroy(line29);

                        createLine29();

                        // Update position of the two vertex of the Line Renderer
                        line29.SetPosition(0, islandSix.transform.position - bridgePositionsY);
                        line29.SetPosition(1, islandEleven.transform.position - bridgePositionsY);

                        createLine30();

                        // Update position of the two vertex of the Line Renderer
                        line30.SetPosition(0, islandSix.transform.position + bridgePositionsY);
                        line30.SetPosition(1, islandEleven.transform.position + bridgePositionsY);

                        bridges6To11Counter++;

                        Debug.Log(bridges6To11Counter);
                    }
                    else
                    {
                        Destroy(line29);
                        Destroy(line30);
                        bridges6To11Counter = bridges6To11Counter - 2;
                    }

                }
            }

            //////
            // ISLAND 10 TO 14 BRIDGES
            //////
            if (line37 == null)
            {
                if (mousePos.x < 425 && mousePos.x > 305)
                {
                    if (mousePos.y > 190 && mousePos.y < 210)
                    {
                        if (bridges10To14Counter == 0)
                        {
                            createLine31();

                            // Update position of the two vertex of the Line Renderer
                            line31.SetPosition(0, islandTen.transform.position);
                            line31.SetPosition(1, islandFourteen.transform.position);

                            bridges10To14Counter++;

                            Debug.Log(bridges10To14Counter);
                        }
                        else if (bridges10To14Counter == 1)
                        {
                            Destroy(line31);

                            createLine31();

                            // Update position of the two vertex of the Line Renderer
                            line31.SetPosition(0, islandTen.transform.position - bridgePositionsY);
                            line31.SetPosition(1, islandFourteen.transform.position - bridgePositionsY);

                            createLine32();

                            // Update position of the two vertex of the Line Renderer
                            line32.SetPosition(0, islandTen.transform.position + bridgePositionsY);
                            line32.SetPosition(1, islandFourteen.transform.position + bridgePositionsY);

                            bridges10To14Counter++;

                            Debug.Log(bridges10To14Counter);
                        }
                        else
                        {
                            Destroy(line31);
                            Destroy(line32);
                            bridges10To14Counter = bridges10To14Counter - 2;
                        }

                    }
                }
            }
            //////
            // ISLAND 9 TO 13 BRIDGES
            //////
            if (mousePos.x < 425 && mousePos.x > 305)
            {
                if (mousePos.y > 320 && mousePos.y < 340)
                {
                    if (bridges9To13Counter == 0)
                    {
                        createLine33();

                        // Update position of the two vertex of the Line Renderer
                        line33.SetPosition(0, islandNine.transform.position);
                        line33.SetPosition(1, islandThirteen.transform.position);

                        bridges9To13Counter++;

                        Debug.Log(bridges9To13Counter);
                    }
                    else if (bridges9To13Counter == 1)
                    {
                        Destroy(line33);

                        createLine33();

                        // Update position of the two vertex of the Line Renderer
                        line33.SetPosition(0, islandNine.transform.position - bridgePositionsY);
                        line33.SetPosition(1, islandThirteen.transform.position - bridgePositionsY);

                        createLine34();

                        // Update position of the two vertex of the Line Renderer
                        line34.SetPosition(0, islandNine.transform.position + bridgePositionsY);
                        line34.SetPosition(1, islandThirteen.transform.position + bridgePositionsY);

                        bridges9To13Counter++;

                        Debug.Log(bridges9To13Counter);
                    }
                    else
                    {
                        Destroy(line33);
                        Destroy(line34);
                        bridges9To13Counter = bridges9To13Counter - 2;
                    }

                }
            }

            //////
            // ISLAND 7 TO 18 BRIDGES
            //////
            if (line25 == null && line37 == null)
            {
                if (mousePos.x < 585 && mousePos.x > 245)
                {
                    if (mousePos.y > 130 && mousePos.y < 150)
                    {
                        if (bridges7To18Counter == 0)
                        {
                            createLine35();

                            // Update position of the two vertex of the Line Renderer
                            line35.SetPosition(0, islandSeven.transform.position);
                            line35.SetPosition(1, islandEighteen.transform.position);

                            bridges7To18Counter++;

                            Debug.Log(bridges7To18Counter);
                        }
                        else if (bridges7To18Counter == 1)
                        {
                            Destroy(line35);

                            createLine35();

                            // Update position of the two vertex of the Line Renderer
                            line35.SetPosition(0, islandSeven.transform.position - bridgePositionsY);
                            line35.SetPosition(1, islandEighteen.transform.position - bridgePositionsY);

                            createLine36();

                            // Update position of the two vertex of the Line Renderer
                            line36.SetPosition(0, islandSeven.transform.position + bridgePositionsY);
                            line36.SetPosition(1, islandEighteen.transform.position + bridgePositionsY);

                            bridges7To18Counter++;

                            Debug.Log(bridges7To18Counter);
                        }
                        else
                        {
                            Destroy(line35);
                            Destroy(line36);
                            bridges7To18Counter = bridges7To18Counter - 2;
                        }
                    }
                }
            }
            //////
            // ISLAND 12 TO 11 BRIDGES
            //////
            if (line35 == null && line31 == null)
            {
                if (mousePos.x < 395 && mousePos.x > 375)
                {
                    if (mousePos.y > 85 && mousePos.y < 240)
                    {
                        if (bridges12To11Counter == 0)
                        {
                            createLine37();

                            // Update position of the two vertex of the Line Renderer
                            line37.SetPosition(0, islandTwelve.transform.position);
                            line37.SetPosition(1, islandEleven.transform.position);

                            bridges12To11Counter++;

                            Debug.Log(bridges12To11Counter);
                        }
                        else if (bridges12To11Counter == 1)
                        {
                            Destroy(line37);

                            createLine37();

                            // Update position of the two vertex of the Line Renderer
                            line37.SetPosition(0, islandTwelve.transform.position - bridgePositionsX);
                            line37.SetPosition(1, islandEleven.transform.position - bridgePositionsX);

                            createLine38();

                            // Update position of the two vertex of the Line Renderer
                            line38.SetPosition(0, islandTwelve.transform.position + bridgePositionsX);
                            line38.SetPosition(1, islandEleven.transform.position + bridgePositionsX);

                            bridges12To11Counter++;

                            Debug.Log(bridges12To11Counter);
                        }
                        else
                        {
                            Destroy(line37);
                            Destroy(line38);
                            bridges12To11Counter = bridges12To11Counter - 2;
                        }

                    }
                }
            }
            //////
            // ISLAND 13 TO 14 BRIDGES
            //////
            if (line43 == null)
            {
                if (mousePos.x < 455 && mousePos.x > 435)
                {
                    if (mousePos.y > 210 && mousePos.y < 310)
                    {
                        if (bridges13To14Counter == 0)
                        {
                            createLine39();

                            // Update position of the two vertex of the Line Renderer
                            line39.SetPosition(0, islandThirteen.transform.position);
                            line39.SetPosition(1, islandFourteen.transform.position);

                            bridges13To14Counter++;

                            Debug.Log(bridges13To14Counter);
                        }
                        else if (bridges13To14Counter == 1)
                        {
                            Destroy(line39);

                            createLine39();

                            // Update position of the two vertex of the Line Renderer
                            line39.SetPosition(0, islandThirteen.transform.position - bridgePositionsX);
                            line39.SetPosition(1, islandFourteen.transform.position - bridgePositionsX);

                            createLine40();

                            // Update position of the two vertex of the Line Renderer
                            line40.SetPosition(0, islandThirteen.transform.position + bridgePositionsX);
                            line40.SetPosition(1, islandFourteen.transform.position + bridgePositionsX);

                            bridges13To14Counter++;

                            Debug.Log(bridges13To14Counter);
                        }
                        else
                        {
                            Destroy(line39);
                            Destroy(line40);
                            bridges13To14Counter = bridges13To14Counter - 2;
                        }

                    }
                }
            }

            //////
            // ISLAND 13 TO 15 BRIDGES
            //////
            if (mousePos.x < 525 && mousePos.x > 465)
            {
                if (mousePos.y > 320 && mousePos.y < 340)
                {
                    if (bridges13To15Counter == 0)
                    {
                        createLine41();

                        // Update position of the two vertex of the Line Renderer
                        line41.SetPosition(0, islandThirteen.transform.position);
                        line41.SetPosition(1, islandFifteen.transform.position);

                        bridges13To15Counter++;

                        Debug.Log(bridges13To15Counter);
                    }
                    else if (bridges13To15Counter == 1)
                    {
                        Destroy(line41);

                        createLine41();

                        // Update position of the two vertex of the Line Renderer
                        line41.SetPosition(0, islandThirteen.transform.position - bridgePositionsY);
                        line41.SetPosition(1, islandFifteen.transform.position - bridgePositionsY);

                        createLine42();

                        // Update position of the two vertex of the Line Renderer
                        line42.SetPosition(0, islandThirteen.transform.position + bridgePositionsY);
                        line42.SetPosition(1, islandFifteen.transform.position + bridgePositionsY);

                        bridges13To15Counter++;

                        Debug.Log(bridges13To15Counter);
                    }
                    else
                    {
                        Destroy(line41);
                        Destroy(line42);
                        bridges13To15Counter = bridges13To15Counter - 2;
                    }

                }
            }

            //////
            // ISLAND 12 TO 17 BRIDGES
            //////
            if (line39 == null && line53 == null)
            {
                if (mousePos.x < 585 && mousePos.x > 405)
                {
                    if (mousePos.y > 245 && mousePos.y < 265)
                    {
                        if (bridges12To17Counter == 0)
                        {
                            createLine43();

                            // Update position of the two vertex of the Line Renderer
                            line43.SetPosition(0, islandTwelve.transform.position);
                            line43.SetPosition(1, islandSeventeen.transform.position);

                            bridges12To17Counter++;

                            Debug.Log(bridges12To17Counter);
                        }
                        else if (bridges12To17Counter == 1)
                        {
                            Destroy(line43);

                            createLine43();

                            // Update position of the two vertex of the Line Renderer
                            line43.SetPosition(0, islandTwelve.transform.position - bridgePositionsY);
                            line43.SetPosition(1, islandSeventeen.transform.position - bridgePositionsY);

                            createLine44();

                            // Update position of the two vertex of the Line Renderer
                            line44.SetPosition(0, islandTwelve.transform.position + bridgePositionsY);
                            line44.SetPosition(1, islandSeventeen.transform.position + bridgePositionsY);

                            bridges12To17Counter++;

                            Debug.Log(bridges12To17Counter);
                        }
                        else
                        {
                            Destroy(line43);
                            Destroy(line44);
                            bridges12To17Counter = bridges12To17Counter - 2;
                        }

                    }
                }
            }

            //////
            // ISLAND 14 TO 20 BRIDGES
            //////
            if (mousePos.x < 525 && mousePos.x > 465)
            {
                if (mousePos.y > 190 && mousePos.y < 210)
                {
                    if (bridges14To20Counter == 0)
                    {
                        createLine45();

                        // Update position of the two vertex of the Line Renderer
                        line45.SetPosition(0, islandFourteen.transform.position);
                        line45.SetPosition(1, islandTwenty.transform.position);

                        bridges14To20Counter++;

                        Debug.Log(bridges14To20Counter);
                    }
                    else if (bridges14To20Counter == 1)
                    {
                        Destroy(line45);

                        createLine45();

                        // Update position of the two vertex of the Line Renderer
                        line45.SetPosition(0, islandFourteen.transform.position - bridgePositionsY);
                        line45.SetPosition(1, islandTwenty.transform.position - bridgePositionsY);

                        createLine46();

                        // Update position of the two vertex of the Line Renderer
                        line46.SetPosition(0, islandFourteen.transform.position + bridgePositionsY);
                        line46.SetPosition(1, islandTwenty.transform.position + bridgePositionsY);

                        bridges14To20Counter++;

                        Debug.Log(bridges14To20Counter);
                    }
                    else
                    {
                        Destroy(line45);
                        Destroy(line46);
                        bridges14To20Counter = bridges14To20Counter - 2;
                    }

                }
            }

            //////
            // ISLAND 11 TO 16 BRIDGES
            //////
            if (mousePos.x < 585 && mousePos.x > 405)
            {
                if (mousePos.y > 55 && mousePos.y < 75)
                {
                    if (bridges11To16Counter == 0)
                    {
                        createLine47();

                        // Update position of the two vertex of the Line Renderer
                        line47.SetPosition(0, islandEleven.transform.position);
                        line47.SetPosition(1, islandSixteen.transform.position);

                        bridges11To16Counter++;

                        Debug.Log(bridges11To16Counter);
                    }
                    else if (bridges11To16Counter == 1)
                    {
                        Destroy(line47);

                        createLine47();

                        // Update position of the two vertex of the Line Renderer
                        line47.SetPosition(0, islandEleven.transform.position - bridgePositionsY);
                        line47.SetPosition(1, islandSixteen.transform.position - bridgePositionsY);

                        createLine48();

                        // Update position of the two vertex of the Line Renderer
                        line48.SetPosition(0, islandEleven.transform.position + bridgePositionsY);
                        line48.SetPosition(1, islandSixteen.transform.position + bridgePositionsY);

                        bridges11To16Counter++;

                        Debug.Log(bridges11To16Counter);
                    }
                    else
                    {
                        Destroy(line47);
                        Destroy(line48);
                        bridges11To16Counter = bridges11To16Counter - 2;
                    }

                }
            }

            //////
            // ISLAND 18 TO 16 BRIDGES
            //////
            if (mousePos.x < 615 && mousePos.x > 595)
            {
                if (mousePos.y > 80 && mousePos.y < 120)
                {
                    if (bridges18To16Counter == 0)
                    {
                        createLine49();

                        // Update position of the two vertex of the Line Renderer
                        line49.SetPosition(0, islandEighteen.transform.position);
                        line49.SetPosition(1, islandSixteen.transform.position);

                        bridges18To16Counter++;

                        Debug.Log(bridges18To16Counter);
                    }
                    else if (bridges18To16Counter == 1)
                    {
                        Destroy(line49);

                        createLine49();

                        // Update position of the two vertex of the Line Renderer
                        line49.SetPosition(0, islandEighteen.transform.position - bridgePositionsX);
                        line49.SetPosition(1, islandSixteen.transform.position - bridgePositionsX);

                        createLine50();

                        // Update position of the two vertex of the Line Renderer
                        line50.SetPosition(0, islandEighteen.transform.position + bridgePositionsX);
                        line50.SetPosition(1, islandSixteen.transform.position + bridgePositionsX);

                        bridges18To16Counter++;

                        Debug.Log(bridges18To16Counter);
                    }
                    else
                    {
                        Destroy(line49);
                        Destroy(line50);
                        bridges18To16Counter = bridges18To16Counter - 2;
                    }

                }
            }

            //////
            // ISLAND 17 TO 18 BRIDGES
            //////
            if (mousePos.x < 615 && mousePos.x > 595)
            {
                if (mousePos.y > 155 && mousePos.y < 240)
                {
                    if (bridges17To18Counter == 0)
                    {
                        createLine51();

                        // Update position of the two vertex of the Line Renderer
                        line51.SetPosition(0, islandSeventeen.transform.position);
                        line51.SetPosition(1, islandEighteen.transform.position);

                        bridges17To18Counter++;

                        Debug.Log(bridges17To18Counter);
                    }
                    else if (bridges17To18Counter == 1)
                    {
                        Destroy(line51);

                        createLine51();

                        // Update position of the two vertex of the Line Renderer
                        line51.SetPosition(0, islandSeventeen.transform.position - bridgePositionsX);
                        line51.SetPosition(1, islandEighteen.transform.position - bridgePositionsX);

                        createLine52();

                        // Update position of the two vertex of the Line Renderer
                        line52.SetPosition(0, islandSeventeen.transform.position + bridgePositionsX);
                        line52.SetPosition(1, islandEighteen.transform.position + bridgePositionsX);

                        bridges17To18Counter++;

                        Debug.Log(bridges17To18Counter);
                    }
                    else
                    {
                        Destroy(line51);
                        Destroy(line52);
                        bridges17To18Counter = bridges17To18Counter - 2;
                    }

                }
            }

            //////
            // ISLAND 15 TO 20 BRIDGES
            //////
            if (line43 == null)
            {
                if (mousePos.x < 555 && mousePos.x > 535)
                {
                    if (mousePos.y > 215 && mousePos.y < 315)
                    {
                        if (bridges15To20Counter == 0)
                        {
                            createLine53();

                            // Update position of the two vertex of the Line Renderer
                            line53.SetPosition(0, islandFifteen.transform.position);
                            line53.SetPosition(1, islandTwenty.transform.position);

                            bridges15To20Counter++;

                            Debug.Log(bridges15To20Counter);
                        }
                        else if (bridges15To20Counter == 1)
                        {
                            Destroy(line53);

                            createLine53();

                            // Update position of the two vertex of the Line Renderer
                            line53.SetPosition(0, islandFifteen.transform.position - bridgePositionsX);
                            line53.SetPosition(1, islandTwenty.transform.position - bridgePositionsX);

                            createLine54();

                            // Update position of the two vertex of the Line Renderer
                            line54.SetPosition(0, islandFifteen.transform.position + bridgePositionsX);
                            line54.SetPosition(1, islandTwenty.transform.position + bridgePositionsX);

                            bridges15To20Counter++;

                            Debug.Log(bridges15To20Counter);
                        }
                        else
                        {
                            Destroy(line53);
                            Destroy(line54);
                            bridges15To20Counter = bridges15To20Counter - 2;
                        }
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

    void createLine27()
    {
        // new line object
        line27 = new GameObject("Line27").AddComponent<LineRenderer>();
        // assign material
        line27.material = material;
        line27.material.color = Color.black;
        // Set the width of the Line Renderer
        line27.SetWidth(0.10F, 0.10F);
        // Set the number of vertex fo the Line Renderer
        line27.SetVertexCount(2);
    }

    void createLine28()
    {
        // new line object
        line28 = new GameObject("Line28").AddComponent<LineRenderer>();
        // assign material
        line28.material = material;
        line28.material.color = Color.black;
        // Set the width of the Line Renderer
        line28.SetWidth(0.10F, 0.10F);
        // Set the number of vertex fo the Line Renderer
        line28.SetVertexCount(2);
    }

    void createLine29()
    {
        // new line object
        line29 = new GameObject("Line29").AddComponent<LineRenderer>();
        // assign material
        line29.material = material;
        line29.material.color = Color.black;
        // Set the width of the Line Renderer
        line29.SetWidth(0.10F, 0.10F);
        // Set the number of vertex fo the Line Renderer
        line29.SetVertexCount(2);
    }

    void createLine30()
    {
        // new line object
        line30 = new GameObject("Line30").AddComponent<LineRenderer>();
        // assign material
        line30.material = material;
        line30.material.color = Color.black;
        // Set the width of the Line Renderer
        line30.SetWidth(0.10F, 0.10F);
        // Set the number of vertex fo the Line Renderer
        line30.SetVertexCount(2);
    }

    void createLine31()
    {
        // new line object
        line31 = new GameObject("Line31").AddComponent<LineRenderer>();
        // assign material
        line31.material = material;
        line31.material.color = Color.black;
        // Set the width of the Line Renderer
        line31.SetWidth(0.10F, 0.10F);
        // Set the number of vertex fo the Line Renderer
        line31.SetVertexCount(2);
    }

    void createLine32()
    {
        // new line object
        line32 = new GameObject("Line32").AddComponent<LineRenderer>();
        // assign material
        line32.material = material;
        line32.material.color = Color.black;
        // Set the width of the Line Renderer
        line32.SetWidth(0.10F, 0.10F);
        // Set the number of vertex fo the Line Renderer
        line32.SetVertexCount(2);
    }


    void createLine33()
    {
        // new line object
        line33 = new GameObject("Line33").AddComponent<LineRenderer>();
        // assign material
        line33.material = material;
        line33.material.color = Color.black;
        // Set the width of the Line Renderer
        line33.SetWidth(0.10F, 0.10F);
        // Set the number of vertex fo the Line Renderer
        line33.SetVertexCount(2);
    }


    void createLine34()
    {
        // new line object
        line34 = new GameObject("Line34").AddComponent<LineRenderer>();
        // assign material
        line34.material = material;
        line34.material.color = Color.black;
        // Set the width of the Line Renderer
        line34.SetWidth(0.10F, 0.10F);
        // Set the number of vertex fo the Line Renderer
        line34.SetVertexCount(2);
    }


    void createLine35()
    {
        // new line object
        line35 = new GameObject("Line35").AddComponent<LineRenderer>();
        // assign material
        line35.material = material;
        line35.material.color = Color.black;
        // Set the width of the Line Renderer
        line35.SetWidth(0.10F, 0.10F);
        // Set the number of vertex fo the Line Renderer
        line35.SetVertexCount(2);
    }


    void createLine36()
    {
        // new line object
        line36 = new GameObject("Line36").AddComponent<LineRenderer>();
        // assign material
        line36.material = material;
        line36.material.color = Color.black;
        // Set the width of the Line Renderer
        line36.SetWidth(0.10F, 0.10F);
        // Set the number of vertex fo the Line Renderer
        line36.SetVertexCount(2);
    }

    void createLine37()
    {
        // new line object
        line37 = new GameObject("Line37").AddComponent<LineRenderer>();
        // assign material
        line37.material = material;
        line37.material.color = Color.black;
        // Set the width of the Line Renderer
        line37.SetWidth(0.10F, 0.10F);
        // Set the number of vertex fo the Line Renderer
        line37.SetVertexCount(2);
    }

    void createLine38()
    {
        // new line object
        line38 = new GameObject("Line38").AddComponent<LineRenderer>();
        // assign material
        line38.material = material;
        line38.material.color = Color.black;
        // Set the width of the Line Renderer
        line38.SetWidth(0.10F, 0.10F);
        // Set the number of vertex fo the Line Renderer
        line38.SetVertexCount(2);
    }
    void createLine39()
    {
        // new line object
        line39 = new GameObject("Line39").AddComponent<LineRenderer>();
        // assign material
        line39.material = material;
        line39.material.color = Color.black;
        // Set the width of the Line Renderer
        line39.SetWidth(0.10F, 0.10F);
        // Set the number of vertex fo the Line Renderer
        line39.SetVertexCount(2);
    }

    void createLine40()
    {
        // new line object
        line40 = new GameObject("Line40").AddComponent<LineRenderer>();
        // assign material
        line40.material = material;
        line40.material.color = Color.black;
        // Set the width of the Line Renderer
        line40.SetWidth(0.10F, 0.10F);
        // Set the number of vertex fo the Line Renderer
        line40.SetVertexCount(2);
    }

    void createLine41()
    {
        // new line object
        line41 = new GameObject("Line41").AddComponent<LineRenderer>();
        // assign material
        line41.material = material;
        line41.material.color = Color.black;
        // Set the width of the Line Renderer
        line41.SetWidth(0.10F, 0.10F);
        // Set the number of vertex fo the Line Renderer
        line41.SetVertexCount(2);
    }

    void createLine42()
    {
        // new line object
        line42 = new GameObject("Line42").AddComponent<LineRenderer>();
        // assign material
        line42.material = material;
        line42.material.color = Color.black;
        // Set the width of the Line Renderer
        line42.SetWidth(0.10F, 0.10F);
        // Set the number of vertex fo the Line Renderer
        line42.SetVertexCount(2);
    }
    void createLine43()
    {
        // new line object
        line43 = new GameObject("Line43").AddComponent<LineRenderer>();
        // assign material
        line43.material = material;
        line43.material.color = Color.black;
        // Set the width of the Line Renderer
        line43.SetWidth(0.10F, 0.10F);
        // Set the number of vertex fo the Line Renderer
        line43.SetVertexCount(2);
    }

    void createLine44()
    {
        // new line object
        line44 = new GameObject("Line44").AddComponent<LineRenderer>();
        // assign material
        line44.material = material;
        line44.material.color = Color.black;
        // Set the width of the Line Renderer
        line44.SetWidth(0.10F, 0.10F);
        // Set the number of vertex fo the Line Renderer
        line44.SetVertexCount(2);
    }
    void createLine45()
    {
        // new line object
        line45 = new GameObject("Line45").AddComponent<LineRenderer>();
        // assign material
        line45.material = material;
        line45.material.color = Color.black;
        // Set the width of the Line Renderer
        line45.SetWidth(0.10F, 0.10F);
        // Set the number of vertex fo the Line Renderer
        line45.SetVertexCount(2);
    }

    void createLine46()
    {
        // new line object
        line46 = new GameObject("Line46").AddComponent<LineRenderer>();
        // assign material
        line46.material = material;
        line46.material.color = Color.black;
        // Set the width of the Line Renderer
        line46.SetWidth(0.10F, 0.10F);
        // Set the number of vertex fo the Line Renderer
        line46.SetVertexCount(2);
    }
    void createLine47()
    {
        // new line object
        line47 = new GameObject("Line47").AddComponent<LineRenderer>();
        // assign material
        line47.material = material;
        line47.material.color = Color.black;
        // Set the width of the Line Renderer
        line47.SetWidth(0.10F, 0.10F);
        // Set the number of vertex fo the Line Renderer
        line47.SetVertexCount(2);
    }

    void createLine48()
    {
        // new line object
        line48 = new GameObject("Line48").AddComponent<LineRenderer>();
        // assign material
        line48.material = material;
        line48.material.color = Color.black;
        // Set the width of the Line Renderer
        line48.SetWidth(0.10F, 0.10F);
        // Set the number of vertex fo the Line Renderer
        line48.SetVertexCount(2);
    }
    void createLine49()
    {
        // new line object
        line49 = new GameObject("Line49").AddComponent<LineRenderer>();
        // assign material
        line49.material = material;
        line49.material.color = Color.black;
        // Set the width of the Line Renderer
        line49.SetWidth(0.10F, 0.10F);
        // Set the number of vertex fo the Line Renderer
        line49.SetVertexCount(2);
    }

    void createLine50()
    {
        // new line object
        line50 = new GameObject("Line50").AddComponent<LineRenderer>();
        // assign material
        line50.material = material;
        line50.material.color = Color.black;
        // Set the width of the Line Renderer
        line50.SetWidth(0.10F, 0.10F);
        // Set the number of vertex fo the Line Renderer
        line50.SetVertexCount(2);
    }

    void createLine51()
    {
        // new line object
        line51 = new GameObject("Line51").AddComponent<LineRenderer>();
        // assign material
        line51.material = material;
        line51.material.color = Color.black;
        // Set the width of the Line Renderer
        line51.SetWidth(0.10F, 0.10F);
        // Set the number of vertex fo the Line Renderer
        line51.SetVertexCount(2);
    }
    void createLine52()
    {
        // new line object
        line52 = new GameObject("Line52").AddComponent<LineRenderer>();
        // assign material
        line52.material = material;
        line52.material.color = Color.black;
        // Set the width of the Line Renderer
        line52.SetWidth(0.10F, 0.10F);
        // Set the number of vertex fo the Line Renderer
        line52.SetVertexCount(2);
    }

    void createLine53()
    {
        // new line object
        line53 = new GameObject("Line51").AddComponent<LineRenderer>();
        // assign material
        line53.material = material;
        line53.material.color = Color.black;
        // Set the width of the Line Renderer
        line53.SetWidth(0.10F, 0.10F);
        // Set the number of vertex fo the Line Renderer
        line53.SetVertexCount(2);
    }
    void createLine54()
    {
        // new line object
        line54 = new GameObject("Line52").AddComponent<LineRenderer>();
        // assign material
        line54.material = material;
        line54.material.color = Color.black;
        // Set the width of the Line Renderer
        line54.SetWidth(0.10F, 0.10F);
        // Set the number of vertex fo the Line Renderer
        line54.SetVertexCount(2);
    }
    void Complete()
    {
        if (bridges1To2Counter == 2 && bridges2To3Counter == 1 && bridges4To5Counter == 0 && bridges1To9Counter == 2 && bridges4To8Counter == 1 &&
            bridges2To10Counter == 2 && bridges5To7Counter == 2 && bridges3To19Counter == 1 && bridges8To7Counter == 0 && bridges7To19Counter == 1 &&
            bridges19To6Counter == 2 && bridges9To10Counter == 0 && bridges10To6Counter == 1 && bridges8To12Counter == 1 && bridges6To11Counter == 1 &&
            bridges10To14Counter == 0 && bridges9To13Counter == 1 && bridges7To18Counter == 0 && bridges12To11Counter == 2 && bridges13To14Counter == 1 &&
            bridges13To15Counter == 2 && bridges12To17Counter == 0 && bridges14To20Counter == 1 && bridges11To16Counter == 2 && bridges18To16Counter == 1 &&
            bridges17To18Counter == 1 && bridges15To20Counter == 1)
        {
            complete = true;

            if (complete)
            {
                gameObject.GetComponent<BridgesHardMode>().enabled = false;
                completedMode.SetActive(true);
            }
        }
    }
}