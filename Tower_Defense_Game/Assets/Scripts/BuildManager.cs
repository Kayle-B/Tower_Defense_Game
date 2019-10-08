using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildManager : MonoBehaviour
{
    public static BuildManager instance;

    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogError("More than one BuildManger in scene!");
            return;
        }
        instance = this;

    }
    public GameObject standerdTurretPrefab;
    public GameObject missileLauncherPrefab;

    public GameObject buildEffect;

    private TurretBlueprint turretToBuild;

    public bool CanBuild { get { return turretToBuild != null; } }
    public bool HasMoney { get { return playerStats.Money >= turretToBuild.cost; } }

    public void BuildTurretOn (node node)
    {
        if (playerStats.Money < turretToBuild.cost)
        {
            Debug.Log("Not enough money to built!");
            return;
        }

        playerStats.Money -= turretToBuild.cost;

        GameObject turret = (GameObject)Instantiate(turretToBuild.prefab, node.GetBuildPosition(), Quaternion.identity);
        node.turret = turret;

        GameObject effect = (GameObject)Instantiate(buildEffect, node.GetBuildPosition(), Quaternion.identity);
        Destroy(effect, 5f);

        Debug.Log("Turret build! Money left: " + playerStats.Money);
    }

    //public GameObject GetTurretToBuild()
    //{
    //    return turretToBuild;
    //}

    //public void SetTurretToBuild(GameObject turret)
    //{
    //    turretToBuild = turret;
    //}

    public void SelectTurretToBuild(TurretBlueprint turret)
    {
        turretToBuild = turret;
    }
}
