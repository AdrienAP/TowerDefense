using UnityEngine;


public class BuildManager : MonoBehaviour {

	//Rend accessible sans référence pour les nodes :
	public static BuildManager instance;


	void Awake ()
	{
		if (instance != null) 
		{
			Debug.LogError ("PLus d'un BuildManager est lancé");
			return;
		}
		instance = this;

	}




	public GameObject standardTurretPrefab;


	public GameObject missileLauncherTurretPrefab;



	private GameObject turretToBuild;


	public GameObject GetTurretToBuild()
	{
		return turretToBuild;
	}

	public void SetTurretToBuild(GameObject turret)
	{
		turretToBuild = turret;
	}


}
