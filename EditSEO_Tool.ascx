<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="EditSEO_Tool.ascx.cs" Inherits="GIBS.Modules.SEO_Tool.EditSEO_Tool" %>
<%@ Register TagPrefix="dnn" TagName="Label" Src="~/controls/labelcontrol.ascx" %>
<%@ Register TagPrefix="dnn" TagName="TextEditor" Src="~/controls/TextEditor.ascx"%>
<%@ Register TagPrefix="dnn" TagName="Audit" Src="~/controls/ModuleAuditControl.ascx" %>





<div class="dnnForm" id="form-edit">


    <fieldset>


        <div class="dnnFormItem">
	<dnn:Label id="lblContent" runat="server" controlname="lblContent" suffix=":"></dnn:Label>
			<dnn:TextEditor id="txtContent" runat="server" height="600" width="100%" />
			<asp:RequiredFieldValidator ID="valContent" resourcekey="valContent.ErrorMessage" ControlToValidate="txtContent"
				CssClass="NormalRed" Display="Dynamic" ErrorMessage="<br>Content is required" Runat="server" />
        </div>

    </fieldset>

</div>





<p>
    <asp:linkbutton cssclass="CommandButton" id="cmdUpdate" resourcekey="cmdUpdate" runat="server" borderstyle="none" text="Update" OnClick="cmdUpdate_Click"></asp:linkbutton>&nbsp;
    <asp:linkbutton cssclass="CommandButton" id="cmdCancel" resourcekey="cmdCancel" runat="server" borderstyle="none" text="Cancel" causesvalidation="False" OnClick="cmdCancel_Click"></asp:linkbutton>&nbsp;
    <asp:linkbutton cssclass="CommandButton" id="cmdDelete" resourcekey="cmdDelete" runat="server" borderstyle="none" text="Delete" causesvalidation="False" OnClick="cmdDelete_Click"></asp:linkbutton>&nbsp;
</p>
<dnn:Audit id="ctlAudit" runat="server" />