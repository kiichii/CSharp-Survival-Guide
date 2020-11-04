using UnityEngine;

namespace CSharpSurvivalGuide.Misc.SimpleMovement
{
	public class PlayerMovement : MonoBehaviour
	{
		[SerializeField] private float _speed = 1;

		// Update is called once per frame
		void Update()
		{
			float horizontalInput = Input.GetAxis("Horizontal");
			transform.Translate(new Vector3(horizontalInput, 0, 0) * _speed * Time.deltaTime);
		}
	}
}

