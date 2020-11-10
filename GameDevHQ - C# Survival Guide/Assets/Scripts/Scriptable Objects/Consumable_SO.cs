using UnityEngine;

namespace CSharpSurvivalGuide.ScriptableObjects
{
	[CreateAssetMenu(fileName = "New Consumable", menuName = "Inventory/Item/Consumable")]
	public class Consumable_SO : Item_SO
	{
		public int _healthPoints;
	}
}