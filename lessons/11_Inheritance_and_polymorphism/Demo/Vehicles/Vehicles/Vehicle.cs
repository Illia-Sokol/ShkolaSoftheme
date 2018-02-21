using System;

namespace Vehicles
{
    public abstract class Vehicle
    {
        private bool _engineStarted;

        public void StartEngine(string noiseToMakeWhenStarting)
        {
            Console.WriteLine("Starting engine: {0}", noiseToMakeWhenStarting);
            _engineStarted = true;
        }

        public void StopEngine(string noiseToMakeWhenStopping)
        {
            Console.WriteLine("Stopping engine: {0}", noiseToMakeWhenStopping);
            _engineStarted = false;
        }

        public void Drive()
        {
            if (!_engineStarted)
            {
                throw new InvalidOperationException("Drive failed, engine is not started!");
            }

            DriveInternal();
        }

        protected abstract void DriveInternal();
    }
}
