using System;
using System.Data;
using DotNetNuke;
using DotNetNuke.Framework;

namespace GIBS.SEO_Tool.Components
{
    public abstract class DataProvider
    {

        #region common methods

        /// <summary>
        /// var that is returned in the this singleton
        /// pattern
        /// </summary>
        private static DataProvider instance = null;

        /// <summary>
        /// private static cstor that is used to init an
        /// instance of this class as a singleton
        /// </summary>
        static DataProvider()
        {
            instance = (DataProvider)Reflection.CreateObject("data", "GIBS.SEO_Tool.Components", "");
        }

        /// <summary>
        /// Exposes the singleton object used to access the database with
        /// the conrete dataprovider
        /// </summary>
        /// <returns></returns>
        public static DataProvider Instance()
        {
            return instance;
        }

        #endregion


        #region Abstract methods

        /* implement the methods that the dataprovider should */

        public abstract IDataReader GetSEO_Tools(int moduleId);
        public abstract IDataReader GetSEO_Tool(int moduleId, int itemId);
        public abstract void AddSEO_Tool(int moduleId, string content, int userId);
        public abstract void UpdateSEO_Tool(int moduleId, int itemId, string content, int userId);
        public abstract void DeleteSEO_Tool(int moduleId, int itemId);

        #endregion

    }



}
