using UnityEngine;

namespace CSharpSurvivalGuide.ScriptableObjects
{
	[CreateAssetMenu(fileName = "New Equipable", menuName = "Inventory/Item/Equipable")]
	public class Equipable_SO : Item_SO
	{
		public int attack, strength, defense, weight;
	}
}