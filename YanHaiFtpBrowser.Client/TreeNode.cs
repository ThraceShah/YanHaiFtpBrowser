using YanHaiFtpBrowser.IContract;

namespace YanHaiFtpBrowser.Client;


public class TreeNode:ITreeNode
{
    public string Name{ get; set; }

    public string FullPath { get; set; }

    public List<ITreeNode> Children { get; set; }

}


