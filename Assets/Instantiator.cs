using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Instantiator : MonoBehaviour
{
    public GameObject objectToClone;
    public int cloneAmount;
    public Text txtCloneAmount;
    GameObject clon;

    public void MultiInstantiate() //funcion de tipo void
    {
        cloneAmount = int.Parse(txtCloneAmount.text); //cloneamount = limite de counter y depsues lo convertimos a int
        //int counter = 0;

        for (int counter = 0; counter < cloneAmount; counter++) //counter es lo mismo que i, osea podemos reemplazarlo por i.
        {
            clon = Instantiate(objectToClone); //instantiate es el empty. Le dice que se clone. //instantia es una funcion de tipo gameobject, creo.
            Destroy(clon, 1); //destruir clon despues de 1 segundo.
        }
    }
}
