<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ViewSEO_Tool.ascx.cs" Inherits="GIBS.Modules.SEO_Tool.ViewSEO_Tool" %>
<%@ Register TagPrefix="dnn" TagName="Label" Src="~/controls/labelcontrol.ascx" %>





<asp:PlaceHolder ID="PlaceHolder1" runat="server"></asp:PlaceHolder>

<div><asp:Label ID="lblPageTitle" runat="server" Text="" /></div>
<asp:datalist id="lstContent" datakeyfield="ItemID" runat="server" cellpadding="4" OnItemDataBound="lstContent_ItemDataBound" Visible="<%# IsEditable %>">
  <itemtemplate>
    <table cellpadding="4" width="100%">
      <tr>
        <td valign="top" width="100%" align="left">
          <asp:HyperLink ID="HyperLink1" NavigateUrl='<%# EditUrl("ItemId",DataBinder.Eval(Container.DataItem,"ItemId").ToString()) %>' Visible="<%# IsEditable %>" runat="server">
            <asp:Image ID="Image1" Runat="server" ImageUrl="~/images/edit.gif" AlternateText="Edit" Visible="<%#IsEditable%>" resourcekey="Edit"/>
          </asp:HyperLink>
          <asp:Label ID="lblContent" runat="server" CssClass="Normal"/>
        </td>
      </tr>
    </table>
  </itemtemplate>
</asp:datalist>