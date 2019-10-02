using UnityEngine;

public class Shop : MonoBehaviour
{
    BuildManager buildManager;

    private void Start()
    {
        buildManager = BuildManager.instance;
    }
    public void PurchaseStandartTurret()
    {
        Debug.Log("turretnormal Selected");
        buildManager.SetTurretToBuild(buildManager.standerdTurretPrefab);
    }
    public void PurchaseMissileLauncher()
    {
        Debug.Log("turretmissile Selected");
        buildManager.SetTurretToBuild(buildManager.missileLauncherPrefab);

    }
}
