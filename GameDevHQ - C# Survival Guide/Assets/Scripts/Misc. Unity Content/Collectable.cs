using UnityEngine;

namespace CSharpSurvivalGuide.Misc.CollectableGameObject
{
	public class Collectable : MonoBehaviour
	{
		private void OnTriggerEnter(Collider other)
		{
			if(other.tag == "Player")
			{
				//Do Things

				Destroy(this.gameObject);
			}
		}
	}
}

