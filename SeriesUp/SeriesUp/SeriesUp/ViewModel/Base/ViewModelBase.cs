﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SeriesUp.ViewModel.Base
{
    public abstract class ViewModelBase : BindableObject
    {
        public string _title;

        public string Title { get { return _title; } set { _title = value; OnPropertyChanged(); } }

        public ViewModelBase(string title)
        {
            Title = title;
        }

        public virtual Task InitializeAsync(object navigationData)
        {
            return Task.FromResult(true);
        }

    }
}
