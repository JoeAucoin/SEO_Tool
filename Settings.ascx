<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Settings.ascx.cs" Inherits="GIBS.Modules.SEO_Tool.Settings" %>
<%@ Register TagPrefix="dnn" TagName="Label" Src="~/controls/LabelControl.ascx" %>
<%@ Register TagPrefix="dnn" TagName="SectionHead" Src="~/controls/SectionHeadControl.ascx" %>

<div class="dnnForm" id="form-settings">

    <fieldset>

<dnn:sectionhead id="sectGeneralSettings" cssclass="Head" runat="server" text="General Settings" section="GeneralSection"
	includerule="False" isexpanded="True"></dnn:sectionhead>

<div id="GeneralSection" runat="server">   

	<div class="dnnFormItem">
		 <dnn:label id="lblQueryStringKey" text="QueryString Key 1" 
                controlname="txtQueryStringKey" runat="server" Suffix=":" /> 
		 
            <asp:TextBox id="txtQueryStringKey" Runat="server" 
                Width="220px"></asp:TextBox> 
	</div>

	<div class="dnnFormItem">
<dnn:label id="lblQueryStringKeyDefaultText" text="QueryString Key DefaultText" 
                controlname="txtQueryStringKeyDefaultText" runat="server" Suffix=":" /> 
		 
            <asp:TextBox id="txtQueryStringKeyDefaultText" Runat="server" 
                Width="220px"></asp:TextBox>
	</div>

	
	
	<div class="dnnFormItem">
 <dnn:label id="lblQueryStringKey2" text="QueryString Key 2" 
                controlname="txtQueryStringKey2" runat="server" Suffix=":" /> 
		 
            <asp:TextBox id="txtQueryStringKey2" Runat="server" 
                Width="220px"></asp:TextBox>
	</div>

	<div class="dnnFormItem">
<dnn:label id="lblQueryStringKey2DefaultText" text="QueryString Key 2 DefaultText" 
                controlname="txtQueryStringKey2DefaultText" runat="server" Suffix=":" /> 
		 
            <asp:TextBox id="txtQueryStringKey2DefaultText" Runat="server" 
                Width="220px"></asp:TextBox>
	</div>
	
	
	<div class="dnnFormItem">
 <dnn:label id="lblQueryStringKey3" text="QueryString Key 3" 
                controlname="txtQueryStringKey3" runat="server" Suffix=":" /> 
		 
            <asp:TextBox id="txtQueryStringKey3" Runat="server" 
                Width="220px"></asp:TextBox> 
	</div>

	<div class="dnnFormItem">
<dnn:label id="lblQueryStringKey3DefaultText" text="QueryString Key 3 DefaultText" 
                controlname="txtQueryStringKey3DefaultText" runat="server" Suffix=":" /> 
		 
            <asp:TextBox id="txtQueryStringKey3DefaultText" Runat="server" 
                Width="220px"></asp:TextBox>
	</div>		
	
	
	<div class="dnnFormItem">
<dnn:label id="lblPageTitle" text="Page Title" 
                controlname="txtPageTitle" runat="server" Suffix=":" /> 
		 
            <asp:TextBox ID="txtPageTitle" runat="server" Width="220px"></asp:TextBox>
	</div>

	<div class="dnnFormItem">
            <dnn:label id="lblKeywords" text="Keywords" 
                controlname="txtKeywords" runat="server" Suffix=":" /> 
		 
            <asp:TextBox ID="txtKeywords" runat="server" Width="220px"></asp:TextBox>
 
	</div>

	<div class="dnnFormItem">
            <dnn:label id="lblPageDescription" text="Page Description" 
                controlname="txtPageDescription" runat="server" Suffix=":" /> 
		 
            <asp:TextBox ID="txtPageDescription" runat="server" Width="220px" TextMode="MultiLine"></asp:TextBox>

	</div>




 </div>
        


    </fieldset>

</div>