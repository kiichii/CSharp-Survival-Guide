using UnityEngine;

namespace CSharpSurvivalGuide.Misc
{
	public class SlerpAim : MonoBehaviour
	{
		[SerializeField] private Transform _target;



		void Update()
		{
			Vector3 directionToFace = _target.position - transform.position;

			transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(directionToFace), Time.deltaTime);
		}
	}
}

