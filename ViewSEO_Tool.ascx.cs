
using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Web.UI;
using System.Web.UI.WebControls;
using DotNetNuke.Common.Utilities;
using DotNetNuke.Entities.Modules;
using DotNetNuke.Entities.Modules.Actions;
using DotNetNuke.Services.Exceptions;
using DotNetNuke.Services.Localization;

using GIBS.SEO_Tool.Components;
using DotNetNuke.Common;

namespace GIBS.Modules.SEO_Tool
{
    public partial class ViewSEO_Tool : SEO_ToolSettings, IActionable
    {


        public string _QueryStringKey = "";
        public string _QueryStringKey2 = "";
        public string _QueryStringKey3 = "";
        public string _PageTitle = "";
        public string _PageDescription = "";
        public string _Keywords = "";

        public string _QueryStringKeyValue = "";
        public string _QueryStringKeyDefaultText = "";
        public string _QueryStringKey2Value = "";
        public string _QueryStringKey2DefaultText = "";
        public string _QueryStringKey3Value = "";
        public string _QueryStringKey3DefaultText = "";


        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                {

                    GetSettings();

                    if (_QueryStringKey.ToString().Trim() != "")
                    {
                        MakeSEO();
                    }
                    else
                    {
                     //   lblTitle.Text = "Click settings to configure module.";
                        lblPageTitle.Text = "Click settings to configure module.";
                    }


                    List<SEO_ToolInfo> items;
                    SEO_ToolController controller = new SEO_ToolController();

                    items = controller.GetSEO_Tools(this.ModuleId);

                    //     items = controller.GetSEO_Tool(this.ModuleId, 

                    //check if we have some content to display, otherwise
                    //display a sample default conent from the resource
                    //settings
                    if (items.Count == 0)
                    {
                        SEO_ToolInfo item = new SEO_ToolInfo();
                        item.ModuleId = this.ModuleId;
                        item.CreatedByUser = this.UserId;
                        item.Content = Localization.GetString("DefaultContent", LocalResourceFile);

                        items.Add(item);
                    }

                    //bind the data
                    lstContent.DataSource = items;
                    lstContent.DataBind();

                    LiteralControl l = new LiteralControl();


                    foreach (SEO_ToolInfo sItem in items)
                    {
                        l.Text = Server.HtmlDecode(sItem.Content.ToString().Replace("[" + _QueryStringKey.ToString() + "]", _QueryStringKeyValue.ToString().Replace("_"," ").ToString()).ToString());
                        //l.Text.Replace
                        l.Text = l.Text.ToString().Replace("[" + _QueryStringKey2.ToString() + "]", _QueryStringKey2Value.ToString().Replace("_", " ").ToString()).ToString();
                        l.Text = l.Text.ToString().Replace("[" + _QueryStringKey3.ToString() + "]", _QueryStringKey3Value.ToString().Replace("_", " ").ToString()).ToString();


                        //Code to add my liInUl to ul
                    }

                    PlaceHolder1.Controls.Add(l);


                }
            }
            catch (Exception ex)
            {
                Exceptions.ProcessModuleLoadException(this, ex);
            }
        }


        public void GetSettings()
        {

            try
            {

                //    SEO_ToolSettings settingsData = new SEO_ToolSettings(this.TabModuleId);



                if (Settings.Contains("queryStringKey"))
                {
                    _QueryStringKey = QueryStringKey.ToString();
                }

                if (Settings.Contains("queryStringKeyDefaultText"))
                {
                    _QueryStringKeyDefaultText = QueryStringKeyDefaultText.ToString();
                }

                if (Settings.Contains("queryStringKey2"))
                {
                    _QueryStringKey2 = QueryStringKey2.ToString();
                }

                if (Settings.Contains("queryStringKey2DefaultText"))
                {
                    _QueryStringKey2DefaultText = QueryStringKey2DefaultText.ToString();
                }

                if (Settings.Contains("queryStringKey3"))
                {
                    _QueryStringKey3 = QueryStringKey3.ToString();
                }

                if (Settings.Contains("queryStringKey3DefaultText"))
                {
                    _QueryStringKey3DefaultText = QueryStringKey3DefaultText.ToString();
                }

                if (Settings.Contains("pageTitle"))
                {

                    _PageTitle = PageTitle.ToString();
                }

                if (Settings.Contains("pageDescription"))
                {
                    _PageDescription = PageDescription.ToString();
                }
                //

                if (Settings.Contains("keywords"))
                {

                    _Keywords = Keywords.ToString();

                }

            }
            catch (Exception ex)
            {
                Exceptions.ProcessModuleLoadException(this, ex);
            }

        }


        public void MakeSEO()
        {

            try
            {

                string vTitle = "";
                DotNetNuke.Framework.CDefault GIBSpage = (DotNetNuke.Framework.CDefault)this.Page;


                if (Request.QueryString[_QueryStringKey.ToString()] != null)
                {
                    vTitle = Request.QueryString[_QueryStringKey.ToString()].ToString();
                    _QueryStringKeyValue = vTitle.ToString().Replace("_", " ").ToString();
                }
                else
                {
                    _QueryStringKeyValue = _QueryStringKeyDefaultText.ToString();
                
                }

                // ADD NEW STUFF

                if (Request.QueryString[_QueryStringKey2.ToString()] != null)
                {
                    vTitle += " " + Request.QueryString[_QueryStringKey2.ToString()].ToString().Replace("_", " ").ToString();
                    _QueryStringKey2Value = Request.QueryString[_QueryStringKey2.ToString()].ToString().Replace("_", " ").ToString();
                }
                else
                {
                    _QueryStringKey2Value = _QueryStringKey2DefaultText.ToString();
                }

                if (Request.QueryString[_QueryStringKey3.ToString()] != null)
                {
                    vTitle += " " + Request.QueryString[_QueryStringKey3.ToString()].ToString().Replace("_", " ").ToString();
                    _QueryStringKey3Value = Request.QueryString[_QueryStringKey3.ToString()].ToString().Replace("_", " ").ToString();
                }
                else
                {
                    _QueryStringKey3Value = _QueryStringKey3DefaultText.ToString();
                }







                if (_QueryStringKey.ToString().Length > 0)
                {





                    GIBSpage.Title = _QueryStringKeyValue.ToString() + " " + _PageTitle.ToString();
                    GIBSpage.KeyWords = _QueryStringKeyValue.ToString() + "," + _Keywords.ToString();
                    GIBSpage.Description = _QueryStringKeyValue.ToString() + " " + _PageTitle.ToString() + ". " + _PageDescription.ToString();

                    ModuleConfiguration.ModuleTitle = _QueryStringKeyValue.ToString() + " " + _PageTitle.ToString(); 

                    //Control ctl = Globals.FindControlRecursiveDown(this.ContainerControl, "lblTitle");
                    //if ((ctl != null))
                    //{
                    //    ((Label)ctl).Text = vTitle.ToString();
                    //}

                    //if (_QueryStringKey.ToString().Length > 0)
                    //{

                    //}
                    //else
                    //{
                    //    lblTitle.Text = _PageTitle.ToString();

                    //    GIBSpage.Title = _PageTitle.ToString();
                    //    GIBSpage.KeyWords = _Keywords.ToString();
                    //    GIBSpage.Description = _PageTitle.ToString() + ". " + _PageDescription.ToString();

                    //}


                    //if (_QueryStringKey2.ToString().Length > 0)
                    //{
                    //    vTitle += ", " + Request.QueryString[_QueryStringKey2.ToString()];
                    //    lblTitle.Text = vTitle.ToString() + " " + _PageTitle.ToString();
                    //    GIBSpage.Title = vTitle.ToString() + " " + _PageTitle.ToString();
                    //    GIBSpage.KeyWords = vTitle.ToString() + "," + _Keywords.ToString();
                    //    GIBSpage.Description = vTitle.ToString() + " " + _PageTitle.ToString() + ". " + _PageDescription.ToString();
                    //}

                    //if (_QueryStringKey3.ToString().Length > 0)
                    //{
                    //    vTitle += ", " + Request.QueryString[_QueryStringKey3.ToString()];
                    //    lblTitle.Text = vTitle.ToString() + " " + _PageTitle.ToString();
                    //    GIBSpage.Title = vTitle.ToString() + " " + _PageTitle.ToString();
                    //    GIBSpage.KeyWords = vTitle.ToString() + "," + _Keywords.ToString();
                    //    GIBSpage.Description = vTitle.ToString() + " " + _PageTitle.ToString() + ". " + _PageDescription.ToString();
                    //}

                    // Control ctl = DotNetNuke.Common.Globals.FindControlRecursiveDown(this.ContainerControl, "lblTitle");
                    // if ((ctl != null))
                    // {
                    //     ((System.Web.UI.WebControls.Label)ctl).Text = lblTitle.Text.ToString();
                    // }
                    //Control.


                    //if (this.PortalSettings.UserMode == DotNetNuke.Entities.Portals.PortalSettings.Mode.Edit)
                    //{
                    //    Label1.Visible = true;
                    //}
                    //else
                    //{
                    // //   Label1.Visible = false;
                    //    ((Label)ctl).Visible = false;
                    //}


                }
                else
                {
                    lblPageTitle.Text = "Log in and click settings to configure module.";
                }


              //  PlaceHolder1.



            }
            catch (Exception exc) //Module failed to load
            {
                Exceptions.ProcessModuleLoadException(this, exc);
            }



        }

        #region IActionable Members

        public DotNetNuke.Entities.Modules.Actions.ModuleActionCollection ModuleActions
        {
            get
            {
                //create a new action to add an item, this will be added to the controls
                //dropdown menu
                ModuleActionCollection actions = new ModuleActionCollection();
                actions.Add(GetNextActionID(), Localization.GetString(ModuleActionType.AddContent, this.LocalResourceFile),
                    ModuleActionType.AddContent, "", "", EditUrl(), false, DotNetNuke.Security.SecurityAccessLevel.Edit,
                     true, false);

                return actions;
            }
        }

        #endregion


        /// <summary>
        /// Handles the items being bound to the datalist control. In this method we merge the data with the
        /// template defined for this control to produce the result to display to the user
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void lstContent_ItemDataBound(object sender, System.Web.UI.WebControls.DataListItemEventArgs e)
        {
            Label content = (Label)e.Item.FindControl("lblContent");
            string contentValue = string.Empty;

            //SEO_ToolSettings settingsData = new SEO_ToolSettings(this.TabModuleId);

            //if (settingsData.PageTitle != null)
            //{
            //    //apply the content to the template
            //    ArrayList propInfos = CBO.GetPropertyInfo(typeof(SEO_ToolInfo));
            //    contentValue = settingsData.PageTitle;

            //    if (contentValue.Length != 0)
            //    {
            //        foreach (PropertyInfo propInfo in propInfos)
            //        {
            //            object propertyValue = DataBinder.Eval(e.Item.DataItem, propInfo.Name);
            //            if (propertyValue != null)
            //            {
            //                contentValue = contentValue.Replace("[" + propInfo.Name.ToUpper() + "]",
            //                        Server.HtmlDecode(propertyValue.ToString()));
            //            }
            //        }
            //    }
            //    else
            //        //blank template so just set the content to the value
            //        contentValue = Server.HtmlDecode(DataBinder.Eval(e.Item.DataItem, "Content").ToString());
            //}
            //else
            //{
            //    //no template so just set the content to the value
            //    contentValue = Server.HtmlDecode(DataBinder.Eval(e.Item.DataItem, "Content").ToString());
            //}

            contentValue = DataBinder.Eval(e.Item.DataItem, "ItemId").ToString() 
                + " - Created by " + DataBinder.Eval(e.Item.DataItem, "CreatedByUserName").ToString() 
                + " on "
                + DataBinder.Eval(e.Item.DataItem, "CreatedDate").ToString();

            content.Text = contentValue;
        }

    }
}