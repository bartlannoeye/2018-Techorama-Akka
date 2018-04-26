﻿using System.Collections.ObjectModel;
using System.Windows.Input;
using AkkaNetSampleStd.Messages;
using Xamarin.Forms;

namespace AkkaNetSampleStd.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        private ObservableCollection<TargetLinks> _results = new ObservableCollection<TargetLinks>();
        public ObservableCollection<TargetLinks> Results
        {
            get => _results;
            set => SetProperty(ref _results, value);
        }

        private string _url;
        public string Url
        {
            get => _url;
            set => SetProperty(ref _url, value);
        }

        private ICommand _startCrawlingCommand;
        public ICommand StartCrawlingCommand => _startCrawlingCommand ?? (_startCrawlingCommand = new Command(HandleAction));

        private void HandleAction()
        {
        }
    }
}