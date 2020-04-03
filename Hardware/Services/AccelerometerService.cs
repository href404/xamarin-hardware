using Hardware.Models;
using System;
using System.Diagnostics;
using Xamarin.Essentials;

namespace Hardware.Services
{
    public class AccelerometerService
    {
        private readonly SensorSpeed Speed = SensorSpeed.UI;
        private AccelerometerModel Model;

        public AccelerometerService()
        {
            Accelerometer.ReadingChanged += Accelerometer_ReadingChanged;
        }

        public AccelerometerModel Get()
        {
            if (Model == null)
                Model = new AccelerometerModel();
            
            return Model;
        }

        public void Start()
        {
            try
            {
                if (Accelerometer.IsMonitoring)
                    return;
                    
                Accelerometer.Start(Speed);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
            }
        }

        public void Stop()
        {
            try
            {
                if (!Accelerometer.IsMonitoring)
                    return;

                Accelerometer.Stop();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
            }
        }

        private void Accelerometer_ReadingChanged(object sender, AccelerometerChangedEventArgs e)
        {
            Model.X = e.Reading.Acceleration.X;
            Model.Y = e.Reading.Acceleration.Y;
            Model.Z = e.Reading.Acceleration.Z;
        }
    }
}
