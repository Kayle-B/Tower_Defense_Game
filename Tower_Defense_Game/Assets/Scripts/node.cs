using UnityEngine;
using UnityEngine.EventSystems;
public class node : MonoBehaviour
{
    public Color hoverColor;
    public Color notEnoughMoneyColor;
    public Vector3 positionOffset;

    [Header("Optional")]
    public GameObject turret;
    
    private Renderer rend;
    private Color startColor;
    BuildManager buildManager;
 
    private void Start()
    {
        buildManager = BuildManager.instance;
        rend = GetComponent<Renderer>();
        startColor = rend.material.color;
    }

    public Vector3 GetBuildPosition()
    {
        return transform.position + positionOffset;
    }

    private void OnMouseDown()
    {
        //if(buildManager.GetTurretToBuild() == null)
        //    return;
        if (EventSystem.current.IsPointerOverGameObject())
            return;

        if (!buildManager.CanBuild)
            return;

        if (turret != null)
        {
            Debug.Log("Can't build there!");
            return; 
        }

        buildManager.BuildTurretOn(this);
        //positionOffset = new Vector3(0f, 0.4f, 0f);
        //GameObject turretToBuild = buildManager.GetTurretToBuild();
        //turret = (GameObject)Instantiate(turretToBuild, transform.position + positionOffset, transform.rotation);

    }
    void OnMouseEnter()
    {
        if (EventSystem.current.IsPointerOverGameObject())
            return;

        //if (buildManager.GetTurretToBuild() == null)
        //    return;
        if (!buildManager.CanBuild)
            return;

        //  buildManager.GetTurretToBuild() == null;

        if (buildManager.HasMoney)
        {
            rend.material.color = hoverColor;
        }
        else
        {
            rend.material.color = notEnoughMoneyColor;
        }

        //rend.material.color = hoverColor;
    }

    void OnMouseExit()
    {
        rend.material.color = startColor;
    }
}
