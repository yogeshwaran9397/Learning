using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleWPF.Helper
{
    public class Person : INotifyPropertyChanged
    {
        private string fName = "";

        public string FName
        {
            get
            {
                return fName;
            }
            set
            {
                if (fName != value)
                {
                    FName = value;                    
                }
            }
        }

        private string lName = "";

        public string LName
        {
            get
            {
                return lName;
            }
            set
            {
                if (lName != value)
                {
                    LName = value;                   
                }
            }
        }

        private string fullName = "";

        public string FullName
        {
            get
            {
                return FName + " " + LName;
            }
            set
            {
                if (FName != value)
                {
                    FName = value;
                }
            }
        }


        public event PropertyChangedEventHandler? PropertyChanged;

        private void OnPropertyChange(string p)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(p));
            }
        }
    }
}
