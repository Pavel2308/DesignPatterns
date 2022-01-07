namespace TemplateMethod.Cars
{
    public class Truck : Car
    {
        private const string CarType = "Грузовой автомобиль";

        private decimal _capacity;

        public Truck(string stateNumber, string manufacturer, decimal capacity)
            : base(stateNumber, manufacturer, CarType)
        {
            _capacity = capacity;
        }

        public void SetCapacity(decimal capacity)
        {
            _capacity = capacity;
        }

        protected override string GetSubDescription()
        {
            return $"Грузоподъемность: {_capacity} кг\n";
        }
    }
}
