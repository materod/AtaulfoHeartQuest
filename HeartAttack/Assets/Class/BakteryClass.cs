using UnityEngine;
using System.Collections;

public class BakteryClass : ObstacleClass {
	
	private static int NumOxigenUnits = 3;
	
	protected override void ActionCollide()
	{
		if(Ataulfo.State!= AtaulfoClass.AtaulfoStates.PumkinGodMode)
		{
			Ataulfo.Oxygen -= NumOxigenUnits;
		}
		else
			Destroy(this.gameObject);	
	}
	
	protected override void BulletCollide()
	{
		Destroy(this.gameObject);
	}
}

