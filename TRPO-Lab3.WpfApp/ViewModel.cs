using System.ComponentModel;
using TRPO_Lab3.Lib;
using System.ComponentModel.DataAnnotations;

namespace TRPO_Lab3.WpfApp
{
    public class MainViewModel : INotifyPropertyChanged
    {
        [Range(0, double.MaxValue, ErrorMessage = "Допустимы только значения больше 0.")]
        private double _radius;
        [Range(0, double.MaxValue, ErrorMessage = "Допустимы только значения больше 0.")]
        private double _height;
        private double _surfaceArea;

        public double Radius
        {
            get { return _radius; }
            set
            {
                if (_radius != value)
                {
                    _radius = value;
                    OnPropertyChanged(nameof(Radius));
                    CalculateSurfaceArea();
                }
            }
        }

        public double Height
        {
            get { return _height; }
            set
            {
                if (_height != value)
                {
                    _height = value;
                    OnPropertyChanged(nameof(Height));
                    CalculateSurfaceArea();
                }
            }
        }

        public double SurfaceArea
        {
            get { return _surfaceArea; }
            set
            {
                if (_surfaceArea != value)
                {
                    _surfaceArea = value;
                    OnPropertyChanged(nameof(SurfaceArea));
                }
            }
        }

        private void CalculateSurfaceArea()
        {
            var cylinder = new Cylinder();
            SurfaceArea = cylinder.SurfArea(Radius, Height);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}