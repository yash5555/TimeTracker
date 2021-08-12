﻿using Xamarin.Forms.Internals;

namespace TimeTracking.Behaviors
{
    [Preserve(AllMembers = true)]
    public interface IAction
    {
        bool Execute(object sender, object parameter);
    }
}