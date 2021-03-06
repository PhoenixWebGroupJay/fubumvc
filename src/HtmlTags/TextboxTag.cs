namespace HtmlTags
{
	using Constants;

	public class TextboxTag : InputTag
    {
        public TextboxTag()
        {
        	Type(InputTypeConstants.Text);
        }

        public TextboxTag(string name, string value) : this()
        {
            Attr(HtmlAttributeConstants.Name, name);
            Attr(HtmlAttributeConstants.Value, value);
        }
    }
}