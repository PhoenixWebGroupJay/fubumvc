﻿namespace HtmlTags
{
	using Constants;

	public class BaseTag : HtmlTag
	{
		public BaseTag() : base(HtmlTagConstants.Base)
		{
		}

		public BaseTag Href(string path)
		{
			Attr(HtmlAttributeConstants.Href, path);
			return this;
		}
	}
}