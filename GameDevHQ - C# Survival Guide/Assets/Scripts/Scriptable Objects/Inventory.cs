using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CSharpSurvivalGuide.ScriptableObjects
{
	public class Inventory : MonoBehaviour
	{
		public List<Item_SO> _itemDatabase;

		void Start()
		{
			_itemDatabase.ForEach(e => e.PrintName());
		}
	}
}