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



    public GameObject GetTurretTobBuild()
    {
        return TurretToBuild;
    }


    // Start is called before the first frame update
    void Start()
    {
        TurretToBuild = standardTurretPrefab;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
