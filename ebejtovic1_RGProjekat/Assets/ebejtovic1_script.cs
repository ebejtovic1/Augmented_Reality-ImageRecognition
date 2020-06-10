using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ebejtovic1_script : MonoBehaviour {
    Ray ray;
    RaycastHit hit;

    public GameObject videoPlane;
    public GameObject videoPOI;

    public GameObject slikaPlane;
    public GameObject slikaPOI;

    public GameObject tekst;
    public GameObject tekstPOI;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if(Physics.Raycast(ray, out hit))
        {
            if(hit.collider.gameObject.name== "ebejtovic1_videoPOI")
            {
                videoPOI.SetActive(false);
                videoPlane.SetActive(true);   
            }

            if (hit.collider.gameObject.name == "ebejtovic1_planeVideo")
            {
                videoPlane.SetActive(false);
                videoPOI.SetActive(true);
            }

            if (hit.collider.gameObject.name == "ebejtovic1_planeSlika")
            {
                slikaPlane.SetActive(false);
                slikaPOI.SetActive(true);
            }

            if (hit.collider.gameObject.name == "ebejtovic1_slikaPOI")
            {
                slikaPlane.SetActive(true);
                slikaPOI.SetActive(false);
            }

            if (hit.collider.gameObject.name == "ebejtovic1_tekstPOI")
            {
                tekstPOI.SetActive(false);
                tekst.SetActive(true);
                
            }

            if (hit.collider.gameObject.name == "ebejtovic1_tekst")
            {
                tekst.SetActive(false);
                tekstPOI.SetActive(true);
            }


        }
		
	}

   
}
