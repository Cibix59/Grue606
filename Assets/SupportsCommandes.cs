using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SupportsCommandes : MonoBehaviour
{
    public ArticulationBody Supp1;
    public ArticulationBody Supp2;
    public ArticulationBody Supp3;
    public ArticulationBody Supp4;

    //
    public ArticulationBody Axe1_1;
    public ArticulationBody Axe1_2;
    public ArticulationBody Axe1_3;
    public ArticulationBody Axe1_4;

    //
    public ArticulationBody Axe2_1;
    public ArticulationBody Axe2_2;
    public ArticulationBody Axe2_3;
    public ArticulationBody Axe2_4;

    public bool enPosition = false;

    //todo : mettre la fonction dans chacun des supports, avec une valeur de target differente pour eviter la redondance ici

    // Start is called before the first frame update
    private ArticulationDrive drivePivot1;
    private ArticulationDrive drivePivot2;
    private ArticulationDrive drivePivot3;
    private ArticulationDrive drivePivot4;

    //
    private ArticulationDrive driveAxe1_1;
    private ArticulationDrive driveAxe1_2;
    private ArticulationDrive driveAxe1_3;
    private ArticulationDrive driveAxe1_4;

    //
    private ArticulationDrive driveAxe2_1;
    private ArticulationDrive driveAxe2_2;
    private ArticulationDrive driveAxe2_3;
    private ArticulationDrive driveAxe2_4;

    void Start()
    {
        drivePivot1 = Supp1.xDrive;
        drivePivot2 = Supp2.xDrive;
        drivePivot3 = Supp3.xDrive;
        drivePivot4 = Supp4.xDrive;
        //
        driveAxe1_1 = Axe1_1.xDrive;
        driveAxe1_2 = Axe1_2.xDrive;
        driveAxe1_3 = Axe1_3.xDrive;
        driveAxe1_4 = Axe1_4.xDrive;
        //
        driveAxe2_1 = Axe2_1.xDrive;
        driveAxe2_2 = Axe2_2.xDrive;
        driveAxe2_3 = Axe2_3.xDrive;
        driveAxe2_4 = Axe2_4.xDrive;
    }


    // Update is called once per frame
    void FixedUpdate()
    //todo : faire une fonction qui permet de lever et baisser les supports, en ajoutant une varialble en dessous à leur valeur fixe
    { //todo : detecter la collision entre le pied et le sol pour arreter le deploiement un peu apres
        if (Input.GetKey(KeyCode.LeftShift))
        {
            enPosition = !enPosition;
        }
        if (enPosition)
        {
            drivePivot1.target = 125;
            Supp1.xDrive = drivePivot1;

            drivePivot2.target = -125;
            Supp2.xDrive = drivePivot2;

            drivePivot3.target = -125;
            Supp3.xDrive = drivePivot3;

            drivePivot4.target = 125;
            Supp4.xDrive = drivePivot4;
            //
            driveAxe1_1.target = -65;
            Axe1_1.xDrive = driveAxe1_1;
            driveAxe1_2.target = -65;
            Axe1_2.xDrive = driveAxe1_2;
            driveAxe1_3.target = 65;
            Axe1_3.xDrive = driveAxe1_3;
            driveAxe1_4.target = 65;
            Axe1_4.xDrive = driveAxe1_4;
            //
            driveAxe2_1.target = 100;
            Axe2_1.xDrive = driveAxe2_1;
            driveAxe2_2.target = 100;
            Axe2_2.xDrive = driveAxe2_2;
            driveAxe2_3.target = -100;
            Axe2_3.xDrive = driveAxe2_3;
            driveAxe2_4.target = -100;
            Axe2_4.xDrive = driveAxe2_4;
        }
        else
        {
            drivePivot1.target = 0;
            Supp1.xDrive = drivePivot1;

            drivePivot2.target = 0;
            Supp2.xDrive = drivePivot2;

            drivePivot3.target = 0;
            Supp3.xDrive = drivePivot3;

            drivePivot4.target = 0;
            Supp4.xDrive = drivePivot4;
            //
            driveAxe1_1.target = 0;
            Axe1_1.xDrive = driveAxe1_1;
            driveAxe1_2.target = 0;
            Axe1_2.xDrive = driveAxe1_2;
            driveAxe1_3.target = 0;
            Axe1_3.xDrive = driveAxe1_3;
            driveAxe1_4.target = 0;
            Axe1_4.xDrive = driveAxe1_4;
            //
            driveAxe2_1.target = 0;
            Axe2_1.xDrive = driveAxe2_1;
            driveAxe2_2.target = 0;
            Axe2_2.xDrive = driveAxe2_2;
            driveAxe2_3.target = 0;
            Axe2_3.xDrive = driveAxe2_3;
            driveAxe2_4.target = 0;
            Axe2_4.xDrive = driveAxe2_4;
        }
    }
}
