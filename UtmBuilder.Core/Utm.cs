using System;
using UtmBuilder.Core.ValueObjects;

public class Utm
{
	//<summary>
	// Create a new Utm
	// </summary>
	public Utm(Url url, Campaign campaign)
	{
		Url = url;
		Campaign = campaign;
	}
	//<summary>
	// Url (Website Link)
	// </summary>
	public Url Url { get; }
	//<summary>
	// Campaign Details
	// </summary>
	public Campaign Campaign { get; }
}

