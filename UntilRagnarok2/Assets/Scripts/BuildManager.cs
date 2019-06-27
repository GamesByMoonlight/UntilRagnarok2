using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildManager : MonoBehaviour
{

    private GameObject TurretToBuild;

    public static BuildManager instance;

    private void Awake()
    {
        
        instance = this;

    }

    public GameObject standardTurretPrefab;
    public GameObject anotherTurretPrefab;


    public GameObject GetTurretTobBuild()
    {
        return TurretToBuild;
    }


    // Update is called once per frame
    void Update()
    {


    }


    public void SetTurretToBuild(GameObject turret)
    {
        TurretToBuild = turret;
    }

}
