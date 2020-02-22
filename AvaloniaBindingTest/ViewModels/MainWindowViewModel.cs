using System;
using System.Collections.Generic;
using System.Text;
using ReactiveUI;

namespace AvaloniaBindingTest.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private string _str = "#0000";
        public string String
        {
            get => _str;
            set
            {
                if (value != null && value.Length > 0 && value[0] == '#' && value.Length <= 5)
                {
                    _str = value;
                }

                this.RaisePropertyChanged(nameof(String));
            }
        }
    }
}
