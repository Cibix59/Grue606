using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum EtatMat
{
    Fixe = 0,
    Positif = 1,
    Negatif = -1
};

public class MatControleur : MonoBehaviour
{
    public EtatMat rotationEtat = EtatMat.Fixe;
    public float vitesseRotation = 70.0f;
    private ArticulationBody mat;

    // Start is called before the first frame update
    void Start() { 
        mat = GetComponent<ArticulationBody>();
    }
    void FixedUpdate()
    {
        //gestion rotation
        if (rotationEtat != EtatMat.Fixe)
        {
            float rotationChange = (float)rotationEtat * vitesseRotation * Time.fixedDeltaTime;
            float rotationGoal = AxeRotation() + rotationChange;
            RotationVers(rotationGoal);
        }
    }

    float AxeRotation()
    {
        float RotationRads = mat.jointPosition[0];
        float Rotation = Mathf.Rad2Deg * RotationRads;
        return Rotation;
    }

    void RotationVers(float primaryAxisRotation)
    {
        var drive = mat.xDrive;
        drive.target = primaryAxisRotation;
        mat.xDrive = drive;
    }
}
