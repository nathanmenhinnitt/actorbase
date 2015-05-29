namespace ActorBase.Core
{
    using System;

    public struct Actor<T>
    {
        private readonly Func<ActorStatus, Actor<T>> _completeFunction;

        public Actor(Func<ActorStatus, Actor<T>> completeFunction)
        {
            _completeFunction = completeFunction;
        }

        public void RunTask()
        {
            _completeFunction(ActorStatus.Completed);
        }
    }
}