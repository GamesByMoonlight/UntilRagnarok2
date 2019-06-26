using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node : MonoBehaviour
{

    private GameObject turret;

    public Vector3 positionOffset;

    public Color hoverColor;
    private Color startColor;

    private Renderer rend;




    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        startColor = rend.material.GetColor("_BaseColor");

    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnMouseEnter()
    {
       //rend.material.color = hoverColor;

        rend.material.SetColor("_BaseColor", hoverColor);

    }

    private void OnMouseExit()
    {
//        rend.material.color = startColor;
        rend.material.SetColor("_BaseColor", startColor);


    }


    private void OnMouseDown()
    {
        Debug.Log("OnMouseDown");

        if (turret != null)
        {
            Debug.Log("Turret already placed");
        }

        GameObject turretToBuild = BuildManager.instance.GetTurretTobBuild();
        turret =  (GameObject)Instantiate(turretToBuild, transform.position + positionOffset, transform.rotation);

    }


}
