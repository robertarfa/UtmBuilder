using System;
using UtmBuilder.Core.Extensions;
using UtmBuilder.Core.ValueObjects;
using UtmBuilder.Core.ValueObjects.Exceptions;

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

	public static implicit operator string(Utm utm) => utm.ToString();

	public static implicit operator Utm(string link)
	{
		if (string.IsNullOrEmpty(link))
			throw new InvalidUrlException();

		var url = new Url(link);
		var segments = url.Address.Split("?");
		if (segments.Length == 1)
			throw new InvalidUrlException("No segments where provided");

		var pars = segments[1].Split("&");

		var source = "";
		var medium = "";
		var name = "";
		var id = "";
		var term = "";
		var content = "";

		for (int i = 0; i < pars.Length; i++)
		{
			var pair = pars[i].Split(new[] { '=' }, 2);
			if (pair.Length < 2) continue;
			var key = pair[0];
			var value = pair[1];
			switch (key)
			{
				case "utm_source":
					source = value;
					break;
				case "utm_medium":
					medium = value;
					break;
				case "utm_campaign":
					name = value;
					break;
				case "utm_id":
					id = value;
					break;
				case "utm_term":
					term = value;
					break;
				case "utm_content":
					content = value;
					break;
			}
		}

		var utm = new Utm(
				new Url(segments[0]),
				new Campaign(source, medium, name, id, term, content));
		return utm;

	}
	public override string ToString()
	{
		var segments = new List<string>();
		segments.AddIfNotNull("utm_source", Campaign.Source);
		segments.AddIfNotNull("utm_medium", Campaign.Medium);
		segments.AddIfNotNull("utm_campaign", Campaign.Name);
		segments.AddIfNotNull("utm_id", Campaign.Id);
		segments.AddIfNotNull("utm_term", Campaign.Term);
		segments.AddIfNotNull("utm_content", Campaign.Content);

		return $"{Url.Address}?{string.Join("&", segments)}";
	}
}

