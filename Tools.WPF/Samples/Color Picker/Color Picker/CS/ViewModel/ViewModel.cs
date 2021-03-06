﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Syncfusion.Windows.Shared;
using System.Windows.Input;
using System.Collections.ObjectModel;

namespace ColorPickerDemo
{
    public class ViewModel : NotificationObject
    {
        public ViewModel()
        {
            colorChangedLogCommand = new DelegateCommand<object>(PropertyChangedHandler);
        }

        private ICommand colorChangedLogCommand;

        private ObservableCollection<string> eventlog = new ObservableCollection<string>();

        public ObservableCollection<string> EventLog
        {
            get { return eventlog; }
            set { eventlog = value; }
        }
        public ICommand ColorChanged
        {
            get
            {
                return colorChangedLogCommand;
            }
        }
        public void PropertyChangedHandler(object param)
        {
            EventLog.Add("Color Changed:" + param.ToString());
        }

    }
}
