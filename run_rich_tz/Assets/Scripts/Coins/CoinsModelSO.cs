namespace Coins
{
    using UnityEngine;
    using System;

    [CreateAssetMenu(fileName = nameof(CoinsModelSO), menuName = "Coins/"+nameof(CoinsModelSO))]
    public class CoinsModelSO : ScriptableObject
    {
        /// <summary>
        /// parameter of currentValue
        /// </summary>
        public int CurrentValue => currentValue;

        /// <summary>
        /// event on change current value
        /// </summary>
        public event Action<int> OnValueChanged = delegate { };

        [SerializeField] protected string uniqName = default;
        [SerializeField, Min(0)] protected int initalValue = 0;
        [SerializeField] protected bool isSaveable = false;

        protected int currentValue = 0;

        protected virtual void Awake()
        {
            if(isSaveable)
            {
                currentValue = PlayerPrefs.GetInt(uniqName, 0);
            }
        }

        /// <summary>
        /// method to set value 
        /// </summary>
        /// <param name="num"></param>
        public void SetValue(int num)
        {
            currentValue = num;
            if (isSaveable)
            {
                PlayerPrefs.SetInt(uniqName, currentValue);
            }

            OnValueChanged(currentValue);
        }
    }
}