using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CSharpSurvivalGuide.Misc.PauseSystem
{
	public class Pause : MonoBehaviour
	{
		void Update()
		{
			if (Input.GetKeyDown(KeyCode.Space))
				Time.timeScale = 0.25f;

			else if (Input.GetKeyDown(KeyCode.R))
				Time.timeScale = 1f;
		}
	}
}

