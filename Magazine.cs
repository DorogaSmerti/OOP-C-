namespace LibraryManagementSystem;

public class Magazine : LibraryItemBase
{
    public int IssueNumber { get; private set; }

    public Magazine(string title, int year, int issueNumber) : base(title, year)
    {
        IssueNumber = issueNumber;
    }

    public override string GetItemType()
    {
        return "Magazine";
    }

    public override string GetDisplayInfo()
    {
        return $"{base.GetDisplayInfo()} IssuenNumber: {IssueNumber}";
    }
}