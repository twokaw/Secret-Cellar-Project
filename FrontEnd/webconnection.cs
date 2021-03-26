using Newtonsoft.Json;
using System;
using System.IO;
using System.Net;
using System.Text;
using System.Web.Script.Serialization;
//using System.Web.Script.Serialization;
using Shared;

namespace SecretCellar

{
    public class WebConnector
    {
        public class Response
        {
            public string Url = "";
            public string Result = "";
            public HttpStatusCode StatusCode = HttpStatusCode.NotFound;
        }

        public enum WebMethod
        {
            GET,
            HEAD,
            POST,
            PUT,
            DELETE,
            TRACE,
            OPTIONS
        }

        private bool _loggedin = false;
        private string _url = "";

        private readonly AuthenticateModel _cred = new AuthenticateModel() { EmployeeID = 1, Pin = 123 };

        public bool AutoRelogin = true;
        public CookieCollection Cookies;
        public Response LastResponse = null;
        public bool LoggedIn
        {
            get
            {
                if (!_loggedin)
                    Login();

                return _loggedin;
            }
        }
        public string Url
        {
            get
            {
                return _url;
            }
            set
            {
                _url = value.TrimEnd('/');
            }
        }

        #region 'Constructor'
        public WebConnector(string url, uint employeeID, uint pin)
        {
            Url = url;
            _cred = new AuthenticateModel() { EmployeeID = employeeID, Pin = pin};
            Login();
        }
        public WebConnector(string url) : this(url, 0, 1997613874) {}

        #endregion


        #region 'Public Methods'
        public string DataDelete(string apiurl, Response response = null)
        {
            return SendRequest(apiurl, WebMethod.DELETE, null, response);
        }

        public string DataGet(string apiurl, Response response = null)
        {
            return SendRequest(apiurl, WebMethod.GET, null, response);
        }

        public string DataPost(string apiurl, object obj = null, Response response = null)
        {
            return SendRequest(apiurl, WebMethod.POST, obj, response);
        }

        public string DataPut(string apiurl, object obj = null, Response response = null)
        {
            return SendRequest(apiurl, WebMethod.PUT, obj, response);
        }

        public bool Login(string password)
        {
            try
            {
               // _password = password;
                Login();
            }
            catch 
            {
                return false;
            }
            return true;
        }

        public Response UrlApi(string url, WebMethod method)
        {
            return UrlApi(url, "", method);
        }

        public Response UrlApi(string url, string postdata, WebMethod method)
        {
            HttpWebRequest request = SetupRequest(url, postdata, method);
            Response response = PostSetupRequest(request);

            if (IsLoginPage(response))
            {
                if (AutoRelogin)
                {
                    request = SetupRequest(url, postdata, method);
                    response = PostSetupRequest(request);
                }
            }

            return response;
        }

        public Response UrlApi(string url, object postdata, WebMethod method)
        {
            return UrlApi(url, JsonConvert.SerializeObject(postdata), method);
        }

        public Response UrlApi(string url, byte[] postdata, WebMethod method)
        {
            HttpWebRequest request = SetupRequest(url, postdata, method);
            Response response = PostSetupRequest(request);

            if (IsLoginPage(response) && AutoRelogin)
            {
                request = SetupRequest(url, postdata, method);
                response = PostSetupRequest(request);
            }

            return response;
        }
        #endregion


