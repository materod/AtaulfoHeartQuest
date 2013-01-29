using UnityEngine;
using System.Collections;

public class OxigenFountain : ObstacleClass {

	private static int NumOxigenUnits = 1;
	
	protected override void ActionCollide()
	{
		Ataulfo.Oxygen += NumOxigenUnits;
	}
}
