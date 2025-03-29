namespace Interactables
{
    using Coins;
    using UnityEngine;

    public class CoinIncreaseBottle : AbstractInteractiable
    {
        [SerializeField] protected CoinsModelSO coins = default;
        [SerializeField, Min(1)] protected int valueToIncrease = 1;
        
        protected int tempValue = default;

        public override void OnInteracted()
        {
            base.OnInteracted();
            tempValue = coins.CurrentValue + valueToIncrease;
            coins.SetValue(tempValue);
        }
    }
}