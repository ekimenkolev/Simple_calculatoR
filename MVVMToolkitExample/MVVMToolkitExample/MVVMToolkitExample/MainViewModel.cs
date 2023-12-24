using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Data;
using System.Windows.Data;

namespace MVVMToolkitExample
{
    public class MainViewModel : ObservableObject
    {
        private readonly DataModel _dataModel = new DataModel();

        // Свойство Title, связанное с пользовательским интерфейсом
        public string Title
        {
            get => _dataModel.Title;
            set
            {
                if (_dataModel.Title != value)
                {
                    _dataModel.Title = value;
                    OnPropertyChanged(nameof(Title));
                }
            }
        }
        // Свойство для получения ViewModel выражения из View, те так получаем то что ввел пользователь
        private string userInput;

        public string UserInput
        {
            get => userInput;
            set => SetProperty(ref userInput, value);
        }

        // Команды связанные с кнопками в пользовательском интерфейсе
        public RelayCommand UpdateTitleCommand { get; }
        public RelayCommand NewTitleCommand { get; }
        public RelayCommand GetNumber1Command { get; }
        public RelayCommand GetNumber2Command { get; }
        public RelayCommand GetNumber3Command { get; }
        public RelayCommand GetNumber4Command { get; }
        public RelayCommand GetNumber5Command { get; }
        public RelayCommand GetNumber6Command { get; }
        public RelayCommand GetNumber7Command { get; }
        public RelayCommand GetNumber8Command { get; }
        public RelayCommand GetNumber9Command { get; }
        public RelayCommand GetNumber0Command { get; }
        public RelayCommand GetPlusCommand { get; }
        public RelayCommand GetMinusCommand { get; }
        public RelayCommand GetACCommand { get; }


        public RelayCommand ProcessUserInputCommand { get; }



        public MainViewModel()
        {
            //Инициализация команд 
            GetNumber1Command = new RelayCommand(Number1);
            GetNumber2Command = new RelayCommand(Number2);
            GetNumber3Command = new RelayCommand(Number3);
            GetNumber4Command = new RelayCommand(Number4);
            GetNumber5Command = new RelayCommand(Number5);
            GetNumber6Command = new RelayCommand(Number6);
            GetNumber7Command = new RelayCommand(Number7);
            GetNumber8Command = new RelayCommand(Number8);
            GetNumber9Command = new RelayCommand(Number9);
            GetNumber0Command = new RelayCommand(Number0);
            GetPlusCommand = new RelayCommand(GetPlus);
            GetMinusCommand = new RelayCommand(GetMinus);
            GetACCommand = new RelayCommand(GetAC);
            ProcessUserInputCommand = new RelayCommand(ProcessUserInput);
        }


        // Методы для обработки действий арифметических операций и сброса
        private void Number1()
        {
            Title += _dataModel.GetNumber1();
        }
        private void Number2()
        {
            Title += _dataModel.GetNumber2();
        }
        private void Number3()
        {
            Title += _dataModel.GetNumber3();
        }
        private void Number4()
        {
            Title += _dataModel.GetNumber4();
        }
        private void Number5()
        {
            Title += _dataModel.GetNumber5();
        }
        private void Number6()
        {
            Title += _dataModel.GetNumber6();
        }
        private void Number7()
        {
            Title += _dataModel.GetNumber7();
        }
        private void Number8()
        {
            Title += _dataModel.GetNumber8();
        }
        private void Number9()
        {
            Title += _dataModel.GetNumber9();
        }
        private void Number0()
        {
            Title += _dataModel.GetNumber0();
        }

        // Обработка введенных пользователем данных
        // Вычисляет и обновляет Title на основе текущего ввода пользователя
        public void ProcessUserInput()
        {
            Title = new DataTable().Compute(Title, null).ToString();
            Console.WriteLine(Title);
        }
        private void GetMinus()
        {
            Title += _dataModel.GetMinus();

        }
        private void GetPlus()
        {
            Title += _dataModel.GetPlus();
        }
        private void GetEquals()
        {
            Title += new DataTable().Compute(Title, null).ToString();
        }
        private void GetAC()
        {
            Title = _dataModel.GetAC();
        }
    }
}
