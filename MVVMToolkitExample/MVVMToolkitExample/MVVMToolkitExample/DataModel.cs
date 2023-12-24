namespace MVVMToolkitExample
{
    public class DataModel
    {
        // Поле для хранения данных.
        private string _title = "";

        // Свойство для доступа и управления данными в полях
        public string Title
        {
            get => _title;
            set => _title = value;
        }

        // Методы для получения различных значений, опрделяем какое число, или знак, или команда будет передана во ViewModel и далее во View
        public string GetUpdatedTitle()
        {

            return "5";
        }

        public string GetNewTitle()
        {
            return "+";
        }

        public string GetNumber1()
        {
            return "1";
        }
        public string GetNumber2()
        {
            return "2";
        }
        public string GetNumber3()
        {
            return "3";
        }
        public string GetNumber4()
        {
            return "4";
        }
        public string GetNumber5()
        {
            return "5";
        }
        public string GetNumber6()
        {
            return "6";
        }
        public string GetNumber7()
        {
            return "7";
        }
        public string GetNumber8()
        {
            return "8";
        }
        public string GetNumber9()
        {
            return "9";
        }
        public string GetNumber0()
        {
            return "0";
        }
        public string GetPlus()
        {
            return "+";
        }

        public string GetMinus()
        {
            return "-";
        }

        public string GetEquals()
        {
            return "-";
        }

        public string GetAC()
        {
            return " ";
        }
    }
}
