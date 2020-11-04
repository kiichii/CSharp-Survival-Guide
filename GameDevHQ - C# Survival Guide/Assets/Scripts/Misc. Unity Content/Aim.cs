using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CSharpSurvivalGuide.Misc
{
	public class Aim : MonoBehaviour
	{
		[SerializeField] private Transform _target;

		void Update()
		{
			//Get the direction from the target to the destination
			// direction = destination - source
			Vector3 directionToFace = _target.position - transform.position;

			//Get the current rotation and change it
			transform.rotation = Quaternion.LookRotation(directionToFace);
		}
	}
}

