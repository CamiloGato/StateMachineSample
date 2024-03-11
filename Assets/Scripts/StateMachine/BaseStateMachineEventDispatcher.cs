using System;

namespace StateMachine
{
    public class BaseStateMachineEventDispatcher<TParam>
        where TParam : class
    {
        public event Action<TParam> OnEventRaised;

        public void RaiseEvent(TParam param)
        {
            OnEventRaised?.Invoke(param);
        }
    }
}