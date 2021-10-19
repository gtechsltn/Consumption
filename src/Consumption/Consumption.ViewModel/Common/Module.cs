﻿namespace Consumption.ViewModel.Common
{
    using Prism.Mvvm;

    /// <summary>
    /// 模块
    /// </summary>
    public class Module : BindableBase
    {
        private string code;
        private string name;
        private int auth;
        private string typeName;

        /// <summary>
        /// 模块图标代码
        /// </summary>
        public string Code
        {
            get { return code; }
            set { code = value; RaisePropertyChanged(); }
        }

        /// <summary>
        /// 模块名称
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; RaisePropertyChanged(); }
        }

        /// <summary>
        /// 模块命名空间
        /// </summary>
        public string TypeName
        {
            get { return typeName; }
            set { typeName = value; RaisePropertyChanged(); }
        }

        /// <summary>
        /// 权限值
        /// </summary>
        public int Auth
        {
            get { return auth; }
            set { auth = value; RaisePropertyChanged(); }
        }
    }
}