using UnityEngine;
using System.Collections;

public class GreenSlimeClass : ObstacleClass {

	protected override void ActionCollide()
	{
		if(Ataulfo.State!= AtaulfoClass.AtaulfoStates.PumkinGodMode)
			Ataulfo.State = AtaulfoClass.AtaulfoStates.Slimed;
		else
			Destroy(this.gameObject);
	}
}

