namespace Testing_Presentation
{
    public class Calculator
    {
        private float _currentValue = 0;

        public float CurrentValue
        {
            get { return _currentValue; }
        }

        public float Add(float num1, float num2)
        {
            _currentValue = num1 + num2;
            return _currentValue;
        }

        public float Add(float num)
        {
            _currentValue += num;
            return _currentValue;
        }

        public float Divide(float num1, float num2)
        {
            _currentValue = num1 / num2;
            return _currentValue;
        }

        public float Divide(float num)
        {
            _currentValue /= num;
            return _currentValue;
        }

        public float Multiply(float num1, float num2)
        {
            _currentValue = num1 * num2;
            return _currentValue;
        }

        public float Multiply(float num)
        {
            _currentValue *= num;
            return _currentValue;
        }

        public float Square(float num)
        {
            _currentValue = Multiply(num, num);
            return _currentValue;
        }

        public void Reset()
        {
            _currentValue = 0;
        }

        public float Square()
        {
            _currentValue *= _currentValue;
            return _currentValue;
        }

        public float Subtract(float num1, float num2)
        {
            _currentValue = num1 - num2;
            return _currentValue;
        }

        public float Subtract(float num)
        {
            _currentValue -= num;
            return _currentValue;
        }
    }
}