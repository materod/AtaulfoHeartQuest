using UnityEngine;
using System.Collections;

public class OxygenVisibleClass : MonoBehaviour {
	
	public bool _Visible=true;
	public AtaulfoClass paquito;
	public GameObject o2Dieprefab;
	public GameObject o2Liveprefab;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		bool visible=true;
		
		if (paquito.Oxygen<9 && this.gameObject.name=="O8")
			visible=false;
		if (paquito.Oxygen<8 && this.gameObject.name=="O7")
			visible=false;
		if (paquito.Oxygen<7 && this.gameObject.name=="O6")
			visible=false;
		if (paquito.Oxygen<6 && this.gameObject.name=="O5")
			visible=false;
		if (paquito.Oxygen<5 && this.gameObject.name=="O4")
			visible=false;
		if (paquito.Oxygen<4 && this.gameObject.name=="O3")
			visible=false;
		if (paquito.Oxygen<3 && this.gameObject.name=="O2")
			visible=false;
		if (paquito.Oxygen<2 && this.gameObject.name=="O1")
			visible=false;
		if (paquito.Oxygen<1 && this.gameObject.name=="O0")
			visible=false;
		
		if (visible!=_Visible)
		{
			if (visible)
			{
				//aparece
				GameObject h= (GameObject)Instantiate (o2Liveprefab,this.transform.position,Quaternion.identity);
				h.transform.parent = this.transform;
			}
			if (!visible)
			{
				//explota
				GameObject h= (GameObject)Instantiate (o2Dieprefab,this.transform.position,Quaternion.identity);
				h.transform.parent = this.transform;

			}
			_Visible=visible;
		}
		
		renderer.enabled=visible;
	}
}
