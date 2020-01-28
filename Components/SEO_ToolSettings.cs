using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

using DotNetNuke.Entities.Modules;
using DotNetNuke.Services.Localization;
using DotNetNuke.Common;

namespace GIBS.SEO_Tool.Components
{
    /// <summary>
    /// Provides strong typed access to settings used by module
    /// </summary>
    public class SEO_ToolSettings
    {
        ModuleController controller;
        int tabModuleId;

        public SEO_ToolSettings(int tabModuleId)
        {
            controller = new ModuleController();
            this.tabModuleId = tabModuleId;
        }

        protected T ReadSetting<T>(string settingName, T defaultValue)
        {
            Hashtable settings = controller.GetTabModuleSettings(this.tabModuleId);

            T ret = default(T);

            if (settings.ContainsKey(settingName))
            {
                System.ComponentModel.TypeConverter tc = System.ComponentModel.TypeDescriptor.GetConverter(typeof(T));
                try
                {
                    ret = (T)tc.ConvertFrom(settings[settingName]);
                }
                catch
                {
                    ret = defaultValue;
                }
            }
            else
                ret = defaultValue;

            return ret;
        }

        protected void WriteSetting(string settingName, string value)
        {
            controller.UpdateTabModuleSetting(this.tabModuleId, settingName, value);
        }

        #region public properties

        /// <summary>
        /// get/set template used to render the module content
        /// to the user
        /// </summary>
        //public string Template
        //{
        //    get { return ReadSetting<string>("template", null); }
        //    set { WriteSetting("template", value); }
        //}

        //DefaultText

        public string QueryStringKey
        {
            get { return ReadSetting<string>("queryStringKey", null); }
            set { WriteSetting("queryStringKey", value); }
        }
        public string QueryStringKeyDefaultText
        {
            get { return ReadSetting<string>("queryStringKeyDefaultText", null); }
            set { WriteSetting("queryStringKeyDefaultText", value); }
        }


        public string QueryStringKey2
        {
            get { return ReadSetting<string>("queryStringKey2", null); }
            set { WriteSetting("queryStringKey2", value); }
        }

        public string QueryStringKey2DefaultText
        {
            get { return ReadSetting<string>("queryStringKey2DefaultText", null); }
            set { WriteSetting("queryStringKey2DefaultText", value); }
        }

        public string QueryStringKey3
        {
            get { return ReadSetting<string>("queryStringKey3", null); }
            set { WriteSetting("queryStringKey3", value); }
        }

        public string QueryStringKey3DefaultText
        {
            get { return ReadSetting<string>("queryStringKey3DefaultText", null); }
            set { WriteSetting("queryStringKey3DefaultText", value); }
        }

        public string PageTitle
        {
            get { return ReadSetting<string>("pageTitle", null); }
            set { WriteSetting("pageTitle", value); }
        }

        public string Keywords
        {
            get { return ReadSetting<string>("keywords", null); }
            set { WriteSetting("keywords", value); }
        }

        public string PageDescription
        {
            get { return ReadSetting<string>("pageDescription", null); }
            set { WriteSetting("pageDescription", value); }
        }


        #endregion
    }
}
