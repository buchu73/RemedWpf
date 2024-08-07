using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfApp.ViewModel
{
    public class MainViewModel : INotifyPropertyChanged
    {
        #region INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        #endregion

        #region private methods

        private void OnIncrementClick()
        {
            IncrementedValue = IncrementedValue + 1;
        }

        private void OnCopyClick()
        {
            this.CopyUserValue = this.UserValue;
        }

        #endregion

        public MainViewModel()
        {
            this.CopyCommand = new RelayCommand(this.OnCopyClick);
            this.IncrementCommand = new RelayCommand(this.OnIncrementClick);
            this.IncrementedValue = -5;
        }      

        private string _copyUserValue;
        public string CopyUserValue
        {
            get { return _copyUserValue; }
            set
            {
                if (_copyUserValue != value)
                {
                    _copyUserValue = value;
                    this.OnPropertyChanged("CopyUserValue");
                }
            }
        }

        private string _userValue;
        public string UserValue
        {
            get { return _userValue; }
            set
            {
                if (_userValue != value)
                {
                    _userValue = value;
                    OnPropertyChanged("UserValue");
                }
            }
        }

        private int _incrementedValue;
        public int IncrementedValue
        {
            get { return _incrementedValue; }
            set
            {
                if (_incrementedValue != value)
                {
                    _incrementedValue = value;
                    OnPropertyChanged("IncrementedValue");
                }
            }
        }

        public ICommand CopyCommand { get; private set; }
        public ICommand IncrementCommand { get; private set; }      
    }
}
