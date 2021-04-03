using System;
using System.Collections.Generic;
using System.Text;


namespace eShop.StateStore.DI
{
    public class StateStoreBase : eShop.UseCases.PluginInterfaces.StateStore.IStateStore
    {
        protected Action listeners;
        public void AddStateChangeListeners(Action listener) => this.listeners += listener;
        public void RemoveStateChangeListeners(Action listener) => this.listeners -= listener;

        public void BroadCastStateChange()
        {
            if (this.listeners != null) this.listeners.Invoke();
        }
    }
}
