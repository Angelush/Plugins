﻿using System;
using Sdl.LanguagePlatform.TranslationMemoryApi;

namespace OpenNMT
{
    /// <summary>
    /// This class is used to hold the provider plug-in settings. 
    /// All settings are automatically stored in a URI.
    /// </summary>
    public class ListTranslationOptions
    {
        #region "TranslationMethod"
        public static readonly TranslationMethod ProviderTranslationMethod = TranslationMethod.MachineTranslation;
        #endregion

        #region "TranslationProviderUriBuilder"
        TranslationProviderUriBuilder _uriBuilder;        

        public ListTranslationOptions()
        {
            _uriBuilder = new TranslationProviderUriBuilder(OpenNmtProvider.ListTranslationProviderScheme);
            System.Console.WriteLine(OpenNmtProvider.ListTranslationProviderScheme);
        }

        public ListTranslationOptions(Uri uri)
        {
            _uriBuilder = new TranslationProviderUriBuilder(uri);
        }
        #endregion
        
        public string languageDirection
        {
            get { return GetStringParameter("languageDirection"); }
            set { SetStringParameter("languageDirection", value); }
        }
       
        public string serverAddress
        {
            get { return GetStringParameter("serverAddress"); }
            set { SetStringParameter("serverAddress", value); }
        }
        public string port
        {
            get { return GetStringParameter("port"); }
            set { SetStringParameter("port", value); }
        }

        public string languageDirectionSource
        {
            get { return GetStringParameter("languageDirectionSource"); }
            set { SetStringParameter("languageDirectionSource", value); }
        }
        public string languageDirectionTarget
        {
            get { return GetStringParameter("languageDirectionTarget"); }
            set { SetStringParameter("languageDirectionTarget", value); }
        }

        

        

        #region "SetStringParameter"
        private void SetStringParameter(string p, string value)
        {
            _uriBuilder[p] = value;
        }
        #endregion

        #region "GetStringParameter"
        private string GetStringParameter(string p)
        {
            string paramString = _uriBuilder[p];
            return paramString;
        }
        #endregion


        #region "Uri"
        public Uri Uri
        {            
            get
            {
                return _uriBuilder.Uri;                
            }
        }
        #endregion
    }
}
