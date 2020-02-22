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
                if (_str != null && _str.Length > 0 && _str[0] == '#' && _str.Length <= 5)
                {
                    _str = value;
                }

                this.RaisePropertyChanged(nameof(String));
            }
        }
    }
}
