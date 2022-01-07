namespace TemplateMethod.Cars
{
    public class PublicTransport : Car
    {
        private const string CarType = "Общественный транспорт";

        private int _capacity;

        public PublicTransport(string stateNumber, string manufacturer, int capacity)
            : base(stateNumber, manufacturer, CarType)
        {
            _capacity = capacity;
        }

        public void SetCapacity(int capacity)
        {
            _capacity = capacity;
        }

        protected override string GetSubDescription()
        {
            return $"Вместимость: {_capacity} человек\n";
        }
    }
}
