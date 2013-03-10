// Type: System.Web.UI.WebControls.ContentPlaceHolder
// Assembly: System.Web, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
// Assembly location: C:\Windows\Microsoft.NET\Framework\v4.0.30319\System.Web.dll

using System.ComponentModel;
using System.Runtime;
using System.Web.UI;

namespace System.Web.UI.WebControls
{
	/// <summary>
	/// Defines a region for content in an ASP.NET master page.
	/// </summary>
	[ToolboxData("<{0}:ContentPlaceHolder runat=\"server\"></{0}:ContentPlaceHolder>")]
	[ToolboxItemFilter("System.Web.UI")]
	[ControlBuilder(typeof (ContentPlaceHolderBuilder))]
	[Designer("System.Web.UI.Design.WebControls.ContentPlaceHolderDesigner, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	[ToolboxItemFilter("Microsoft.VisualStudio.Web.WebForms.MasterPageWebFormDesigner", ToolboxItemFilterType.Require)]
	public class ContentPlaceHolder : Control, INonBindingContainer, INamingContainer
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="T:System.Web.UI.WebControls.ContentPlaceHolder"/> class.
		/// </summary>
		[TargetedPatchingOptOut("Performance critical to inline this type of method across NGen image boundaries")]
		public ContentPlaceHolder();
	}
}
