using UnityEngine;


public class Shop : MonoBehaviour {

	BuildManager buildManager;

	void Start ()
	{
		buildManager = BuildManager.instance;
	}



	public void PurchaseStandardTurret ()
	{
		Debug.Log ("Tourelle Standard Séléctionée");
		buildManager.SetTurretToBuild(buildManager.standardTurretPrefab);

	}

	public void PurchaseMissileLauncher ()
	{

		Debug.Log ("Lance Missile Séléctionée");
		buildManager.SetTurretToBuild(buildManager.missileLauncherTurretPrefab);

	}



}
