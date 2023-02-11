using System;
using System.Collections;
using System.Collections.Generic;

namespace YanHaiFtpBrowser.IContract
{
    public interface ITreeNode
    {
        public string Name{ get; set; }

        public string FullPath { get; set; }

        public List<ITreeNode> Children { get; set; }
    }
}
