using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ebejtovic1_skripta2 : MonoBehaviour {

    // Use this for initialization
    public GameObject infoTekst;
    public GameObject helpTekst;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void funkcijaOnClick()
    {
        Application.Quit();
    }

    public void funkcijaInfo()
    {
        if (infoTekst.activeInHierarchy == true)
        {
            infoTekst.SetActive(false);
        }
        else { 
            infoTekst.SetActive(true);
        }
    }

    public void funkcijaHelp()
    {
        if (helpTekst.activeInHierarchy == true)
        {
            helpTekst.SetActive(false);
        }
        else
        {
            helpTekst.SetActive(true);
        }
    }
}
