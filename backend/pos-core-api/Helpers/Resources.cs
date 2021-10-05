using Shared;
using System;
using System.Collections;
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

                // TODO: Encrypt connection string
                // Adds resources to the resource writer.
                writer.AddResource(key, value);

                // Writes the resources to the file or stream, and closes it.
                writer.Close();
            }
            catch (Exception ex) { ErrorLogging.WriteToErrorLog(ex); }
        }

        public static string GetValue(string key, string defaultValue = "")
        {
            return GetValue(DefaultAsset, key, defaultValue);
        }

        public static string GetValue(string asset, string key, string defaultValue = "")
        {
            if (key != null)
            {
                try
                {
                    // try to read the resource file
                    ResourceReader rw = new ResourceReader(asset);

                    IDictionaryEnumerator dict = rw.GetEnumerator();

                    while (dict.MoveNext())
                        if (dict.Key.ToString() == key)
                           return dict.Value.ToString();
                }
                catch (Exception ex)
                {
                    ErrorLogging.WriteToErrorLog(ex);
                }
            }
            return defaultValue;
        }
    }
}
