using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildManager : MonoBehaviour
{
    public static BuildManager instance;

    private void Awake()
    {
        if (instance !=null)
        {
            Debug.LogError("More than one BuildManager in scene!");
            return;
        }

        instance = this;

    }

    public GameObject standardTurretPrefab;
    public GameObject anotherTurretPrefab;
    private TurretBlueprint turretToBuild;

    public GameObject buildEffect;


    public TurretBlueprint GetTurretTobBuild()
    {
        return turretToBuild;
    }

    public bool CanBuild { get { return turretToBuild != null; } }
    public bool HasMoney { get { return PlayerStats.Money >= turretToBuild.cost; } }

    public void BuildTurretOn(Node node)
    {
        if(PlayerStats.Money < turretToBuild.cost)
        {
            Debug.Log("Not enough money to build selection");
            return;
        }

        PlayerStats.Money -= turretToBuild.cost;

        GameObject turret = (GameObject)Instantiate(turretToBuild.prefab, node.GetBuildPosition(), Quaternion.identity);
        node.turret = turret;

        GameObject effect = (GameObject)Instantiate(buildEffect, node.GetBuildPosition(), Quaternion.identity);
        Destroy(effect, 5f);

        Debug.Log("Turret Built" + PlayerStats.Money);

    }

    public void SelectTurrretToBuild(TurretBlueprint turret)
    {
        turretToBuild = turret;
    }


}
