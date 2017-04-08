﻿namespace BaristaLabs.ChromeDevTools.Runtime
{
    using System;

    [AttributeUsage(AttributeTargets.Class)]
    public sealed class EventAttribute : Attribute
    {
        public string EventName
        {
            get;
        }

        public EventAttribute(string eventName)
        {
            if (String.IsNullOrWhiteSpace(eventName))
                throw new ArgumentNullException(eventName);

            EventName = EventName;
        }
    }
}
