using UnityEngine;
using UnityEngine.Events;

namespace UniCraft.MonoBehaviourEvent
{
    /// <inheritdoc/>
    /// <summary>
    /// Module to synchronize actions with MonoBehaviour functions
    /// </summary>
    [AddComponentMenu("UniCraft/MonoBehaviourEvent")]
    [DisallowMultipleComponent]
    public sealed class MonoBehaviourEvent : MonoBehaviour
    {
        ///////////////////////////////
        ////////// Attribute //////////
        ///////////////////////////////

        [Header("Activation")]
        [SerializeField] private UnityEvent _onEnableEvents = null;
        [SerializeField] private UnityEvent _onDisableEvents = null;
        
        [Header("Start")]
        [SerializeField] private UnityEvent _onStartEvents = null;
        
        [Header("Update")]
        [SerializeField] private UnityEvent _onPhysicsUpdateEvents = null;
        [SerializeField] private UnityEvent _onUpdateEvents = null;
        
        ////////////////////////////
        ////////// Method //////////
        ////////////////////////////

        private void Start()
        {
            _onStartEvents.Invoke();
        }

        private void FixedUpdate()
        {
            _onPhysicsUpdateEvents.Invoke();
        }

        private void Update()
        {
            _onUpdateEvents.Invoke();
        }

        private void OnEnable()
        {
            _onEnableEvents.Invoke();
        }

        private void OnDisable()
        {
            _onDisableEvents.Invoke();
        }
    }
}
