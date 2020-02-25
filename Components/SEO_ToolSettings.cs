
using DotNetNuke.Entities.Modules;

namespace GIBS.SEO_Tool.Components
{
    /// <summary>
    /// Provides strong typed access to settings used by module
    /// </summary>
    public class SEO_ToolSettings : ModuleSettingsBase
    {
        

        public string QueryStringKey
        {
            get
            {
                if (Settings.Contains("queryStringKey"))
                    return Settings["queryStringKey"].ToString();
                return "";
            }
            set
            {
                var mc = new ModuleController();
                mc.UpdateTabModuleSetting(TabModuleId, "queryStringKey", value.ToString());
            }
        }

        public string QueryStringKeyDefaultText
        {
            get
            {
                if (Settings.Contains("queryStringKeyDefaultText"))
                    return Settings["queryStringKeyDefaultText"].ToString();
                return "";
            }
            set
            {
                var mc = new ModuleController();
                mc.UpdateTabModuleSetting(TabModuleId, "queryStringKeyDefaultText", value.ToString());
            }
        }


        public string QueryStringKey2
        {
            get
            {
                if (Settings.Contains("queryStringKey2"))
                    return Settings["queryStringKey2"].ToString();
                return "";
            }
            set
            {
                var mc = new ModuleController();
                mc.UpdateTabModuleSetting(TabModuleId, "queryStringKey2", value.ToString());
            }
        }


        public string QueryStringKey2DefaultText
        {
            get
            {
                if (Settings.Contains("queryStringKey2DefaultText"))
                    return Settings["queryStringKey2DefaultText"].ToString();
                return "";
            }
            set
            {
                var mc = new ModuleController();
                mc.UpdateTabModuleSetting(TabModuleId, "queryStringKey2DefaultText", value.ToString());
            }
        }


        public string QueryStringKey3
        {
            get
            {
                if (Settings.Contains("queryStringKey3"))
                    return Settings["queryStringKey3"].ToString();
                return "";
            }
            set
            {
                var mc = new ModuleController();
                mc.UpdateTabModuleSetting(TabModuleId, "queryStringKey3", value.ToString());
            }
        }


        public string QueryStringKey3DefaultText
        {
            get
            {
                if (Settings.Contains("queryStringKey3DefaultText"))
                    return Settings["queryStringKey3DefaultText"].ToString();
                return "";
            }
            set
            {
                var mc = new ModuleController();
                mc.UpdateTabModuleSetting(TabModuleId, "queryStringKey3DefaultText", value.ToString());
            }
        }


        public string PageTitle
        {
            get
            {
                if (Settings.Contains("pageTitle"))
                    return Settings["pageTitle"].ToString();
                return "";
            }
            set
            {
                var mc = new ModuleController();
                mc.UpdateTabModuleSetting(TabModuleId, "pageTitle", value.ToString());
            }
        }

        public string Keywords
        {
            get
            {
                if (Settings.Contains("keywords"))
                    return Settings["keywords"].ToString();
                return "";
            }
            set
            {
                var mc = new ModuleController();
                mc.UpdateTabModuleSetting(TabModuleId, "keywords", value.ToString());
            }
        }

        public string PageDescription
        {
            get
            {
                if (Settings.Contains("pageDescription"))
                    return Settings["pageDescription"].ToString();
                return "";
            }
            set
            {
                var mc = new ModuleController();
                mc.UpdateTabModuleSetting(TabModuleId, "pageDescription", value.ToString());
            }
        }

        //#endregion
    }
}
