﻿using System;
using System.Collections.Generic;
using System.Text;

namespace eShop.UseCases.PluginInterfaces.StateStore
{
    public interface IStateStore
    {
        void AddStateChangeListeners(Action listener);
        void RemoveStateChangeListeners(Action listener);
        void BroadCastStateChange();
    }
}
