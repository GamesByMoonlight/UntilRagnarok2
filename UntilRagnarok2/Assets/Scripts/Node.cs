using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class Node : MonoBehaviour
{

    private GameObject turret;

    public Vector3 positionOffset;

    public Color hoverColor;
    private Color startColor;

    private Renderer rend;

    BuildManager buildManager;


    // Start is called before the first frame update
    void Start()
    {

        rend = GetComponent<Renderer>();
        startColor = rend.material.GetColor("_BaseColor");

        buildManager = BuildManager.instance;
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnMouseEnter()
    {
        if(EventSystem.current.IsPointerOverGameObject() )
        {
            return;
        }

        if (buildManager.GetTurretTobBuild() == null)
        {
            return;
        }

        rend.material.SetColor("_BaseColor", hoverColor);

    }

    private void OnMouseExit()
    {
//        rend.material.color = startColor;
        rend.material.SetColor("_BaseColor", startColor);


    }


    private void OnMouseDown()
    {
        if (EventSystem.current.IsPointerOverGameObject())
        {
            return;
        }


        if (buildManager.GetTurretTobBuild() == null)
        {
            return;
        }


        if (turret != null)
        {
            Debug.Log("Turret already placed");
        }

        GameObject turretToBuild = buildManager.GetTurretTobBuild();

        turret =  (GameObject)Instantiate(turretToBuild, transform.position + positionOffset, transform.rotation);

    }


}
