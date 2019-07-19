using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node : MonoBehaviour
{
    [Header("Optional")]
    public GameObject turret;

    public Vector3 positionOffset;

    public Color hoverColor;
    public Color notEnoughMoneyColor;
    private Color startColor;

    private Renderer rend;

    BuildManager buildManager;


 
    void Start()
    {

        rend = GetComponent<Renderer>();
        startColor = rend.material.GetColor("_BaseColor");

        buildManager = BuildManager.instance;
    }

    private void OnMouseEnter()
    {

        if (!buildManager.CanBuild)
        {
            return;
        }

        if (buildManager.HasMoney)
        {
            rend.material.SetColor("_BaseColor", hoverColor);
        }
        else
        {
            rend.material.SetColor("_BaseColor", notEnoughMoneyColor);
        }
    }

    private void OnMouseExit()
    {
        rend.material.SetColor("_BaseColor", startColor);
    }


    private void OnMouseDown()
    {
        if(!buildManager.CanBuild)
        {
            return;
        }

        if (turret != null)
        {
            Debug.Log("Turret already placed");
        }

        buildManager.BuildTurretOn(this);

    }

    public Vector3 GetBuildPosition()
    {
        return transform.position + positionOffset;
    }

}
