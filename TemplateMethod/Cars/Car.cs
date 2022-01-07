namespace TemplateMethod.Cars
{
    public abstract class Car
    {
        private readonly string _carType;

        private string _stateNumber;
        private string _manufacturer;

        public Car(string stateNumber, string manufacturer, string carType)
        {
            _stateNumber = stateNumber;
            _manufacturer = manufacturer;
            _carType = carType;
        }

        public void SetStateNumber(string stateNumber)
        {
            _stateNumber = stateNumber;
        }

        public void SetManufacturer(string manufacturer)
        {
            _manufacturer = manufacturer;
        }

        public string GetDescription()
        {
            return $"{_carType}\nГосномер: {_stateNumber}\nПроизводитель: {_manufacturer}\n{GetSubDescription()}";
        }

        public override string ToString() => GetDescription();

        protected abstract string GetSubDescription();
    }
}
