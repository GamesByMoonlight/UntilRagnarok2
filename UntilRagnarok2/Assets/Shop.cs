﻿using UnityEngine;

public class Shop : MonoBehaviour
{

    BuildManager buildManager;

    public void Start()
    {
        buildManager = BuildManager.instance;
    }

    public void PurchaseStandardTurret()
    {

        Debug.Log("Standard Turret Purchase");

        buildManager.SetTurretToBuild(buildManager.standardTurretPrefab);

    }

    public void PurchaseAnotherTurret()
    {

        Debug.Log("Another Turret Purchase");

        buildManager.SetTurretToBuild(buildManager.anotherTurretPrefab);

    }

}
