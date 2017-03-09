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

	void Start()
	{
		turretToBuild = standardTurretPrefab;
	}


	private GameObject turretToBuild;


	public GameObject GetTurretToBuild()
	{
		return turretToBuild;
	}



}
