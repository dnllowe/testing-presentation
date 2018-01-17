namespace Testing_Presentation
{
    public class Calculator
    {
        private float _currentValue = 0;

        public float Add(float num1, float num2)
        {
            return num1 + num2;
        }

        public float Add(float num)
        {
            _currentValue += num;
            return _currentValue;
        }

        public float Divide(float num1, float num2)
        {
            return num1 / num2;
        }

        public float Divide(float num)
        {
            _currentValue /= num;
            return _currentValue;
        }

        public float Multiply(float num1, float num2)
        {
            return num1 * num2;
        }

        public float Multiply(float num)
        {
            _currentValue *= num;
            return _currentValue;
        }

        public float Square(float num)
        {
            return Multiply(num, num);
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
            return num1 - num2;
        }

        public float Subtract(float num)
        {
            _currentValue -= num;
            return _currentValue;
        }
    }
}