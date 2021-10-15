using Shared;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Resources;

namespace pos_core_api.Helpers
{ 
    public class Resources
    {
        public static string DefaultAsset { get; set; } = "myResources.resources";

        public static void SetValue(string key, string value)
        {
            SetValue(DefaultAsset, key, value);
        }
        public static void SetValue(string asset, string key, string value)
        {
            try
            {
                using IResourceWriter writer = new ResourceWriter(asset);
                {
                    // TODO: Encrypt connection string
                    // Adds resources to the resource writer.
                    writer.AddResource(key, value);
                    writer.Close();  
                }
            }
            catch (Exception ex) { ErrorLogging.WriteToErrorLog(ex); }
        }

        public static Dictionary<string, string> GetValues()
        {
            return GetValues(DefaultAsset);
        }

        public static Dictionary<string, string> GetValues(string asset)
        {
            Dictionary<string, string> result = new Dictionary<string, string>();

            try
            {
                // try to read the resource file
                using ResourceReader rw = new ResourceReader(asset);
                {
                    IDictionaryEnumerator dict = rw.GetEnumerator();

                    while (dict.MoveNext())
                        result.Add(dict.Key.ToString(), dict.Value.ToString());                        
                }
                rw.Close();
            }
            catch (Exception ex)
            {
                ErrorLogging.WriteToErrorLog(ex);
            }

            return result;
        }

        public static string GetValue(string key, string defaultValue = "")
        {
            return GetValue(DefaultAsset, key, defaultValue);
        }

        public static string GetValue(string asset, string key, string defaultValue)
        {
            string result = defaultValue;
            if (key != null)
            {
                try
                {
                    // try to read the resource file
                    using ResourceReader rw = new ResourceReader(asset);
                    {
                        IDictionaryEnumerator dict = rw.GetEnumerator();

                        while (dict.MoveNext())
                            if (dict.Key.ToString() == key)
                            {
                               result = dict.Value.ToString();
                               break;
                            }
                        rw.Close();
                    }
                }
                catch (Exception ex)
                {
                    ErrorLogging.WriteToErrorLog(ex);
                }
            }
            return result; 
        }
    }
}