    #region 'Private Methods'
    private bool IsLoginPage(Response response)
        {
            if (response.StatusCode == HttpStatusCode.InternalServerError )
            {
                if (AutoRelogin)
                    Login();
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool IsLoginPage(string response)
        {
            if (response.Contains("/Login.aspx"))
            {
                if (AutoRelogin)
                    Login();

                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Login()
        {
            return Login( _cred );
        }

        private bool Login(AuthenticateModel cred)
        {
            if (string.IsNullOrWhiteSpace(_url))
                return false;

            string loginurl = $"{_url}/api/EmployeeAuth/authenticate";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(loginurl);
            JavaScriptSerializer serial = new JavaScriptSerializer();
            string postdata = serial.Serialize(cred);
            byte[] bytearray = Encoding.UTF8.GetBytes(postdata);

            request.Accept = "application/json";
            request.ContentType = "application/json";
            request.ContentLength = bytearray.Length;
            request.Method = "POST";
            request.CookieContainer = new CookieContainer();

            try
            {
                Stream datastream = request.GetRequestStream();
                datastream.Write(bytearray, 0, bytearray.Length);
                datastream.Close();

                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                datastream = response.GetResponseStream();
                StreamReader reader = new StreamReader(datastream);
                string responsefromserver = reader.ReadToEnd();

                if (!string.IsNullOrWhiteSpace((responsefromserver)))
                {
                    _loggedin = true;
                    Cookies = ((HttpWebResponse)response).Cookies;
                    return true;
                }
            }
            catch(Exception ex)
            {
                _loggedin = false;
                DataAccess.instance.LogError(ex, "Login", "Login error");
            }
            return false;
        }

        private Response PostSetupRequest(HttpWebRequest request)
        {
            HttpWebResponse response;
            Response responsefromserver = new Response();

            try
            {
                response = (HttpWebResponse)request.GetResponse();
                responsefromserver.StatusCode = response.StatusCode;

                Stream datastream = response.GetResponseStream();

                StreamReader reader = new StreamReader(datastream);

                responsefromserver.Result = reader.ReadToEnd();

                reader.Close();
                response.Close();
            }
            catch (Exception ex)
            {
                responsefromserver.StatusCode = HttpStatusCode.InternalServerError;
                responsefromserver.Result = ex.Message;
                DataAccess.instance.LogError(ex, "PostSetupRequest", request.Address.ToString());
            }

            return responsefromserver;
        }

        private HttpWebRequest PreSetupRequest(string url, WebMethod method)
        {
            if (_loggedin)
                Login();

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.CookieContainer = new CookieContainer();
            request.Method = method.ToString();

            if (Cookies != null)
            {
                request.CookieContainer.Add(Cookies);
            }

            return request;
        }

        private string SendRequest(string apiurl, WebMethod method, object obj, Response response)
        {
            string url = $"{_url}/{apiurl}";

            if (response == null)
                response = new Response();

            response.Url = url;
            try
            {
                if (obj == null)
                {
                    response = UrlApi(url, method);
                }
                else
                {
                    response = UrlApi(url, obj, method);
                }
                LastResponse = response;
                LastResponse.Url = url;
                if (!string.IsNullOrWhiteSpace(response.Result) && response.StatusCode == HttpStatusCode.OK)
                {
                    
                    return response.Result;
                }
            }
            catch (Exception ex)
            {
                if (response == null)
                {
                    response = new Response
                    {
                        Result = ex.Message,
                        StatusCode = HttpStatusCode.Unused
                    };
                }
                LastResponse = response;
                LastResponse.Url = url;
                DataAccess.instance.LogError(ex, "SendRequest", apiurl);
            }

            return "";
        }

        private HttpWebRequest SetupRequest(string url, byte[] postdata, WebMethod method)
        {
            HttpWebRequest request = PreSetupRequest(url, method);

            try
            {
                if (postdata.Length > 0)
                {
                    Stream writestream = request.GetRequestStream();
                    writestream.Write(postdata, 0, postdata.Length);
                    writestream.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"SetupRequest Error {ex.Message}");
                DataAccess.instance.LogError(ex, "SetupRequest", url);
            }

            return request;
        }

        private HttpWebRequest SetupRequest(string url, string postjsondata, WebMethod method)
        {
            HttpWebRequest request = PreSetupRequest(url, method);

            try
            {
                if (!string.IsNullOrEmpty(postjsondata))
                {
                    Stream stream = request.GetRequestStream();
                    StreamWriter writestream = new StreamWriter(stream);

                    request.ContentType = "application/json";
                    writestream.Write(postjsondata);
                    writestream.Flush();
                    writestream.Close();
                }
                else
                    if (method == WebMethod.POST || method == WebMethod.PUT)
                        request.ContentLength = 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"SetupRequest Error {ex.Message}");
                DataAccess.instance.LogError(ex, "SetupRequest", $"{url} : {postjsondata}");
            }

            return request;
        }

        #endregion
    }
}