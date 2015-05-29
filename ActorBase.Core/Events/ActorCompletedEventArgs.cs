namespace ActorBase.Core
{
    using System;

    public class ActorCompletedEventArgs : EventArgs
    {
        public ActorStatus Status { get; set; }
    }
}
