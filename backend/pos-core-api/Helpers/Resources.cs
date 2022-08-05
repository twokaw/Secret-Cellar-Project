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

        public static void SetValue(string key, string value) => SetValue(DefaultAsset, key, value);
        
        public static void SetValue(string asset, string key, string value)
        {
            try
            {
                bool found = false;
                Dictionary<string, string> settings = GetValues();
                using IResourceWriter writer = new ResourceWriter(asset);
                {

                    foreach(KeyValuePair<string, string> kvp in settings)
                        if(kvp.Key == key)
                        {
                            writer.AddResource(EncryptionClass.EncryptString(key), EncryptionClass.EncryptString(value));
                            found = true;
                        }
                        else
                            writer.AddResource(EncryptionClass.EncryptString(kvp.Key), EncryptionClass.EncryptString(kvp.Value));

                    if(!found)
                        writer.AddResource(EncryptionClass.EncryptString(key), EncryptionClass.EncryptString(value));

                    writer.Close();  
                }
            }
            catch (Exception ex) { ErrorLogging.WriteToErrorLog(ex); }
        }

        public static void DeleteKey(string key) => DeleteKey(DefaultAsset, key);

        public static void DeleteKey(string asset, string key)
        {
            try
            {
                Dictionary<string, string> settings = GetValues();
                using IResourceWriter writer = new ResourceWriter(asset);
                {
                    foreach (KeyValuePair<string, string> kvp in settings)
                        if (kvp.Key != key)
                            writer.AddResource(EncryptionClass.EncryptString(kvp.Key), EncryptionClass.EncryptString(kvp.Value));


                    writer.Close();
                }
            }
            catch (Exception ex) { ErrorLogging.WriteToErrorLog(ex); }
        }

        public static Dictionary<string, string> GetValues() => GetValues(DefaultAsset);

        public static Dictionary<string, string> GetValues(string asset)
        {
            Dictionary<string, string> result = new();

            try
            {
                // try to read the resource file
                using ResourceReader rw = new(asset);
                {
                    IDictionaryEnumerator dict = rw.GetEnumerator();

                    while (dict.MoveNext())
                        result.Add(EncryptionClass.DecryptString(dict.Key.ToString()), EncryptionClass.DecryptString(dict.Value.ToString()));
                }
                rw.Close();
            }
            catch (Exception ex)
            {
                ErrorLogging.WriteToErrorLog(ex);
            }

            return result;
        }

        public static string GetValue(string key, string defaultValue = "") => GetValue(DefaultAsset, key, defaultValue);

        public static string GetValue(string asset, string key, string defaultValue)
        {
            string result = defaultValue;
            if (key != null)
            {
                try
                {
                    // try to read the resource file
                    using ResourceReader rw = new (asset);
                    {
                        IDictionaryEnumerator dict = rw.GetEnumerator();

                        while (dict.MoveNext())
                            if (EncryptionClass.DecryptString(dict.Key.ToString()) == key)
                            {
                               result = EncryptionClass.DecryptString(dict.Value.ToString());
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
