namespace Coins
{
    using UnityEngine;
    using UnityEngine.UI;

    [RequireComponent(typeof(Text))]
    public class CoinsTextView : MonoBehaviour
    {
        [SerializeField] protected CoinsModelSO coins = default;
        
        protected Text text = default;
        
        protected virtual void Awake()
            => text = GetComponent<Text>();

        protected virtual void OnEnable()
            => coins.OnValueChanged += UpdatetextValue;

        protected virtual void OnDisable()
            => coins.OnValueChanged -= UpdatetextValue;

        protected virtual void UpdatetextValue(int value)
            => text.text = value.ToString();
    }
}
