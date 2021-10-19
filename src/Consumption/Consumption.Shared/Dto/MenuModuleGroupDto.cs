﻿using Consumption.Shared.DataInterfaces;
using System.Collections.ObjectModel;

namespace Consumption.Shared.Dto
{
    public class MenuModuleGroupDto
    {
        public string MenuCode { get; set; }
        public string MenuName { get; set; }
        public ObservableCollection<MenuModuleDto> Modules { get; set; }
    }

    public class MenuModuleDto : ViewModelBase
    {
        public string Name { get; set; }

        private int _value;
        private bool isChecked;

        public bool IsChecked
        {
            get { return isChecked; }
            set { isChecked = value; RaisePropertyChanged(); }
        }

        public int Value
        {
            get { return _value; }
            set { _value = value; RaisePropertyChanged(); }
        }
    }
}