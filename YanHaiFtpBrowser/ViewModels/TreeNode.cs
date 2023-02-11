using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YanHaiFtpBrowser.IContract;

namespace YanHaiFtpBrowser.ViewModels
{
    internal class TreeNode : ViewModelBase,ITreeNode
    {

        /// <summary>
        /// name
        /// </summary>
        private string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public string FullPath { get; set; }

        public List<ITreeNode> Children { get; set; }

        public static implicit operator TreeNode(string name)
        {
            return new TreeNode { Name = name };
        }

        public static implicit operator string(TreeNode node)
        {
            return node.Name;
        }

    }
}
