using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Collections.ObjectModel;

namespace Example
{//модель представления
    class ApplicationViewModel:INotifyPropertyChanged
    {
        private Param selectedParam;

        public ObservableCollection<Param> Parametrs { get; set; }
        public Param SelectedParam
        {
            get { return selectedParam; }
            set
            {
                selectedParam = value;
                OnPropertyChanged("SelectedParam");
             }
        }
        public ApplicationViewModel()
        {
            Parametrs = new ObservableCollection<Param>
            {
                new Param { Name="Начальное значение давления пара, МПА", Value=26},
                new Param { Name= "Начальное значение температуры пара, С" , Value=560},
                new Param { Name= "Температура питательной воды, С" , Value=272}
            };
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
