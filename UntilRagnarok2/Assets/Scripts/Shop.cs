using UnityEngine;

public class Shop : MonoBehaviour
{

    public TurretBlueprint standardTurret;
    public TurretBlueprint AnotherTurret;

    BuildManager buildManager;

    public void Start()
    {
        buildManager = BuildManager.instance;
    }

    public void SelectStandardTurret()
    {
        buildManager.SelectTurrretToBuild(standardTurret);

    }

    public void SelectAnotherTurret()
    {
        buildManager.SelectTurrretToBuild(AnotherTurret);

    }

}
