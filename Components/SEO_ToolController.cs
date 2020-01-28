using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using DotNetNuke;
using DotNetNuke.Common.Utilities;
using DotNetNuke.Entities.Modules;
using DotNetNuke.Services.Search;

namespace GIBS.SEO_Tool.Components
{
    public class SEO_ToolController :  IPortable
    {

        #region public method

        /// <summary>
        /// Gets all the SEO_ToolInfo objects for items matching the this moduleId
        /// </summary>
        /// <param name="moduleId"></param>
        /// <returns></returns>
        public List<SEO_ToolInfo> GetSEO_Tools(int moduleId)
        {
            return CBO.FillCollection<SEO_ToolInfo>(DataProvider.Instance().GetSEO_Tools(moduleId));
        }

        /// <summary>
        /// Get an info object from the database
        /// </summary>
        /// <param name="moduleId"></param>
        /// <param name="itemId"></param>
        /// <returns></returns>
        public SEO_ToolInfo GetSEO_Tool(int moduleId, int itemId)
        {
            return (SEO_ToolInfo)CBO.FillObject(DataProvider.Instance().GetSEO_Tool(moduleId, itemId), typeof(SEO_ToolInfo));
        }


        /// <summary>
        /// Adds a new SEO_ToolInfo object into the database
        /// </summary>
        /// <param name="info"></param>
        public void AddSEO_Tool(SEO_ToolInfo info)
        {
            //check we have some content to store
            if (info.Content != string.Empty)
            {
                DataProvider.Instance().AddSEO_Tool(info.ModuleId, info.Content, info.CreatedByUser);
            }
        }

        /// <summary>
        /// update a info object already stored in the database
        /// </summary>
        /// <param name="info"></param>
        public void UpdateSEO_Tool(SEO_ToolInfo info)
        {
            //check we have some content to update
            if (info.Content != string.Empty)
            {
                DataProvider.Instance().UpdateSEO_Tool(info.ModuleId, info.ItemId, info.Content, info.CreatedByUser);
            }
        }


        /// <summary>
        /// Delete a given item from the database
        /// </summary>
        /// <param name="moduleId"></param>
        /// <param name="itemId"></param>
        public void DeleteSEO_Tool(int moduleId, int itemId)
        {
            DataProvider.Instance().DeleteSEO_Tool(moduleId, itemId);
        }


        #endregion

    
        #region IPortable Members

        /// <summary>
        /// Exports a module to xml
        /// </summary>
        /// <param name="ModuleID"></param>
        /// <returns></returns>
        public string ExportModule(int moduleID)
        {
            StringBuilder sb = new StringBuilder();

            List<SEO_ToolInfo> infos = GetSEO_Tools(moduleID);

            if (infos.Count > 0)
            {
                sb.Append("<SEO_Tools>");
                foreach (SEO_ToolInfo info in infos)
                {
                    sb.Append("<SEO_Tool>");
                    sb.Append("<content>");
                    sb.Append(XmlUtils.XMLEncode(info.Content));
                    sb.Append("</content>");
                    sb.Append("</SEO_Tool>");
                }
                sb.Append("</SEO_Tools>");
            }

            return sb.ToString();
        }

        /// <summary>
        /// imports a module from an xml file
        /// </summary>
        /// <param name="ModuleID"></param>
        /// <param name="Content"></param>
        /// <param name="Version"></param>
        /// <param name="UserID"></param>
        public void ImportModule(int ModuleID, string Content, string Version, int UserID)
        {
            XmlNode infos = DotNetNuke.Common.Globals.GetContent(Content, "SEO_Tools");

            foreach (XmlNode info in infos.SelectNodes("SEO_Tool"))
            {
                SEO_ToolInfo SEO_ToolInfo = new SEO_ToolInfo();
                SEO_ToolInfo.ModuleId = ModuleID;
                SEO_ToolInfo.Content = info.SelectSingleNode("content").InnerText;
                SEO_ToolInfo.CreatedByUser = UserID;

                AddSEO_Tool(SEO_ToolInfo);
            }
        }

        #endregion
    }
}
