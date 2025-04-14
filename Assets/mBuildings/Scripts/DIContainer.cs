using UnityEngine;

namespace DI
{
    public class DIContainer
    {
        private readonly DIContainer _parentContainer;

        public DIContainer(DIContainer parentContainer)
        {
                _parentContainer = parentContainer;
        }
    }
}
