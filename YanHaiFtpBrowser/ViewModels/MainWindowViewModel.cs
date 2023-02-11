using System;
using System.Collections.Generic;
using System.Reactive;
using System.Text;
using ReactiveUI;

namespace YanHaiFtpBrowser.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        /// <summary>
        /// hostname
        /// </summary>
        private string _hostName;
        public string HostName
        {
            get => _hostName;
            set
            {
                _hostName = value;
            }
        }

        /// <summary>
        /// username
        /// </summary>
        private string _userName;
        public string UserName
        {
            get
            {
                return _userName;
            }
            set
            {
                _userName = value;
            }
        }

        /// <summary>
        /// password
        /// </summary>
        private string _passWord;
        public string Password
        {
            get
            {
                return _passWord;
            }
            set
            {
                _passWord = value;
            }
        }

        /// <summary>
        /// encoding
        /// </summary>
        private List<string> _encoding = new List<string> 
        { "gbk", "utf-8" };
        public List<string> Encoding
        {
            get
            {
                return _encoding;
            }
            set
            {
                _encoding = value;
            }
        }

        internal List<TreeNode> TreeContent { get; set; } = 
        new List<TreeNode>() { "第一", "第二", "第三" };

        internal List<TreeNode> ListContent { get; set; } = 
        new List<TreeNode>() { "firsr", "second", "third" };

        internal ReactiveCommand<Unit, Unit> ConnectCMD { get; }

        internal MainWindowViewModel()
        {
           this.ConnectCMD = ReactiveCommand.Create(this.Connect);
        }


        void Connect()
        {

        }

    }
}
