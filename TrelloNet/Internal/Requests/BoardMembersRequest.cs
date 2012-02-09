namespace TrelloNet.Internal.Requests
{
	internal class BoardMembersRequest : BoardRequest
	{
		public BoardMembersRequest(IBoardId boardId, MemberFilter filter)
			: base(boardId, "members")
		{			
			this.AddFilter(filter);
		}
	}
}