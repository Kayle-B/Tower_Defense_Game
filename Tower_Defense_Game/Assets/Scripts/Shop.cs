using UnityEngine;

public class Shop : MonoBehaviour
{
    public TurretBlueprint standerdTurret;
    public TurretBlueprint missileLauncher;

    BuildManager buildManager;

    private void Start()
    {
        buildManager = BuildManager.instance;
    }
    //public void PurchaseStandartTurret()
    //{
    //    Debug.Log("turretnormal Selected");
    //    buildManager.SetTurretToBuild(buildManager.standerdTurretPrefab);
    //}
    //public void PurchaseMissileLauncher()
    //{
    //    Debug.Log("turretmissile Selected");
    //    buildManager.SetTurretToBuild(buildManager.missileLauncherPrefab);

    //}
    public void SelectStandartTurret()
    {
        Debug.Log("turretnormal Selected");
        buildManager.SelectTurretToBuild(standerdTurret);
    }
    public void SelectMissileLauncher()
    {
        Debug.Log("turretmissile Selected");
        buildManager.SelectTurretToBuild(missileLauncher);

    }
}
