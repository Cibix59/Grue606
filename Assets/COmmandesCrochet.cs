using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class COmmandesCrochet : MonoBehaviour
{
    public ArticulationBody crochet;
    public float vitesse = 1.0f;

    public enum EtatCrochet
    {
        Fixe = 0,
        Positif = 1,
        Negatif = -1
    };

    public EtatCrochet translationEtat = EtatCrochet.Fixe;

    // Start is called before the first frame update
    void Start() { }



    // Update is called once per frame
    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.R))
        {
            translationEtat = EtatCrochet.Negatif;
        }
        else if (Input.GetKey(KeyCode.F))
        {
            translationEtat = EtatCrochet.Positif;
        }
        else
        {
            translationEtat = EtatCrochet.Fixe;
        }

        if (translationEtat != EtatCrochet.Fixe)
        {
            var drive = crochet.zDrive;

            if (translationEtat == EtatCrochet.Positif)
            {
                drive.targetVelocity = -1.0f;
            }
            else
            {
                drive.targetVelocity = 0.0f;
            }
            crochet.zDrive = drive;
        }
    }
}
