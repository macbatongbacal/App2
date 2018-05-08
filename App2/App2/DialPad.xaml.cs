using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DialPad : ContentPage
	{
		public DialPad ()
		{
			InitializeComponent ();
		}
	}
    //class KeypadViewModel : INotifyPropertyChanged
    //{
    //    string _inputString = "";
    //    string _displayText = "";

    //    public event PropertyChangedEventHandler PropertyChanged;

    //    // Constructor
    //    public KeypadViewModel()
    //    {
    //        AddCharCommand = new Command<string>((key) =>
    //        {
    //            // Add the key to the input string.
    //            InputString += key;
    //        });

    //    }

    //    // Public properties
    //    public string InputString
    //    {
    //        protected set
    //        {
    //            if (_inputString != value)
    //            {
    //                _inputString = value;
    //                OnPropertyChanged("InputString");
    //                DisplayText = FormatText(_inputString);

    //                // Perhaps the delete button must be enabled/disabled.
    //                ((Command)DeleteCharCommand).ChangeCanExecute();
    //            }
    //        }

    //        get { return _inputString; }
    //    }

    //    public string DisplayText
    //    {
    //        protected set
    //        {
    //            if (_displayText != value)
    //            {
    //                _displayText = value;
    //                OnPropertyChanged("DisplayText");
    //            }
    //        }
    //        get { return _displayText; }
    //    }

    //    // ICommand implementations
    //    public ICommand AddCharCommand { protected set; get; }

    //    public ICommand DeleteCharCommand { protected set; get; }

    //    string FormatText(string str)
    //    {
    //        //bool hasNonNumbers = str.IndexOfAny(specialChars) != -1;
    //        string formatted = str;

    //        //if (hasNonNumbers || str.Length < 4 || str.Length > 10)
    //        //{
    //        //}
    //        if (str.Length < 8)
    //        {
    //            formatted = String.Format("{0}-{1}",
    //                                      str.Substring(0, 3),
    //                                      str.Substring(3));
    //        }
    //        else
    //        {
    //            formatted = String.Format("({0}) {1}-{2}",
    //                                      str.Substring(0, 3),
    //                                      str.Substring(3, 3),
    //                                      str.Substring(6));
    //        }
    //        return formatted;
    //    }

    //    protected void OnPropertyChanged(string propertyName)
    //    {
    //        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    //    }
    //}

}