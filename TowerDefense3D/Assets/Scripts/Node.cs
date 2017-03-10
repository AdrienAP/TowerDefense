using UnityEngine;
using UnityEngine.EventSystems;

public class Node : MonoBehaviour {

	public Color hoverColor;
	public Vector3 positionOffset;

	private GameObject turret;


	private Renderer rend;
	private Color startColor;
	BuildManager buildManager;



	void Start()
	{
		
		rend = GetComponent<Renderer> ();
		startColor = rend.material.color;

		buildManager = BuildManager.instance;
	}

	void OnMouseDown()
	{

		//Permet de ne pas crée de tourelle si on hover l'UI
		if (EventSystem.current.IsPointerOverGameObject ())
			return;

		if (buildManager.GetTurretToBuild() == null) {
			return;
		}
		

		if (turret != null) 
		{
			Debug.Log ("Tu ne peux pas construire ici ! - TODO : L'afficher sur l'UI.");
			return;
		}


		//Construire une tour
		GameObject turretToBuild = buildManager.GetTurretToBuild();
		turret = (GameObject) Instantiate (turretToBuild, transform.position + positionOffset, transform.rotation);
	}







	void OnMouseEnter()
	{
		//Permet de ne pas crée de tourelle si on hover l'UI
		if (EventSystem.current.IsPointerOverGameObject ())
			return;

		//Ne pas changer la couleur d'une Node si l'on a pas séléctionné une Tour
		if (buildManager.GetTurretToBuild() == null) 
			return;


		//Permet de changer la couleur d'une Node pour l'utilisateur lorsqu'il a séléctionner une tour
		rend.material.color = hoverColor;

	}


	void OnMouseExit()
	{
		//Remet la couleur qu'on a Set dans Start() pour l'utilisateur
		rend.material.color = startColor;
	}




}
