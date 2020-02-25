using System;
using DotNetNuke.Entities.Modules;
using DotNetNuke.Services.Exceptions;

using GIBS.SEO_Tool.Components;

namespace GIBS.Modules.SEO_Tool
{
    public partial class Settings : SEO_ToolSettings
    {

        /// <summary>
        /// handles the loading of the module setting for this
        /// control
        /// </summary>
        public override void LoadSettings()
        {
            try
            {
                if (!IsPostBack)
                {
                    //      SEO_ToolSettings settingsData = new SEO_ToolSettings(this.TabModuleId);

                    if (Settings.Contains("pageTitle"))
                    {
                        txtPageTitle.Text = PageTitle;
                    }
                    if (Settings.Contains("queryStringKey"))
                    {
                        txtQueryStringKey.Text = QueryStringKey;
                    }

                    if (Settings.Contains("queryStringKeyDefaultText"))
                    {
                        txtQueryStringKeyDefaultText.Text = QueryStringKeyDefaultText;
                    }


                    if (Settings.Contains("queryStringKey2"))
                    {
                        txtQueryStringKey2.Text = QueryStringKey2;
                    }

                    if (Settings.Contains("queryStringKey2DefaultText"))
                    {
                        txtQueryStringKey2DefaultText.Text = QueryStringKey2DefaultText;
                    }

                    if (Settings.Contains("queryStringKey3"))
                    {
                        txtQueryStringKey3.Text = QueryStringKey3;
                    }

                    if (Settings.Contains("queryStringKey3DefaultText"))
                    {
                        txtQueryStringKey3DefaultText.Text = QueryStringKey3DefaultText;
                    }


                    if (Settings.Contains("keywords"))
                    {
                        txtKeywords.Text = Keywords;
                    }
                    if (Settings.Contains("pageDescription"))
                    {
                        txtPageDescription.Text = PageDescription;
                    }
                }
            }
            catch (Exception ex)
            {
                Exceptions.ProcessModuleLoadException(this, ex);
            }
        }

        /// <summary>
        /// handles updating the module settings for this control
        /// </summary>
        public override void UpdateSettings()
        {
            try
            {
                QueryStringKey = txtQueryStringKey.Text;
                QueryStringKeyDefaultText = txtQueryStringKeyDefaultText.Text;
                QueryStringKey2 = txtQueryStringKey2.Text;
                QueryStringKey2DefaultText = txtQueryStringKey2DefaultText.Text;
                QueryStringKey3 = txtQueryStringKey3.Text;
                QueryStringKey3DefaultText = txtQueryStringKey3DefaultText.Text;
                PageTitle = txtPageTitle.Text;
                Keywords = txtKeywords.Text;
                PageDescription = txtPageDescription.Text;
            }
            catch (Exception ex)
            {
                Exceptions.ProcessModuleLoadException(this, ex);
            }
        }
    }
}