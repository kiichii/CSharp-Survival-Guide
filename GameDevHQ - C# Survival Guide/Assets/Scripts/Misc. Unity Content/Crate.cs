using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CSharpSurvivalGuide.Misc
{
	public class Crate : MonoBehaviour
	{
		[SerializeField] private GameObject _fracturedCrate;
		[SerializeField] private GameObject _explosionPrefab;
		[SerializeField] private float _explosionForce;



		void Update()
		{
			if (Input.GetKeyDown(KeyCode.Space))
			{
				Instantiate(_explosionPrefab, transform.position, Quaternion.identity);
				GameObject fracturedCrateObject = Instantiate(_fracturedCrate, transform.position, Quaternion.identity);
				 

				Rigidbody[] crateParts = fracturedCrateObject.GetComponentsInChildren<Rigidbody>();
				if(crateParts.Length > 0)
				{
					foreach (var parts in crateParts)
					{
						parts.AddExplosionForce(_explosionForce, transform.position, 1f);
					}
				}

				Destroy(this.gameObject);
			}
		}
	}
}
