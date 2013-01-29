using UnityEngine;
using System.Collections;

public class CholesterolClass : ObstacleClass {

	protected override void ActionCollide()
	{
		if(Ataulfo.State!= AtaulfoClass.AtaulfoStates.PumkinGodMode)
			Ataulfo.State = AtaulfoClass.AtaulfoStates.Dead;
		else
			Destroy(this.gameObject);
	}
	
	protected override void BulletCollide()
	{
		Destroy(this.gameObject);
	}
}
