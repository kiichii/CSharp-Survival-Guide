using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CSharpSurvivalGuide.ScriptableObjects
{
	public class SpawnManager : MonoBehaviour
	{
		//Use scriptable objects as waves
		[SerializeField] private List<Wave> _waves;
		private int _currentWaveIndex;



		private void Start()
		{
			StartCoroutine(StartSpawning());
		}

		IEnumerator StartSpawning()
		{
			while (true)
			{
				//Get the currentWave
				var currentWave = _waves[_currentWaveIndex]._enemiesToSpawn;

				//Create a parent object for the enemies
				var waveParent = new GameObject("Wave Parent");

				//Instantiate every enemie in a wave
				foreach (var enemy in currentWave)
				{
					Instantiate(enemy, waveParent.transform);
					yield return new WaitForSeconds(1f);
				}

				yield return new WaitForSeconds(5f);

				Destroy(waveParent);

				//Increase wave index
				_currentWaveIndex++;

				//Check if _currentWaveIndex is valid
				if (_currentWaveIndex == _waves.Count)
				{
					Debug.Log("Finish Spawning");
					break;
				}
			}
		}
	}
}

