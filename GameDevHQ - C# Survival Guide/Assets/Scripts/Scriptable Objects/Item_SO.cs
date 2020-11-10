using UnityEngine;

namespace CSharpSurvivalGuide.ScriptableObjects
{
	[CreateAssetMenu(fileName = "New Item", menuName = "Inventory/Item", order = 1)]
	public class Item_SO : ScriptableObject
	{
		public string _name;
		public int _itemID;
		public Sprite _icon;
		public int _gold;

		public void PrintName()
		{
			Debug.Log($"Name: {_name}");
		}
	}
}