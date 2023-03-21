using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatCommandes : MonoBehaviour
{
    public GameObject Mat;
    public MatControleur controller;
    private float input;

    // Start is called before the first frame update
    void Start()
    {
        /* input = Input.GetAxis("Mat"); */
        controller = Mat.GetComponent<MatControleur>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        controller.rotationEtat = EtatTranslationPrInput();
    }

    EtatMat EtatTranslationPrInput(/* float input */)
    {
        if (Input.GetKey(KeyCode.A))
        {
            return EtatMat.Negatif;
        }
        else if (Input.GetKey(KeyCode.E))
        {
            return EtatMat.Positif;
        }
        else
        {
            return EtatMat.Fixe;
        }
        /*         if (input > 0)
                {
                    return EtatMat.Positif;
                }
                else if (input < 0)
                {
                    return EtatMat.Negatif;
                }
                else
                {
                    return EtatMat.Fixe;
                } */
    }
}
