namespace Interactables
{
    using Coins;
    using UnityEngine;

    public class CoinDecreaseBottle : AbstractInteractiable
    {
        [SerializeField] protected CoinsModelSO coins = default;
        [SerializeField, Min(1)] protected int valueToDecrease = 1;

        protected int tempValue = default;

        public override void OnInteracted()
        {
            base.OnInteracted();
            tempValue = coins.CurrentValue - valueToDecrease;
            coins.SetValue(tempValue);
        }
    }
}