﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Syncfusion.Windows.Chart;
using Syncfusion.Windows.Shared;

namespace TabControlExtDemo
{
    public class ProductModel : NotificationObject
    {
        double _prodid;
        string _prodname;
        double _price2000;
        double _price2010;
        ChartTypes _chartType;

        public double ProdId 
        { 
            get
            {
                return _prodid;
            }
            set
            {
                _prodid = value;
                RaisePropertyChanged("ProdId");
            }
        }

        public string Prodname 
        { 
            get
            {
                return _prodname;
            }
            set
            {
                _prodname = value;
                RaisePropertyChanged("Prodname");
            }
        }

        public double Price2000 
        { 
            get
            {
                return _price2000;
            }
            set
            {
                _price2000 = value;
                RaisePropertyChanged("Price2000");
            }
        }

        public double Price2010 
        { 
            get
            {
                return _price2010;
            }
            set
            {
                _price2010 = value;
                RaisePropertyChanged("Price2010");
            }
        }

        public ChartTypes ChartType 
        { 
            get
            {
                return _chartType;
            }
            set
            {
                _chartType = value;
                RaisePropertyChanged("ChartType");
            }
        }
    }
}
