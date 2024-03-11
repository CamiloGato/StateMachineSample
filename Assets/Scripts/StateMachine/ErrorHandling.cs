using System;

namespace StateMachine
{
    public class MissingStateException : Exception
    {
        public MissingStateException(Enum stateEnum)
            : base($"State not found for enum: {stateEnum}") {}
    }

    public class MissingDefaultStateException : Exception
    {
        public MissingDefaultStateException()
            : base("No Default Transition State Defined") {}
    }
}