using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CSharpSurvivalGuide.ScriptableObjects
{
	[CreateAssetMenu(fileName = "New Wave", menuName = "New Wave")]
	public class Wave : ScriptableObject
	{
		//Each wave has list of enemies to spawn
		public List<GameObject> _enemiesToSpawn;
	}
}

