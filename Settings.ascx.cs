using System;
using DotNetNuke.Entities.Modules;
using DotNetNuke.Services.Exceptions;

using GIBS.SEO_Tool.Components;

namespace GIBS.Modules.SEO_Tool
{
    public partial class Settings : ModuleSettingsBase
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
                    SEO_ToolSettings settingsData = new SEO_ToolSettings(this.TabModuleId);

                    if (settingsData.PageTitle != null)
                    {
                        txtPageTitle.Text = settingsData.PageTitle;
                    }
                    if (settingsData.QueryStringKey != null)
                    {
                        txtQueryStringKey.Text = settingsData.QueryStringKey;
                    }

                    if (settingsData.QueryStringKeyDefaultText != null)
                    {
                        txtQueryStringKeyDefaultText.Text = settingsData.QueryStringKeyDefaultText;
                    }


                    if (settingsData.QueryStringKey2 != null)
                    {
                        txtQueryStringKey2.Text = settingsData.QueryStringKey2;
                    }

                    if (settingsData.QueryStringKey2DefaultText != null)
                    {
                        txtQueryStringKey2DefaultText.Text = settingsData.QueryStringKey2DefaultText;
                    }

                    if (settingsData.QueryStringKey3 != null)
                    {
                        txtQueryStringKey3.Text = settingsData.QueryStringKey3;
                    }

                    if (settingsData.QueryStringKey3DefaultText != null)
                    {
                        txtQueryStringKey3DefaultText.Text = settingsData.QueryStringKey3DefaultText;
                    }


                    if (settingsData.Keywords != null)
                    {
                        txtKeywords.Text = settingsData.Keywords;
                    }
                    if (settingsData.PageDescription != null)
                    {
                        txtPageDescription.Text = settingsData.PageDescription;
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
                SEO_ToolSettings settingsData = new SEO_ToolSettings(this.TabModuleId);
             //   settingsData.Template = txtTemplate.Text;
                settingsData.QueryStringKey = txtQueryStringKey.Text;
                settingsData.QueryStringKeyDefaultText = txtQueryStringKeyDefaultText.Text;
                settingsData.QueryStringKey2 = txtQueryStringKey2.Text;
                settingsData.QueryStringKey2DefaultText = txtQueryStringKey2DefaultText.Text;
                settingsData.QueryStringKey3 = txtQueryStringKey3.Text;
                settingsData.QueryStringKey3DefaultText = txtQueryStringKey3DefaultText.Text;
                settingsData.PageTitle = txtPageTitle.Text;
                settingsData.Keywords = txtKeywords.Text;
                settingsData.PageDescription = txtPageDescription.Text;
            }
            catch (Exception ex)
            {
                Exceptions.ProcessModuleLoadException(this, ex);
            }
        }
    }
}