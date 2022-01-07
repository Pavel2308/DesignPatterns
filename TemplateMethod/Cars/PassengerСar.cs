namespace TemplateMethod.Cars
{
    public class PassengerСar : Car
    {
        private const string CarType = "Легковой автомобиль";

        private decimal _maxSpeed;

        public PassengerСar(string stateNumber, string manufacturer, decimal maxSpeed)
            : base(stateNumber, manufacturer, CarType)
        {
            _maxSpeed = maxSpeed;
        }

        public void SetMaxSpeed(decimal maxSpeed)
        {
            _maxSpeed = maxSpeed;
        }

        protected override string GetSubDescription()
        {
            return $"Максимальная скорость: {_maxSpeed} км\n";
        }
    }
}
