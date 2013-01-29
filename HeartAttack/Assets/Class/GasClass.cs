using UnityEngine;
using System.Collections;

public class GasClass : ObstacleClass {

	protected override void ActionCollide()
	{
		if(Ataulfo.State!= AtaulfoClass.AtaulfoStates.PumkinGodMode)
			Ataulfo.State = AtaulfoClass.AtaulfoStates.Confused;
		else
			Destroy(this.gameObject);
	}
}
